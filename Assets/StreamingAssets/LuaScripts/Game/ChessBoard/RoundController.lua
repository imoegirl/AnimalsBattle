RoundController = Class("RoundController")

function RoundController:__init()
    self.currRoundColor = ColorType.Red;
    self.myRoundColor = ColorType.red;
    self.cardList = nil;
    self.board = ChessBoard.New();
    self.boardRenderer = ChessBoardRenderer.New();

    self.pickCard = nil;    -- 当前处于操作状态的卡牌

    self.gameStarted = false;
end

function RoundController:__delete()

end

function RoundController:Init()
    if math.random() < 0.5 then
        self.currRoundColor = ColorType.Red;
    else
        self.currRoundColor = ColorType.Blue;
    end

    self.cardList = self:GenerateCardList();
    self.board:Init(self.cardList);
    self.boardRenderer:Init(self.board);

    -- 这个应该由网络消息触发
    self:StartGame();
end

-- 这个应该由网络消息触发
function RoundController:StartGame()
    StartCoroutine(
        function()
            coroutine.yield(WaitForSeconds(3));
            self.gameStarted = true;
            -- 播放游戏开始
        end
    )
end

function RoundController:OnGameStarted()
    self.gameStarted = true;
end


function RoundController:GenerateCardList()
    local uidIndex = 10000;
    local cardList = {}
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Elephant, ColorType.Red));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Lion, ColorType.Red));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Tiger, ColorType.Red));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Leopard, ColorType.Red));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Wolf, ColorType.Red));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Dog, ColorType.Red));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Cat, ColorType.Red));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Mouse, ColorType.Red));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Elephant, ColorType.Blue));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Lion, ColorType.Blue));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Tiger, ColorType.Blue));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Leopard, ColorType.Blue));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Wolf, ColorType.Blue));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Dog, ColorType.Blue));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Cat, ColorType.Blue));
    uidIndex = uidIndex + 1;
    table.insert(cardList, self:CreateNewCard(uidIndex, CardType.Mouse, ColorType.Blue));

    math.randomseed(os.time())
    local count = #cardList;
    for i = count, 2, -1 do
        local randIndex = math.random(1, i - 1);
        local tmp = cardList[i];
        cardList[i] = cardList[randIndex];
        cardList[randIndex] = tmp;
    end

    local index = 1;
    for y = 0, 3 do
        for x = 0, 3 do
            local card = cardList[index];
            index = index + 1;
            card:SetPos(y, x);
        end
    end

    return cardList;
end

function RoundController:CreateNewCard(uid, cardType, colorType)
    local card = AnimalCard.New();
    card:Init(uid, cardType, colorType);
    return card;
end

function RoundController:OnClick(worldPos)
    if not self.gameStarted then
        return;
    end

    if not self:RoundOperateValid() then
        return;
    end

    local y, x = self.boardRenderer:WorldPos2YX(worldPos);

    if self.pickCard ~= nil then
        local opResult = self.board:OperateCard(self.pickCard, y, x);
        if opResult == OperateResult.CancelOperation then
            self.pickCard = nil;
            self.boardRenderer:OnCancelPickCard();
        elseif opResult == OperateResult.MoveToNewPos then
            self.pickCard:SetPos(y, x);
            self:SwitchRound();
            self.boardRenderer:OnMoveCard(self.pickCard);
            self.pickCard = nil;
        elseif opResult == OperateResult.InvalidOperation then
            self.boardRenderer:OnInValidCardOperation(self.pickCard);
        elseif opResult == OperateResult.TargetKilled then
            local targetCard = self.board:GetCard(y, x);
            self.board:RemoveCard(y, x);
            self.boardRenderer:OnTargetKilled(self.pickCard, targetCard);
            self.pickCard = nil;
        elseif opResult == OperateResult.PerishTogether then
            local targetCard = self.board:GetCard(y, x);
            self.board:RemoveCard(y, x);
            self.board:RemoveCard(self.pickCard.y, self.pickCard.x);
            self.pickCard = nil;
            self.boardRenderer:OnOperishTogether(self.pickCard, targetCard);
        elseif opResult == OperateResult.KillFaild then
            self.boardRenderer:OnKillFaild(self.pickCard);
        end
    else
        local card = self.board:GetCard(y, x);
        if self:PickCard(card) then
            self.pickCard = card;
            self.boardRenderer:OnPickCard(self.pickCard);
        elseif self:LightingCard(card) then
            self:SwitchRound();
            self.boardRenderer:OnLightingCard(card);
        end
    end
end

function RoundController:PickCard(card)
    if self.pickCard == nil 
    and card ~= nil
    and card.cardStatus == CardStatus.Light 
    and card.colorType == self.currRoundColor 
    then return true;
    else return false;
    end
end

function RoundController:CancelPickCard(card)
    if self.pickCard ~= nil and self.pickCard == card then
        return true;
    else
        return false;
    end
end

function RoundController:LightingCard(card)
    if card ~= nil
    and self.card.cardStatus == CardStatus.Dark
    then return true;
    else return false;
    end
end


function RoundController:SwitchRound()
    if self.currRoundColor == ColorType.Red then
        self.currRoundColor = ColorType.Blue;
    else
        self.currRoundColor = ColorType.Red;
    end
end

function RoundController:RoundOperateValid()
    return true;
end