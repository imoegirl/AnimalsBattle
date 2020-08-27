using UnityEngine;
using System.Collections;

public class GameStarter : MonoBehaviour
{
    private void Start()
    {
        LuaDriver.Inst.InitGame();
    }
}
