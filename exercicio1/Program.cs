string userChoice;

do{
Console.WriteLine("Escolha a opção:");

Console.WriteLine();
Console.WriteLine("[V]izualisar as tarefas");
Console.WriteLine("[A]dicionar tarefa");
Console.WriteLine("[R]emover tarefa");
Console.WriteLine("[S]air");

var userInput = Console.ReadLine();

userChoice = userInput.ToUpper();

selectionMenu(userChoice);

}while(userChoice != "S");

void selectionMenu(string option){

    switch(option){
        case "V":
            break;
        case "A":
            break;       
        case "R":
            break;
        case "S":
            Console.WriteLine("Encerrando o programa");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

}

Console.ReadKey();