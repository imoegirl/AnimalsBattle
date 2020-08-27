#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    
    public class SystemReflectionBindingFlagsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(System.Reflection.BindingFlags), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(System.Reflection.BindingFlags), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(System.Reflection.BindingFlags), L, null, 21, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Default", System.Reflection.BindingFlags.Default);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IgnoreCase", System.Reflection.BindingFlags.IgnoreCase);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DeclaredOnly", System.Reflection.BindingFlags.DeclaredOnly);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Instance", System.Reflection.BindingFlags.Instance);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Static", System.Reflection.BindingFlags.Static);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Public", System.Reflection.BindingFlags.Public);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NonPublic", System.Reflection.BindingFlags.NonPublic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FlattenHierarchy", System.Reflection.BindingFlags.FlattenHierarchy);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InvokeMethod", System.Reflection.BindingFlags.InvokeMethod);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CreateInstance", System.Reflection.BindingFlags.CreateInstance);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "GetField", System.Reflection.BindingFlags.GetField);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SetField", System.Reflection.BindingFlags.SetField);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "GetProperty", System.Reflection.BindingFlags.GetProperty);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SetProperty", System.Reflection.BindingFlags.SetProperty);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PutDispProperty", System.Reflection.BindingFlags.PutDispProperty);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PutRefDispProperty", System.Reflection.BindingFlags.PutRefDispProperty);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ExactBinding", System.Reflection.BindingFlags.ExactBinding);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SuppressChangeType", System.Reflection.BindingFlags.SuppressChangeType);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OptionalParamBinding", System.Reflection.BindingFlags.OptionalParamBinding);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IgnoreReturn", System.Reflection.BindingFlags.IgnoreReturn);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(System.Reflection.BindingFlags), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushSystemReflectionBindingFlags(L, (System.Reflection.BindingFlags)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Default"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.Default);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IgnoreCase"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.IgnoreCase);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DeclaredOnly"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.DeclaredOnly);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Instance"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.Instance);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Static"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.Static);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Public"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.Public);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NonPublic"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.NonPublic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FlattenHierarchy"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.FlattenHierarchy);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InvokeMethod"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.InvokeMethod);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CreateInstance"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.CreateInstance);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "GetField"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.GetField);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SetField"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.SetField);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "GetProperty"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.GetProperty);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SetProperty"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.SetProperty);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PutDispProperty"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.PutDispProperty);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PutRefDispProperty"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.PutRefDispProperty);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ExactBinding"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.ExactBinding);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SuppressChangeType"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.SuppressChangeType);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OptionalParamBinding"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.OptionalParamBinding);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IgnoreReturn"))
                {
                    translator.PushSystemReflectionBindingFlags(L, System.Reflection.BindingFlags.IgnoreReturn);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for System.Reflection.BindingFlags!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for System.Reflection.BindingFlags! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineKeyCodeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.KeyCode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.KeyCode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.KeyCode), L, null, 327, 0, 0);

            Utils.RegisterEnumType(L, typeof(UnityEngine.KeyCode));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.KeyCode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineKeyCode(L, (UnityEngine.KeyCode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(UnityEngine.KeyCode), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(UnityEngine.KeyCode) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.KeyCode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineTextAnchorWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.TextAnchor), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.TextAnchor), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.TextAnchor), L, null, 10, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperLeft", UnityEngine.TextAnchor.UpperLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperCenter", UnityEngine.TextAnchor.UpperCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperRight", UnityEngine.TextAnchor.UpperRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MiddleLeft", UnityEngine.TextAnchor.MiddleLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MiddleCenter", UnityEngine.TextAnchor.MiddleCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MiddleRight", UnityEngine.TextAnchor.MiddleRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerLeft", UnityEngine.TextAnchor.LowerLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerCenter", UnityEngine.TextAnchor.LowerCenter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerRight", UnityEngine.TextAnchor.LowerRight);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.TextAnchor), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineTextAnchor(L, (UnityEngine.TextAnchor)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "UpperLeft"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.UpperLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperCenter"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.UpperCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperRight"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.UpperRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MiddleLeft"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.MiddleLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MiddleCenter"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.MiddleCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MiddleRight"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.MiddleRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerLeft"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.LowerLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerCenter"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.LowerCenter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerRight"))
                {
                    translator.PushUnityEngineTextAnchor(L, UnityEngine.TextAnchor.LowerRight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.TextAnchor!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.TextAnchor! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasScalerScaleModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConstantPixelSize", UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPixelSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleWithScreenSize", UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConstantPhysicalSize", UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPhysicalSize);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasScalerScaleMode(L, (UnityEngine.UI.CanvasScaler.ScaleMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPixelSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPixelSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleWithScreenSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPhysicalSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPhysicalSize);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.ScaleMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.ScaleMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasScalerScreenMatchModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MatchWidthOrHeight", UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Expand", UnityEngine.UI.CanvasScaler.ScreenMatchMode.Expand);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Shrink", UnityEngine.UI.CanvasScaler.ScreenMatchMode.Shrink);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, (UnityEngine.UI.CanvasScaler.ScreenMatchMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "MatchWidthOrHeight"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Expand"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.Expand);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Shrink"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.Shrink);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.ScreenMatchMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.ScreenMatchMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIGridLayoutGroupConstraintWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Flexible", UnityEngine.UI.GridLayoutGroup.Constraint.Flexible);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FixedColumnCount", UnityEngine.UI.GridLayoutGroup.Constraint.FixedColumnCount);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FixedRowCount", UnityEngine.UI.GridLayoutGroup.Constraint.FixedRowCount);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIGridLayoutGroupConstraint(L, (UnityEngine.UI.GridLayoutGroup.Constraint)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Flexible"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.Flexible);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FixedColumnCount"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.FixedColumnCount);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FixedRowCount"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.FixedRowCount);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.GridLayoutGroup.Constraint!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.GridLayoutGroup.Constraint! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineTouchScreenKeyboardTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.TouchScreenKeyboardType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.TouchScreenKeyboardType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.TouchScreenKeyboardType), L, null, 14, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Default", UnityEngine.TouchScreenKeyboardType.Default);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ASCIICapable", UnityEngine.TouchScreenKeyboardType.ASCIICapable);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NumbersAndPunctuation", UnityEngine.TouchScreenKeyboardType.NumbersAndPunctuation);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "URL", UnityEngine.TouchScreenKeyboardType.URL);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NumberPad", UnityEngine.TouchScreenKeyboardType.NumberPad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PhonePad", UnityEngine.TouchScreenKeyboardType.PhonePad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NamePhonePad", UnityEngine.TouchScreenKeyboardType.NamePhonePad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EmailAddress", UnityEngine.TouchScreenKeyboardType.EmailAddress);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Social", UnityEngine.TouchScreenKeyboardType.Social);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Search", UnityEngine.TouchScreenKeyboardType.Search);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DecimalPad", UnityEngine.TouchScreenKeyboardType.DecimalPad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OneTimeCode", UnityEngine.TouchScreenKeyboardType.OneTimeCode);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.TouchScreenKeyboardType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineTouchScreenKeyboardType(L, (UnityEngine.TouchScreenKeyboardType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Default"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.Default);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ASCIICapable"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.ASCIICapable);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NumbersAndPunctuation"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.NumbersAndPunctuation);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "URL"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.URL);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NumberPad"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.NumberPad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PhonePad"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.PhonePad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NamePhonePad"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.NamePhonePad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EmailAddress"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.EmailAddress);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Social"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.Social);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Search"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.Search);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DecimalPad"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.DecimalPad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OneTimeCode"))
                {
                    translator.PushUnityEngineTouchScreenKeyboardType(L, UnityEngine.TouchScreenKeyboardType.OneTimeCode);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.TouchScreenKeyboardType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.TouchScreenKeyboardType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}