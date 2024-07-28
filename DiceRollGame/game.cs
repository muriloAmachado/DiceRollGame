var newGame = new NewGame();

Console.WriteLine("|---------------------------|");
Console.WriteLine("|---- Adivinhe o número ----|");
Console.WriteLine("|---------------------------|");

do{
    if(newGame.Attempts() == 3){
        Console.WriteLine("Suas tentativas acbaram!");
        Console.WriteLine("Você perdeu.");
        return;
    }
    
    Console.WriteLine("Digite um número: ");
    var userInput = Console.ReadLine() ?? "";
    newGame.ReadInput(userInput);

}while(!newGame.gameResult());

Console.WriteLine("PARABÉNS!!!");
Console.WriteLine("Você acertou!!!");