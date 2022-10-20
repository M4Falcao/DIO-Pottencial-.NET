using DIO_Pottencial_.NET.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "mateus";
p1.Sobrenome = "falcao";
p1.Idade = 10;

Pessoa p2 = new Pessoa();
p2.Nome = "lucas";
p2.Sobrenome = "silva";
p2.Idade = 13;

Pessoa p3 = new Pessoa("Jose", "Adaizio");
Pessoa p4 = new Pessoa(nome: "Jose", sobrenome: "Adaizio");


Curso curso = new Curso();
curso.Nome = "Curso de ingles";
//curso.Alunos = new List<Pessoa>(); //TEM QUE INSTANCIAR A VARIAVEL
curso.AdicionarAluno(p1);
curso.AdicionarAluno(p2);
curso.AdicionarAluno(p3);
curso.AdicionarAluno(p4);

curso.ListarAlunos();



