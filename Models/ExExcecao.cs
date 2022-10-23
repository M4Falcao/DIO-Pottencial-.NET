using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Pottencial_.NET.Models
{
    public class ExExcecao
    {
        public void Metodo1() { Metodo2(); }
        public void Metodo2() { Metodo3(); }
        public void Metodo3() { Metodo4(); }
        public void Metodo4()
        {
            string[] linhas = File.ReadAllLines("Arquivos/arquivoLseitura.txt"); //Arquivos\arquivoLeitura.txt CUIDADO COM A BARRA

            //throw new Exception("Ocorreu uma execeção"); 
        }
    }
}