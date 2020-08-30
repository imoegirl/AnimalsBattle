UIConfigTable = {}

function UIConfigTable:AddUIConfig(panelEnum, uiName, uiAssetPath, languageEnum)
    if UIConfigTable[languageEnum] == nil then
        UIConfigTable[languageEnum] = {};
    end

    UIConfigTable[languageEnum][panelEnum] = {
        ["panelEnum"] = panelEnum,
        ["uiName"] = uiName,
        ["uiAssetPath"] = uiAssetPath,
        ["languageEnum"] = languageEnum
    }
end