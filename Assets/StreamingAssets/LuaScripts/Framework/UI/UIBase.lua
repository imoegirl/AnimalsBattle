UIBase = Class("UIBase")

function UIBase:__init()

end

function UIBase:__delete()

end

-- Open 方法由 UIManager 调用
function UIBase:Open(id, uiEnum, csObj, data)
    self.id = id;
    self.uiEnum = uiEnum;
    self.csObj = csObj;
    self.data = data;
    
    self:OnOpen();
end

-- Close 方法由 UIManager 调用
function UIBase:Close()
    self:OnClose();
end

-- Update 方法由 UIManager 调用
function UIBase:Update()
    self:OnUpdate();
end

----- 下面的方法由子类覆写 ------

function UIBase:OnOpen()

end

function UIBase:OnClose()

end

function UIBase:OnUpdate()

end