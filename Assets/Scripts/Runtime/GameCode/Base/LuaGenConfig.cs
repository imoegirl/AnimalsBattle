using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using XLua;

public static class LuaGenConfig
{

    [LuaCallCSharp]
    public static List<Type> LuaCallCSharpTypeList = new List<Type>()
    {
        typeof(System.Object),
        typeof(System.Reflection.BindingFlags),
        typeof(System.Type),
        typeof(UnityEngine.Object),
        typeof(Vector2),
        typeof(Vector2Int),
        typeof(Vector3),
        typeof(Vector4),
        typeof(Quaternion),
        typeof(Color),
        typeof(Ray),
        typeof(Bounds),
        typeof(Ray2D),
        typeof(KeyCode),
        typeof(Time),
        typeof(GameObject),
        typeof(Component),
        typeof(Behaviour),
        typeof(Transform),
        typeof(Animator),
        typeof(Texture2D),
        typeof(AudioClip),
        typeof(Screen),
        typeof(Camera),
        typeof(AnimationClip),
        typeof(UnityEngine.Playables.PlayableDirector),
        typeof(MonoBehaviour),
        typeof(Coroutine),
        typeof(Action<string>),
        typeof(UnityEngine.Input),

        typeof(UnityEngine.SceneManagement.SceneManager),

        typeof(System.Collections.Generic.List<int>),
        typeof(System.Collections.Generic.List<Vector2>),
        typeof(System.Collections.Generic.List<LuaTable>),

        typeof(UnityEngine.WaitForEndOfFrame),
        typeof(UnityEngine.WaitForFixedUpdate),
        typeof(UnityEngine.WaitForSeconds),
        typeof(UnityEngine.WaitForSecondsRealtime),
        typeof(UnityEngine.WaitUntil),
        typeof(UnityEngine.WaitWhile),

        typeof(UnityEngine.Canvas),
        typeof(UnityEngine.UI.Graphic),
        typeof(UnityEngine.Rect),
        typeof(UnityEngine.RectTransform),
        typeof(UnityEngine.RectOffset),
        typeof(UnityEngine.Sprite),
        typeof(UnityEngine.RenderTexture),
        typeof(UnityEngine.Mathf),
        typeof(UnityEngine.Animator),
        typeof(UnityEngine.Random),
        typeof(UnityEngine.TextAnchor),

        typeof(UnityEngine.EventSystems.UIBehaviour),
        typeof(UnityEngine.UI.MaskableGraphic),
        typeof(UnityEngine.UI.Selectable),

        typeof(UnityEngine.UI.CanvasScaler),
        typeof(UnityEngine.UI.CanvasScaler.ScaleMode),
        typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode),
        typeof(UnityEngine.UI.GraphicRaycaster),
        typeof(UnityEngine.UI.Text),
        typeof(UnityEngine.UI.InputField),
        typeof(UnityEngine.UI.Button),
        typeof(UnityEngine.UI.Image),
        typeof(UnityEngine.UI.RawImage),
        typeof(UnityEngine.UI.ScrollRect),
        typeof(UnityEngine.UI.Scrollbar),
        typeof(UnityEngine.UI.Toggle),
        typeof(UnityEngine.UI.ToggleGroup),
        typeof(UnityEngine.UI.Button.ButtonClickedEvent),
        typeof(UnityEngine.UI.ScrollRect.ScrollRectEvent),
        typeof(UnityEngine.UI.Toggle.ToggleEvent),
        typeof(UnityEngine.UI.GridLayoutGroup),
        typeof(UnityEngine.UI.ContentSizeFitter),
        typeof(UnityEngine.UI.Slider),
        typeof(UnityEngine.UI.Slider.SliderEvent),
        typeof(UnityEngine.UI.InputField),
        typeof(UnityEngine.UI.InputField.OnChangeEvent),
        typeof(UnityEngine.UI.InputField.SubmitEvent),
        typeof(UnityEngine.UI.InputField.OnValidateInput),
        typeof(UnityEngine.UI.GridLayoutGroup.Constraint),
        typeof(UnityEngine.Material),
        typeof(UnityEngine.CanvasGroup),

        typeof(UnityEngine.Events.UnityEvent),
        typeof(UnityEngine.Events.UnityEvent<bool>),
        typeof(UnityEngine.Events.UnityEvent<float>),
        typeof(UnityEngine.Events.UnityEvent<string>),
        typeof(UnityEngine.Events.UnityEvent<int>),
        typeof(System.String),

        typeof(UnityEngine.TouchScreenKeyboard),
        typeof(UnityEngine.TouchScreenKeyboardType),


        typeof(Action),
        typeof(Action<int>),

        typeof(DateTime),
        typeof(SpriteRenderer),
        typeof(TextMesh),
        typeof(AsyncOperation),
        typeof(TextAsset),
        typeof(Resources),
    };


    [CSharpCallLua]
    public static List<Type> CSharpCallLuaTypeList = new List<Type>()
    {

    };


    //黑名单
    [BlackList]
    public static List<List<string>> BlackList = new List<List<string>>()  {
        new List<string>(){"System.Xml.XmlNodeList", "ItemOf"},
                new List<string>(){"UnityEngine.WWW", "movie"},
    #if UNITY_WEBGL
       new List<string>(){"UnityEngine.WWW", "threadPriority"},
    #endif
                new List<string>(){"UnityEngine.Texture2D", "alphaIsTransparency"},
                new List<string>(){"UnityEngine.Security", "GetChainOfTrustValue"},
                new List<string>(){"UnityEngine.CanvasRenderer", "onRequestRebuild"},
                new List<string>(){"UnityEngine.Light", "areaSize"},
                new List<string>(){"UnityEngine.Light", "lightmapBakeType"},
                new List<string>(){"UnityEngine.WWW", "MovieTexture"},
                new List<string>(){"UnityEngine.WWW", "GetMovieTexture"},
                new List<string>(){"UnityEngine.AnimatorOverrideController", "PerformOverrideClipListCleanup"},
    #if !UNITY_WEBPLAYER
                new List<string>(){"UnityEngine.Application", "ExternalEval"},
    #endif
                new List<string>(){"UnityEngine.GameObject", "networkView"}, //4.6.2 not support
                new List<string>(){"UnityEngine.Component", "networkView"},  //4.6.2 not support
                new List<string>(){"System.IO.FileInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
                new List<string>(){"System.IO.FileInfo", "SetAccessControl", "System.Security.AccessControl.FileSecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
                new List<string>(){"System.IO.DirectoryInfo", "SetAccessControl", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "CreateSubdirectory", "System.String", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "Create", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"UnityEngine.MonoBehaviour", "runInEditMode"},

                new List<string>(){ "UnityEngine.UI.Graphic", "OnRebuildRequested"},
                new List<string>(){ "UnityEngine.UI.Text", "OnRebuildRequested"},
                new List<string>(){ "UnityEngine.UI.Text", "defaultTextMaterial"},
                new List<string>(){ "System.Type", "IsSZArray"},
                new List<string>(){ "UnityEngine.Input", "IsJoystickPreconfigured", "System.String" },
            };
}
