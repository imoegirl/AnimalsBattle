ChessBoardRenderer = Class("ChessBoardRenderer")

function ChessBoardRenderer:__init()
    self.cardObjList = {}
    self.pickCard = nil;
    self.camera = nil;
end

function ChessBoardRenderer:__delete()

end


function ChessBoardRenderer:Init(chessBoard)
   self.board = chessBoard; 
end

function ChessBoardRenderer:Show()

end

function ChessBoardRenderer:SetCamera()
    -- TODO: Load camera and save instance
end

function ChessBoardRenderer:SetCards()
    -- TODO: Show all cards
end

function ChessBoardRenderer:OnClick()
    -- TODO: 射线检测，看一下点到了哪个位置
    local y = 0;  -- 点到的 y 坐标
    local x = 0;  -- 点到的 x 坐标
    
    if self.pickCard ~= nil then
        -- 执行对 self.pickCard 的操作
    else
        -- 看一下 y,x 位置有没有卡，如果有的话，则 Pick 这张卡
    end
end