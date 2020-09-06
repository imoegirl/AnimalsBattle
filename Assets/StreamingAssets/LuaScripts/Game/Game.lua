Game = Class('Game')

function Game:__init()
    print("Game inited")
    gResourceManager = ResourceManager.New();

    gUIManager = UIManager.New();
    gUIManager:SetLanguageEnum(LanguageEnum.ZH)
    
    -- 打开主界面
    -- gUIManager:OpenUI(UIEnum.UIMainPanel);
end

function Game:__delete()
    print("Game Deleted")
end

function Game:Update()
    gUIManager:Update();
    
    if CS.UnityEngine.Input.GetMouseButtonDown(0) then
        -- Physics.Raycast ...
    end
end

function Game:LateUpdate()
    
end