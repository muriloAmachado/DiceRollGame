
class CheckingInput{
    public bool IsValidInput(int userInput){
            if(!(userInput < 1 || userInput > 6)){
                return true;
            }
                return false;  
        }
    public string InvalidInput(string input){
        return $"'{input}' não é uma entrada válida";
    }
}