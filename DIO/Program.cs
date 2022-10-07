using DIO.Common.Models;
using System;

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

// string? option;
// bool valid = true;

// while(valid){
//     Console.WriteLine("Digite sua opção:");
//     Console.WriteLine("1 - Cadastrar");
//     Console.WriteLine("2 - Buscar");
//     Console.WriteLine("3 - Excluir");
//     Console.WriteLine("4 - Encerrar");
//     option = Console.ReadLine();
//     Console.Clear();

//     switch(option){
//         case "1":
//             Console.WriteLine("Cadastro");
//             break;
//         case "2":
//             Console.WriteLine("Busca");
//             break;
//         case "3":
//             Console.WriteLine("Exclusão");
//             break;
//         case "4":
//             Console.WriteLine("Encerra");
//             valid = false;
//             // Environment.Exit(0);
//             break;
//         default:
//             Console.WriteLine("Opção invalida");
//             break;
//     }
// }

/////////////////////////// REFERENCE /////////////////////////
//using DIO.Common.Models; tem que ser no incio do codigo

// study[] study = new study[2];

// study[0].Nome = "Mateus";
// study[1].Nome = "Luis";

// Console.WriteLine(study[0].Nome);

// study stuty = new study();
// stuty.Nome = "MAteus";
// Console.WriteLine(stuty.Nome);

/////////////////// ARRAY ///////////////////

// int[] arrayInt = new int[3];
// arrayInt[0] = 72;
// arrayInt[1] = 2;
// arrayInt[2] = 7;

// int[] arrayIntDouble = new int[arrayInt.Length * 2];
// Array.Copy(arrayInt, arrayIntDouble, arrayInt.Length);

// //Array.Resize(ref arrayInt, 5); //cria um novo array e copia os elementos antigos
// // (A referencia ao array ponteiro, nova dimensãp)

// foreach(int value in arrayIntDouble){
//     Console.WriteLine($"{value}");
// }
// for(int i = 0; i < arrayInt.Length; i++){
//     Console.WriteLine($"Posição N{i} - {arrayInt[i]}");
// }

//////////////// LISTA ////////////////////

List<string> listString = new List<string>();
listString.Add("PE");
listString.Add("BA");
listString.Add("RJ");
listString[1] = "SP";

foreach(string value in listString){
    Console.WriteLine(value);
}
