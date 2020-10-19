using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=-=-=-=-=-=-=-=- Matriz =-=-=-=-=-=-=--=");

            #region Matriz

            //int[ , ] numeros =  new int[2,2];

            //numeros[0, 0] = 10;
            //numeros[0, 1] = 20;
            //numeros[1, 1] = 50;
            //Console.WriteLine(numeros[1, 1]);
            #endregion

            #region Matriz com valores ja declarados

            string[,] nomes = {

                { "Jhonata","Gabigol","Amendoim"},
                { "Irineu","Juca","Foda-se"}

            };

            nomes[0, 0] = "Jhow Jhow";

            Console.WriteLine(nomes[0,0]);
            Console.WriteLine(nomes[0, 1]);
            Console.WriteLine(nomes[0,2]);

            Console.WriteLine(nomes[1, 0]);
            Console.WriteLine(nomes[1,1]);
            Console.WriteLine(nomes[1, 2]);

            #endregion

            Console.ReadKey();
        }
    }
}
