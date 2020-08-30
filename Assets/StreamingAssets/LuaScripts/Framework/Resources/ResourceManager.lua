ResourceManager = Class('ResourceManager')

function ResourceManager:__init()

end

function ResourceManager:__delete()

end


function ResourceManager:LoadAsset(resType, assetPath)
    return CS.UnityEngine.Resources.Load(assetPath);
end

function ResourceManager:LoadObject(assetPath)
    return CS.UnityEngine.Resources.Load(assetPath);
end

function ResourceManager:LoadAndCloneGameObject(assetPath)
    local rawObj = CS.UnityEngine.Resources.Load(assetPath);
    return CS.UnityEngine.GameObject.Instantiate(rawObj);
end