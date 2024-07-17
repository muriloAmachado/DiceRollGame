string userChoice;

List<string> todoList = new List<string> {"Teste", "blablabla"};

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
            printTodoList(todoList);
            break;
        case "A":
            Console.WriteLine("Digite a descrição da nova tarefa:");
            addNewTask(todoList);
            break;       
        case "R":
            Console.WriteLine("Qual o número da tarefa que será excluída?");
            removeTask(todoList);
            break;
        case "S":
            Console.WriteLine("Encerrando o programa");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            Console.ReadKey();
            break;
    }
}

void printTodoList(List<string> itensList){
    foreach(var task in itensList){
        int index = itensList.IndexOf(task);
        Console.WriteLine(index + " - " + task);
    }
}

void addNewTask(List<string> itensList){
    var newTask = Console.ReadLine();

    if(!taskExists(newTask, itensList)){
        itensList.Add(newTask);
        Console.WriteLine("Tarefa cadastrada com sucesso.");
    }
    else{
        Console.WriteLine("Tarefa já cadastrada!!!");
    }
}

bool taskExists(string newTask, List<string> itensList){
    bool todoListContainsNewTask = itensList.Contains(newTask);
    return todoListContainsNewTask;
}

void removeTask(List<string> itensList){

    printTodoList(itensList);
    var userInput = Console.ReadLine();

    if(int.TryParse(userInput, out int index)){
        itensList.RemoveAt(index);
    }
    else{
        Console.WriteLine("A lista não possui um item que corresponda ao valor informado");
    }

    printTodoList(itensList);
}