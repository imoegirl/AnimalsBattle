require "Mod"

gGame = nil;

function InitGame()
    gGame = Game.New();
    DoSimpleTest();
end

function Update()
    if gGame ~= nil then
        gGame:Update();
    end
end

function LateUpdate()
    if gGame ~= nil then
        gGame:LateUpdate();
    end
end

function OnApplicationQuit()
    gGame:Delete();
    gGame = nil;
end

function DoSimpleTest()
    -- print("SImple Test");
    -- gResourceManager:LoadAndCloneGameObject("12");
end