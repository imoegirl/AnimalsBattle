UIManager = Class('UIManager')

function UIManager:__init()
    self.languageEnum = nil;
    self.UIIDIndex = 10000;

    -- {id:ui, id: ui ...}
    self.openedUIWithIdDict = {}

    -- {[panelEnum] = {panel1, panel2, panel3}, [panelEnum] = {}...}
    self.openedUIWithEnumDict = {}

    self.layerParentDict = {}

    self.readyOnLoadPanelDict = {}

    self:CreateUIRoot();
end

function UIManager:__delete()

end

-- 每个 UI 面板，都是一个独立的 Canvas
function UIManager:CreateUIRoot()
    self.uiRootObj = CS.UnityEngine.GameObject("UIRoot");
    for k, v in pairs(UILayerEnum) do
        local layerName = k;
        local layerObj = CS.UnityEngine.GameObject(layerName);
        layerObj.transform:SetParent(self.uiRootObj.transform);
    end
end


function UIManager:SetLanguageEnum(languageEnum)
    self.languageEnum = languageEnum;
end

function UIManager:OpenUI(uiEnum, data)
    if UIConfig[self.languageEnum] ~= nil then
        if UIConfig[self.languageEnum][uiEnum] ~= nil then
            local uiConfig = UIConfig[self.languageEnum][uiEnum];
            local assetPath = uiConfig.uiAssetPath;
            local panelGameObject = self:LoadUIAssetPath(assetPath);
            local uiLayerEnum = UIConfig[self.languageEnum][uiEnum].layerEnum;
            local uiParent = self.layerParentDict[uiLayerEnum];
            panelGameObject.transform:SetParent(uiParent);
            local canvas = panelGameObject:GetComponent();
            canvas.sortingOrder = UILayerCanvasOrderStart[uiLayerEnum];
            UILayerCanvasOrderStart[uiLayerEnum] = canvas.sortingOrder + 1;

            local uiObj = uiConfig.uiProtoType.New();
            local id = self.UIIDIndex;
            self.UIIDIndex = self.UIIDIndex + 1;

            self.openedUIWithIdDict[id] = uiObj;
            if self.openedUIWithEnumDict[uiEnum] == nil then
                self.openedUIWithEnumDict[uiEnum] = {};
            end
            self.openedUIWithEnumDict[uiEnum][id] = uiObj;

            self.readyOnLoadPanelDict[id] = uiObj;

            uiObj:Open(id, uiEnum, panelGameObject, data);
        end
    end
end

function UIManager:CloseUI(uiObj)
    local id = uiObj.id;
    local uiEnum = uiObj.uiEnum;
    self.openedUIWithIdDict[id] = nil;
    if self.openedUIWithEnumDict[uiEnum] ~= nil and self.openedUIWithEnumDict[uiEnum][id] ~= nil then
        self.openedUIWithEnumDict[uiEnum][id] = nil;
    end
    uiObj:Close();
    uiObj:Delete();
    uiObj = nil;
end

function UIManager:CloseUIOfEnum(uiEnum)
    if self.openedUIWithEnumDict[uiEnum] ~= nil then
        for k, v in pairs(self.openedUIWithEnumDict[uiEnum]) do
            self:CloseUI(v);
            if self.readyOnLoadPanelDict[k] ~= nil then
                self.readyOnLoadPanelDict[k] = nil;
            end
        end
    end
end

function UIManager:CloseAllUI()
    for k, v in pairs(self.openedUIWithIdDict) do
        self:CloseUI(v);
    end
end

function UIManager:Update()
    for k, v in pairs(self.openedUIWithIdDict) do
        if self.readyOnLoadPanelDict[k] == nil then
            v:Update();
        end
    end

    for k, v in pairs(self.readyOnLoadPanelDict) do
        v:Start();
        self.readyOnLoadPanelDict[k] = nil;
    end
end

function UIManager:LoadUIAssetPath(assetPath)

end