ChessBoard = Class("ChessBoard")

--[[
    3,0  3,1  3,2  3,3
    2,0  2,1  2,2  2,3
    1,0  1,1  1,2  1,3
    0,0  0,1, 0,2  0,3
]]


function ChessBoard:__init()
    self.cards = {}
    for i = 0, 3 do
        self.cards[i] = {}
    end
end

function ChessBoard:InitData(cardList)
    for k, v in pairs(cardList) do
        local x = v.x;
        local y = v.y;
        self.cards[y][x] = v;
    end
end

function ChessBoard:GetCard(y,x)
    return self.cards[y][x];
end

function ChessBoard:OperateCard(card, y, x)
    local yDiff = math.abs(card.y - y);
    local xDiff = math.abs(card.x - x);

    if yDiff == 0 and xDiff == 0 then
        return OperateResult.CancelOperation;
    elseif (yDiff == 0 and xDiff == 1) or (xDiff == 0 and yDiff == 1) then
        local opCard = self:GetCard(y, x);
        if opCard == nil then
            -- 相邻格子没有牌，移动操作
            return OperateResult.MoveToNewPos;
        else
            return card:TryKill(opCard);
        end
    else
        -- 目标操作格子不相邻
        return OperateResult.InvalidOperation;
    end
end