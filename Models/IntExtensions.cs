using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Pottencial_.NET.Models
{
    public static class IntExtensions //TEM QUE TER O STATIC
    {
        public static bool EhPar(this int numero) //TEM QUE TER O STATIC  //THIS -> O parametro é o proprio objeto
        {
            return numero % 2 == 0;
        }
    }
}