using DIO_Pottencial_.NET.Models;
using System.Globalization;
using Newtonsoft.Json;











///////////////////////////// STACK, HEAP E GARBAGE COLLECTOR //////////////////////////
//---------------Tipos de memoria
//tipos de valores e tipos de referencia

//stack (nome e valor) Objeto:(nome e referencia para o heap)
//heap (Tipos mais complexos)

//Pessoa p1 = new Pessoa();
//stack: {p1(ref)} ---> heap: {p1(objeto)} 

//--------------Limpeza de memória
//stack é limpa quando o metodo termina, limpa em ordem de pilha
//Garbage Collector -> limpa a memoria heap qunado não temos mais a variavel de ref













////////////////////////// TIPOS ESPECIAIS ////////////////////// 
///
//------------------- Tipos nulos
// bool? = true, false, null


// bool? desejaReceber = false;
// if (desejaReceber.HasValue)
// {
//     if (desejaReceber.Value)
//     {
//         Console.WriteLine("O usuario quer receber email");
//     }
//     else
//     {
//         Console.WriteLine("O usuario NÂO quer receber email");

//     }
// }

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<VendaDesc> listaVenda = JsonConvert.DeserializeObject<List<VendaDesc>>(conteudoArquivo);
// foreach (VendaDesc venda in listaVenda)
// {
//     Console.WriteLine($"Produto: {venda.Produto} Data: {venda.Data} DEsconto: {venda.Desconto}");
// }
//public decimal? Desconto { get; set; }



//------------------Tipo anonimo



// var tipoAnonimp = new { Nome = "Mateus", Sobrenome = "Falco", Altura = 1.80M }; //É SOMENTE LEITURA

// Console.WriteLine($"Nome: {tipoAnonimp.Nome} \nSobrenome: {tipoAnonimp.Sobrenome}");

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<VendaDesc> listaVenda = JsonConvert.DeserializeObject<List<VendaDesc>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach (var venda in listaAnonimo)
//     Console.WriteLine($"Nome: {venda.Produto} \nSobrenome: {venda.Preco}");


//------------------Tipo dinâmico

// dynamic variavelDinamica = 4;
// Console.WriteLine(variavelDinamica);

// variavelDinamica = "teste";
// Console.WriteLine(variavelDinamica);


//--------------Classes genéricas
//Uma lista que depende do tipo que passar
//tipar -> <tipo>

// MeuArray<dynamic> array = new MeuArray<dynamic>();
// array.Add(54);
// array.Add("lucas");
// array.Add(true);
// array.Add(42);
// array.Add(548);
// Console.WriteLine(array[0]);
// Console.WriteLine(array[1]);
// Console.WriteLine(array[2]);
// Console.WriteLine(array[3]);

//------------------Metodos de extensão
//adiciona comportamento para tipos

// int numero = 21;
// Console.WriteLine($"O numero {numero} é " + ((numero.EhPar()) ? "par" : "impar"));









/////////////////////////// NUGET, SERIALIZAR E ATRIBUTOS NO C# ///////////////////

//-------------------- Nuget
//Gerenciador de pacotes do .NET, tipo npm
//nuget.org

//---------------------Serialização
//Tranformar em dados para guardar
// List<Venda> vendas = new List<Venda>();

// Venda venda = new Venda(1, "Material", 342.6M, DateTime.Now);
// Venda venda2 = new Venda(2, "Material 2", 2342.6M, DateTime.Parse("27/06/1999 09:05"));

// vendas.Add(venda);
// vendas.Add(venda2);

// // for (int i = 0; i < 6; i++)
// // {
// //     vendas.Add(new Venda(i, "Material 2", 2342.6M));
// // }

// string serializado = JsonConvert.SerializeObject(vendas, Formatting.Indented);
// File.WriteAllText("Arquivos/vendas.json", serializado);



//----------------------Descerializar
// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<VendaDesc> listaVenda = JsonConvert.DeserializeObject<List<VendaDesc>>(conteudoArquivo);
// foreach (VendaDesc venda in listaVenda)
// {
//     Console.WriteLine($"Produto: {venda.Produto} Data: {venda.Data}");
// }

//---------------Atributos
//[JsonProperty("Nome_Produto")] -> Nome que vai vir no json







/////////////////// TUPLAS, OPERADORES.../////////////////////////////
//------------Tuplas

// (int id, string nome, string sobrenome) tupla = (321, "Mateus", "Falcao");
// ValueTuple<int, string, string> outraTupla = (321, "Mateus", "Falcao");
// var outraOutraTupla = Tuple.Create(321, "Mateus", "Falcao");

// var response = new LeituraArquivo().LerArquivo("Arquivos/arquivoLeitura.txt");
// var (Sucesso, Linhas, _) = new LeituraArquivo().LerArquivo("Arquivos/arquivoLeitura.txt"); // O "_" descarta uma info

//--------------Desconstrutor
//separar

// Pessoa p1 = new Pessoa("Mateus", "Falco");
// (string nome, string sobrenome) = p1;
// Console.WriteLine($"{nome} {sobrenome}");

//----------------- Operador ternario
// W ? T : F
// int numero = 20;
// Console.WriteLine($"O numero {numero} é " + ((numero % 2 == 0) ? "par" : "impar"));








//////////////////////////// EXCEÇÕES E COLEÇOES ////////////////////////////
// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt"); //Arquivos\arquivoLeitura.txt CUIDADO COM A BARRA

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex) //Exceção especifica
// {
//     Console.WriteLine($"Não achou o arquivo. {ex.Message}");
// }
// catch (Exception ex) // Exceção generica
// {
//     Console.WriteLine($"Ocorreu uma exceção generica. {ex.Message}");
// }
// finally //executa sempre
// {
//     Console.WriteLine($"Chegou até aqui");
// }
// stack trace -> a mensagem da exceção que aparece no console
// try
// {
//     new ExExcecao().Metodo1();

// }
// catch (Exception ex)
// {
//     Console.WriteLine("Ex tartada");
//     Console.WriteLine(ex.Message);
// }

//------------------Coleções
//Fila -> Queue 
//FIFO - firt in first of
// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(23);
// fila.Enqueue(26);
// fila.Enqueue(27);
// fila.Dequeue(); // --> 2


// //Pilha -> stack
// //LIFO -> last in first of
// Stack<int> pilha = new Stack<int>();
// pilha.Push(3);
// pilha.Push(34);
// pilha.Push(332);
// pilha.Push(36);
// pilha.Pop(); //-->36

// //Chave/valor -> Dictionary
// Dictionary<string, string> estados = new Dictionary<string, string>(); //TKey, TValue
// //Tkay tem que ser unico
// estados.Add("PE", "Pernambuco");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas");
// estados.Add("G", "Minas");
// estados.Remove("G");
// estados["MG"] = "Minas gerais";

// if (estados.ContainsKey("G")) Console.WriteLine("Existe");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave {item.Key}, Valor {item.Value}");
// }







/////////////////////////////// TIPOS /////////////////////////////////////////////////
//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// Pessoa p1 = new Pessoa();
// p1.Nome = "mateus";
// p1.Sobrenome = "falcao";
// p1.Idade = 10;

// Pessoa p2 = new Pessoa();
// p2.Nome = "lucas";
// p2.Sobrenome = "silva";
// p2.Idade = 13;

// Pessoa p3 = new Pessoa("Jose", "Adaizio");
// Pessoa p4 = new Pessoa(nome: "Jose", sobrenome: "Adaizio");


// Curso curso = new Curso();
// curso.Nome = "Curso de ingles";
// //curso.Alunos = new List<Pessoa>(); //TEM QUE INSTANCIAR A VARIAVEL
// curso.AdicionarAluno(p1);
// curso.AdicionarAluno(p2);
// curso.AdicionarAluno(p3);
// curso.AdicionarAluno(p4);

// curso.ListarAlunos();







//////////////////// MANIPULANDO VALORES ///////////////////////////
// decimal valor = 74338.21M;

// Console.WriteLine($"{valor:C}"); //PEGA A LOCALIZAÇÃO - BRASIL AI COLOCA REAL

// ----------------ALTERANDO LOCALIZAÇÃO DO SISTEMA
// // using System.Globalization;

// // CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// //-------------ALTERANDO A LOCALIZAÇÃO DA CULTURA

// Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

// Console.WriteLine(valor.ToString("C8")); //FORMATAÇÃO
// Console.WriteLine(valor.ToString("N8"));

// double porcentagem = .425;
// Console.WriteLine(porcentagem.ToString("P")); //PORCENTAGEM

// int num = 25234534;
// Console.WriteLine(num.ToString("##-##-##")); // PERSONALIZAR FORMATAÇÃO

//-----------------FOMATADNO DATA

// DateTime data = DateTime.Now;
// DateTime data2 = DateTime.Parse("13-02-1999");

// // Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));
// // Console.WriteLine(data.ToShortTimeString());
// // Console.WriteLine(data2);

// string dataString = "2022-04-02 18:00";
// bool sucesso = DateTime.TryParseExact(dataString,
//                         "yyyy-MM-dd HH:mm",
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None,
//                         out DateTime data3);
// if (sucesso)
// {
//     Console.WriteLine(data3);
// }
// else
// {
//     Console.WriteLine("ERROR");

// }



