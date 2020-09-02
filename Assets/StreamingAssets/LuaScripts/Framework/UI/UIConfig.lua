UIConfig = {}

UIEnum = {}

UILayerEnum = {
    ["Panel"] = 1,
    ["Popup"] = 2,
    ["System"] = 3
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
    if UIConfigTable[languageEnum] == nil then
        UIConfigTable[languageEnum] = {};
    end

    UIConfigTable[languageEnum][uiEnum] = {
        ["uiProtoType"] = uiPrototype,
        ["uiEnum"] = uiEnum,
        ["uiAssetPath"] = uiAssetPath,
        ["languageEnum"] = languageEnum,
        ["layerEnum"] = layerEnum
    }
end