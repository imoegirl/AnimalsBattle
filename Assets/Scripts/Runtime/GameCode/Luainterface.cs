using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using XLua;

[LuaCallCSharp]
public static partial class LuaInterface {
    public static Component GetComponent(this GameObject obj, UComponent uType) {
        Type sType = null;
        if(LuaGenConfig.uComponentDict.TryGetValue(uType, out sType)){
            return obj.GetComponent(sType);
        }
        return null;
    }

    public static Component GetComponent(this Component obj, UComponent uType) {
        Type sType = null;
        if(LuaGenConfig.uComponentDict.TryGetValue(uType, out sType)){
            return obj.GetComponent(sType);
        }
        return null;
    }

    public static Component GetComponentInChildren(this GameObject obj, UComponent uType) {
        Type sType = null;
        if(LuaGenConfig.uComponentDict.TryGetValue(uType, out sType)){
            return obj.GetComponentInChildren(sType);
        }
        return null;
    }
    

    public static bool IsNull(this UnityEngine.Object o){
        return o == null;
    }

    public static bool IsNotNull(this UnityEngine.Object o){
        return o != null;
    }


}