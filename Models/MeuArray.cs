using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Pottencial_.NET.Models
{
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador;
        private T[] array = new T[capacidade];

        public void Add(T elemento)
        {
            if (contador + 1 < 11)
            {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}