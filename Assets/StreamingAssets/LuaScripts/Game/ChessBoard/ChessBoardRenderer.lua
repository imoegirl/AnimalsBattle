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


function ChessBoardRenderer:OnPickCard(card)

end

function ChessBoardRenderer:OnCancelPickCard()

end

function ChessBoardRenderer:OnLightingCard(card)

end

function ChessBoardRenderer:OnMoveCard(card)

end

function ChessBoardRenderer:OnInvalidCardOperateion(card)

end

function ChessBoardRenderer:OnTargetKilled(card, targetCard)

end

function ChessBoardRenderer:OnPerishTogether(card, targetCard)

end

function ChessBoardRenderer:OnKillFaild(card)

end

function ChessBoardRenderer:WorldPos2YX(worldPos)
    return -1, -1
end

function ChessBoardRenderer:GetPositionOfYX(y, x)
    return CS.UnityEngine.Vector3.zero;
end