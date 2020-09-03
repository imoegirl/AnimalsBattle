using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class XLuaGenEditor
{

    public static string genPath = Application.dataPath + "/Scripts/Runtime/XLuaGeneratedCode/";

    [MenuItem("XLua/Tale Clear And Gen Lua")]
    public static void GenerateXLuaCode()
    {
        CSObjectWrapEditor.GeneratorConfig.common_path = genPath;
        Directory.Delete(genPath, true); 
        CSObjectWrapEditor.Generator.GenAll();
    }

    [MenuItem("XLua/Reload Debug File")]
    public static void ReloadDebugFile() {
        LuaDriver.Inst.DynamicReloadDebugLuaFile();
    }

}
