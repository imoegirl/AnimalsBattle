AnimalCard = Class("AnimalCard")

function AnimalCard:__init()

end

function AnimalCard:__delete()

end

function AnimalCard:Init(cardType)
    self.cardType = cardType;
end

function AnimalCard:SetPos(x, y)
    self.x = x;
    self.y = y;
end

function AnimalCard:SetColor(colorType)
    self.colorType = colorType;
end

function AnimalCard:TryKill(card)
    local colorCondition = self.cardType ~= card.colorType;
    local posCondition = self.x == card.x or self.y == card.y;
    if colorCondition and posCondition then
        if self.cardType == CardType.Mouse and card.cardType == CardType.Elephant then
            return KillResult.TargetKilled;
        elseif self.cardType > card.cardType then
            return KillResult.TargetKilled;
        elseif self.cardType == card.cardType then
            return KillResult.PerishTogether;
        else
            print("无效的杀戮结果，请检查逻辑");
        end
    else
        return KillResult.KillFaild;
    end
end