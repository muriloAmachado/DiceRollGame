string userChoice;

List<string> todoList = new List<string> {};

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
            if(todoList.Count() == 0) {
                Console.WriteLine("A lista não possui um item para ser removido.");
                return;
            }
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

    var newTask = Console.ReadLine() ?? "";

    if(!taskExists(newTask, itensList)){
        itensList.Add(newTask);
        printTodoList(itensList);
        Console.WriteLine();
        Console.WriteLine("Tarefa cadastrada com sucesso.");
    }
    else{
        Console.WriteLine("Tarefa já cadastrada!!!");
    }
}

bool taskExists(string newTask, List<string> itensList){
    foreach(var task in itensList){
        if(task.ToUpper() == newTask.ToUpper()){
            return true;
        }
    }
    return false;
}

void removeTask(List<string> itensList){

    Console.WriteLine("Qual o número da tarefa que será excluída?");
    
    printTodoList(itensList);
    var userInput = Console.ReadLine();

    if(int.TryParse(userInput, out int index)){
            if(index >= itensList.Count()){
                Console.WriteLine("A lista não possui um item que corresponda ao valor informado");
            }
            else{
                itensList.RemoveAt(index);
                printTodoList(itensList);
            }
    }
    else{
        Console.WriteLine("Entrada inválida!!");
    }
}