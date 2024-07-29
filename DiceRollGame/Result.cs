public enum gameStatus{
    CONTINUE,
    LOSE,
    WIN,
}
class Result{
    public static int ValueCompaire(int userNumber, int systemNumber){
        if(userNumber == systemNumber){
            return 3;
        }
        return 0;
    }

    public void ResultMessage(NewGame game){
        string message = game.gameResult() == 0
            ? "VOCÊ ACERTOU!!\n PARABÉNS!!"
            : $"Suas tentativas acbaram!\n Você perdeu :(";
        Console.WriteLine(message);
    }
}