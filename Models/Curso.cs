using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Pottencial_.NET.Models
{
    public class Curso
    {
        public Curso()
        {
            Alunos = new List<Pessoa>();
        }
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}"); //INTERPOLAÇÃO DE STRING
            for (int i = 0; i < Alunos.Count; i++)
            {
                string texto = "Nº " + (i + 1) + ": " + Alunos[i].NomeCompleto; //CONCATENAÇÃO DE STRING
                Console.WriteLine(texto);
            }
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public int ContarAlunos()
        {
            int quandtidade = Alunos.Count;
            return quandtidade;
        }
    }
}