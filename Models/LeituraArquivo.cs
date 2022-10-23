using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Pottencial_.NET.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QntLinhas) LerArquivo(string caminho)
        {

            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return (false, new String[0], 0);
            }

        }
    }
}