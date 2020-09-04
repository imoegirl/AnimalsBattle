RoundController = Class("RoundController")

function RoundController:__init()
    self.currRoundColor = ColorType.Red;
    self.board = ChessBoard.New();
end

function RoundController:__delete()

end

function RoundController:Init()
    if math.random() < 0.5 then
        self.currRoundColor = ColorType.Red;
    else
        self.currRoundColor = ColorType.Blue;
    end

    local cardList = self:GenerateCardList()
end

function RoundController:GenerateCardList()
    local cardList = {}
    table.insert(cardList, self:CreateNewCard(CardType.Elephant, 0, 0, ColorType.Red));
    table.insert(cardList, self:CreateNewCard(CardType.Lion, 0, 1, ColorType.Red));
    table.insert(cardList, self:CreateNewCard(CardType.Tiger, 0, 2, ColorType.Red));
    table.insert(cardList, self:CreateNewCard(CardType.Leopard, 0, 3, ColorType.Red));
    table.insert(cardList, self:CreateNewCard(CardType.Wolf, 1, 0, ColorType.Red));
    table.insert(cardList, self:CreateNewCard(CardType.Dog, 1, 1, ColorType.Red));
    table.insert(cardList, self:CreateNewCard(CardType.Cat, 1, 2, ColorType.Red));
    table.insert(cardList, self:CreateNewCard(CardType.Mouse, 1, 3, ColorType.Red));

    table.insert(cardList, self:CreateNewCard(CardType.Elephant, 2, 0, ColorType.Blue));
    table.insert(cardList, self:CreateNewCard(CardType.Lion, 2, 1, ColorType.Blue));
    table.insert(cardList, self:CreateNewCard(CardType.Tiger, 2, 2, ColorType.Blue));
    table.insert(cardList, self:CreateNewCard(CardType.Leopard, 2, 3, ColorType.Blue));
    table.insert(cardList, self:CreateNewCard(CardType.Wolf, 3, 0, ColorType.Blue));
    table.insert(cardList, self:CreateNewCard(CardType.Dog, 3, 1, ColorType.Blue));
    table.insert(cardList, self:CreateNewCard(CardType.Cat, 3, 2, ColorType.Blue));
    table.insert(cardList, self:CreateNewCard(CardType.Mouse, 3, 3, ColorType.Blue));

    table.sert(cardList, function(a,b)
        -- 公平排序
    end);

    return cardList;
end

function RoundController:CreateNewCard(cardType, y, x, colorType)
    local card = AnimalCard.New();
    card:Init(cardType, y, x, colorType);
    return card;
end