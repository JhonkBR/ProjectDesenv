using System;
using System.Collections.Generic;
using System.Text;

namespace TipoDelegate
{
    class Matematica
    {
        public void Somar(int a, int b) {

            Console.WriteLine("O resultado da soma é " + (a + b));
            
        }
        public void Subtrair(int a, int b)
        {

            Console.WriteLine("O resultado da subtração é " + (a - b));

        }
        public void Divisao(int a, int b)
        {

            Console.WriteLine("O resultado da divisão é " + (a / b));

        }
    }
}
