using UnityEngine;
using System.Collections;

public class TaleSingleton <T> : MonoBehaviour where T: TaleSingleton<T>
{
    private static T _inst = null;
    public static T Inst
    {
        get
        {
            if (_inst == null)
            {
                GameObject obj = new GameObject(typeof(T).Name);
                DontDestroyOnLoad(obj);
                _inst = obj.AddComponent<T>();
                _inst.InitOnCreate();
            }
            return _inst;
        }
    }

    protected virtual void InitOnCreate() { }

    public void InitInstance() { }
}
