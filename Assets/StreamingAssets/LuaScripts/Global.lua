StartCoroutine = cs_coroutine.start;
StopCoroutine = cs_coroutine.stop;
-- coroutine.yield(CS.UnityEngine.WaitForSeconds(1))
WaitForSeconds = function(x) CS.UnityEngine.WaitForSeconds(x) end;
OpenUI = function (panelEnum) gUIManager.OpenUI(panelEnum) end;