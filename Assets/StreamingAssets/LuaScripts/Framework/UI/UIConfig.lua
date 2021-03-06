UIConfig = {}

UIEnum = {}

UILayerEnum = {
    ["Panel"] = "Panel",
    ["Popup"] = "Popup",
    ["System"] = "System"
}

UILayerCanvasOrderStart = {
    ['Panel'] = 10000,
    ['Popup'] = 40000,
    ['System'] = 50000
}

LanguageEnum = {
    ["ZH"] = 'ZH',
    ["EN"] = 'EN',
}

function UIConfig:AddUIConfig(uiPrototype, uiEnum, uiAssetPath, languageEnum, layerEnum)
    if UIConfig[languageEnum] == nil then
        UIConfig[languageEnum] = {};
    end

    UIConfig[languageEnum][uiEnum] = {
        ["uiProtoType"] = uiPrototype,
        ["uiEnum"] = uiEnum,
        ["uiAssetPath"] = uiAssetPath,
        ["languageEnum"] = languageEnum,
        ["layerEnum"] = layerEnum
    }
end