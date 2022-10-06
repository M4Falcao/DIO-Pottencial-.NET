// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// //Math object to aritmetical functions
// double angle = Math.Sin(Math.PI);
// Console.WriteLine(angle);

// //Convert and Parse
// string x = "312";
// int y = Convert.ToInt32(null);
// int.TryParse(x , out y);
// Console.WriteLine(y - 10);

//////////// MENU //////////////////////

string option;
bool valid = true;

while(valid){
    Console.WriteLine("Digite sua opção:");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Buscar");
    Console.WriteLine("3 - Excluir");
    Console.WriteLine("4 - Encerrar");
    option = Console.ReadLine();
    Console.Clear();

    switch(option){
        case "1":
            Console.WriteLine("Cadastro");
            break;
        case "2":
            Console.WriteLine("Busca");
            break;
        case "3":
            Console.WriteLine("Exclusão");
            break;
        case "4":
            Console.WriteLine("Encerra");
            valid = false;
            // Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}
