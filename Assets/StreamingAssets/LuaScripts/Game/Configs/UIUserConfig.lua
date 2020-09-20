UIEnum['UIGameStart'] = 'UIGameStart';
UIEnum['UIMainPanel'] = 'UIMainPanel';
UIEnum['UIPlayPanel'] = 'UIPlayPanel';

UIConfig:AddUIConfig(
    UIGameStartClass,
    UIEnum.UIGameStart,
    'UI/UIGameStart',
    LanguageEnum.ZH,
    UILayerEnum.Panel
)

UIConfig:AddUIConfig(
    UIMainPanelClass,
    UIEnum.UIMainPanel,
    'UI/UIMainPanel',
    LanguageEnum.ZH,
    UILayerEnum.Panel
)