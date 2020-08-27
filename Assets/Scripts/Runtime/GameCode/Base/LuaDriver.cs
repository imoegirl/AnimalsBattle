using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System;
using System.IO;

public class LuaDriver : TaleSingleton<LuaDriver>
{
    private LuaEnv globalLuaEnv = null;

    private Action LuaFuncInitGame;
    private Action LuaFuncUpdate;
    private Action LuaFuncLateUpdate;
    private Action LuaFuncOnApplicationQuit;

    private float lastGCTime = 0.0f;
    private float gcInterval = 120.0f;

    protected override void InitOnCreate()
    {
        globalLuaEnv = new LuaEnv();
        globalLuaEnv.AddLoader(LuaLoader);
        byte[] luaMainCode = LoadLuaScript("Main");
        DoStringWithException(luaMainCode, "Main", globalLuaEnv.Global);
        lastGCTime = Time.realtimeSinceStartup;

        globalLuaEnv.Global.Get("InitGame", out LuaFuncInitGame);
        globalLuaEnv.Global.Get("Update", out LuaFuncUpdate);
        globalLuaEnv.Global.Get("LateUpdate", out LuaFuncLateUpdate);
        globalLuaEnv.Global.Get("OnApplicationQuit", out LuaFuncOnApplicationQuit);
    }


    private void DoStringWithException(byte[] codeBytes, string chunkName = "chunk", LuaTable env = null)
    {
        try
        {
            globalLuaEnv.DoString(codeBytes, chunkName, env);
        }catch(Exception ex)
        {
            Debug.LogErrorFormat("XLua Exception: {0}\n{1}", ex.Message, ex.StackTrace);
        }
    }

   

    private void Update()
    {
        if(globalLuaEnv != null)
        {
            globalLuaEnv.Tick();
            LuaFuncUpdate();
            if(Time.realtimeSinceStartup - lastGCTime >= gcInterval)
            {
                LuaGC();
            }
        }
    }

    private void LuaGC()
    {
        lastGCTime = Time.realtimeSinceStartup;
        globalLuaEnv.FullGc();
    }

    private void LateUpdate()
    {
        if(globalLuaEnv != null)
        {
            LuaFuncLateUpdate();
        }
    }


    private byte[] LoadLuaScript(string filePath)
    {
        string rootPath = Application.streamingAssetsPath + "/LuaScripts/";
        string fileFullPath = string.Format("{0}{1}.lua", rootPath, filePath);
        if (File.Exists(fileFullPath))
        {
            return File.ReadAllBytes(fileFullPath);
        }
        return null;
    }

    private byte[] LuaLoader(ref string relativeFilePath)
    {
        relativeFilePath = relativeFilePath.Replace('.', '/');
        return LoadLuaScript(relativeFilePath);
    }



    public LuaTable RunLuaScript(string filePath)
    {
        if (!string.IsNullOrEmpty(filePath))
        {
            byte[] code = LoadLuaScript(filePath);
            LuaTable scriptEnv = globalLuaEnv.NewTable();
            LuaTable meta = globalLuaEnv.NewTable();
            meta.Set("__index", globalLuaEnv.Global);
            scriptEnv.SetMetaTable(meta);
            meta.Dispose();
            string chunkName = filePath;
            DoStringWithException(code, chunkName, scriptEnv);

            return scriptEnv;
        }

        Debug.LogErrorFormat("Load LuaScript Faild, Path: {0}", filePath);
        return null;
    }

    public T GetValue<T>(string name)
    {
        return globalLuaEnv.Global.Get<T>(name);
    }

    public void GetLuaFunc<T>(string name, out T func)
    {
        globalLuaEnv.Global.Get(name, out func);
    }

    public void InitGame()
    {
        LuaFuncInitGame();
    }

    public void OnApplicationQuit()
    {
        LuaFuncOnApplicationQuit();
    }
}
