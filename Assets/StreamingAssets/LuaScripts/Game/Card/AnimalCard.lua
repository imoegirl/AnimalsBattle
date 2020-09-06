AnimalCard = Class("AnimalCard")

function AnimalCard:__init()

end

function AnimalCard:__delete()

end

function AnimalCard:Init(uid, cardType, colorType)
    self.uid = uid;
    self.cardType = cardType;
    self.colorType = colorType;
    self.cardStatus = CardStatus.Dark;
end

function AnimalCard:SetStatus(cardStatus)
    self.cardStatus = cardStatus;
end

function AnimalCard:DarkingCard()
    self.cardStatus = CardStatus.Dark;
end

function AnimalCard:LightingCard()
    self.cardStatus = CardStatus.Light;
end

function AnimalCard:SetPos(y, x)
    self.x = x;
    self.y = y;
end

function AnimalCard:SetColor(colorType)
    self.colorType = colorType;
end

function AnimalCard:TryKill(card)
    local colorCondition = self.cardType ~= card.colorType;
    if colorCondition then
        if self.cardType == CardType.Mouse and card.cardType == CardType.Elephant then
            return OperateResult.TargetKilled;
        elseif self.cardType > card.cardType then
            return OperateResult.TargetKilled;
        elseif self.cardType == card.cardType then
            return OperateResult.PerishTogether;
        elseif self.cardType < card.cardType then
            return OperateResult.KillFaild;
        else
            print("无效的杀戮结果，请检查逻辑");
        end
    else
        return OperateResult.InvalidOperation;
    end
end

function AnimalCard:Move(x,y)
    self.x = x;
    self.y = y;
end