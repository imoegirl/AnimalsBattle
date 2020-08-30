UIManager = Class('UIManager')

function UIManager:__init()
    self.languageEnum = nil;
end

function UIManager:__delete()

end

function UIManager:Init()

end

function UIManager:SetLanguageEnum(languageEnum)
    self.languageEnum = languageEnum;
end

function UIManager:OpenUI(panelEnum)
    if UIConfigTable[self.languageEnum] ~= nil then
        if UIConfigTable[self.languageEnum][panelEnum] ~= nil then
            local panelConfig = UIConfigTable[self.languageEnum][panelEnum];
            local assetPath = panelConfig.uiAssetPath;
            local panelGameObject = self:LoadUIAssetPath(assetPath);
        end
    end
end


function UIManager:LoadUIAssetPath(assetPath)

end