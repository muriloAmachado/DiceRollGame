
class CheckingInput{
    public static bool IsValidInput(int userNumber, NewGame game){
            if(userNumber >= 1 || userNumber <= 6){
                game.RecordNewTrie(userNumber, Result.ValueCompaire(userNumber, game._randomNumber));
                return true;
            }
                Console.WriteLine(InvalidNumberMessage(userNumber));
                return false;  
        }
    public static string InvalidInputMessage(string input){
        return $"'{input}' não é uma entrada válida.";
    }
    public void EvaluatingInput(string userInput, NewGame game){
        if(int.TryParse(userInput, out int number)){
            IsValidInput(number, game);
        }
        else{
            Console.WriteLine(InvalidInputMessage(userInput));
        }
    }
    public static string InvalidNumberMessage(int input){
        return $"'{input}' não é um número válido.";
    }
}

    