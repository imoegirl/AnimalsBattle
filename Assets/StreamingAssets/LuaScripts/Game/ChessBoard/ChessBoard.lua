ChessBoard = Class("ChessBoard")

--[[
    3,0  3,1  3,2  3,3
    2,0  2,1  2,2  2,3
    1,0  1,1  1,2  1,3
    0,0  0,1, 0,2  0,3
]]


function ChessBoard:__init()
    self.cards = {}
end

function ChessBoard:InitData(cardList)
    for k, v in pairs(cardList) do
        
    end
end