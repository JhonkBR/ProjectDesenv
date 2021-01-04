using System;

namespace Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            t.Idade = 10;
            t.Nome = "Jhow Jhow";
            t.Nome = "Câmdido";
            t.Apresetar();
            Console.ReadKey();
        }
    }
}
