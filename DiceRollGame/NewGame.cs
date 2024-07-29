class NewGame{
    private int[] userInputColection;
    public readonly int _randomNumber;
    private int tries;
    private int _gameStatus;
    public NewGame(){
        userInputColection = new int[3];
        tries = 0;
        _gameStatus = (int)gameStatus.CONTINUE;
        _randomNumber = new RandomNumber(new Random()).newNumber();
    }

    public void Play(){
        do{
            VerifyingTries();

            this.ReadInput();

        }while(this.gameResult() != 3);
    }

    public void ReadInput(){

        Console.WriteLine("Digite um número: ");
        var userInput = Console.ReadLine() ?? "";

        var newAttempt = new CheckingInput();
        newAttempt.EvaluatingInput(userInput, this);
    }

    public void VerifyingTries(){
        if(this.tries == 3){
            new Result().ResultMessage(this);
        }
    }

    public void RecordNewTrie(int newUserNumber, int result){
        userInputColection[this.tries] = newUserNumber;
        _gameStatus = result;
        this.tries++;
    }

    public int gameResult(){
        return _gameStatus;
    }

    public int Attempts(){
        return tries;
    }
}