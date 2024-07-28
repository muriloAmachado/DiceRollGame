class NewGame{
    private int[] userInputColection;
    private readonly int _randomNumber;
    private int attempts; 
    private bool endGame;
    public NewGame(){
        userInputColection = new int[3];
        attempts = 0;
        endGame = false;
        _randomNumber = new RandomNumber(new Random()).newNumber();
    }
    public void ReadInput(string userInput){
        var newAttempt = new CheckingInput();

        if(int.TryParse(userInput, out int number)){
            if(newAttempt.IsValidInput(number)){
                this.RecordNewAttempt(number, attempts, new Result().valueCompaire(number, _randomNumber));
            }
            else Console.WriteLine(newAttempt.InvalidInput(userInput));
        }
        else{
            Console.WriteLine(newAttempt.InvalidInput(userInput));
        }
    }
    public void RecordNewAttempt(int newUserNumber, int attempts, bool result){
        userInputColection[attempts] = newUserNumber;
        endGame = result;
        this.attempts++;
    }

    public bool gameResult(){
        return endGame;
    }

    public int Attempts(){
        return attempts;
    }
}