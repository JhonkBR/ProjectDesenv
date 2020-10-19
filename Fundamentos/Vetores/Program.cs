using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=-=-=-=-=-=- Vetores -=-=-=-=-=-=-");


            #region Vetor do tipo inteiro
            //int[] numeros = new int[5];
            //numeros[0] = 0;
            //numeros[1] =10;
            //numeros[2] = 20;
            //numeros[3] = 30;
            //numeros[4] = 40;
            //Console.WriteLine(numeros[0]);
            //Console.WriteLine(numeros[1]);
            //Console.WriteLine(numeros[2]);
            //Console.WriteLine(numeros[3]);
            //Console.WriteLine(numeros[4]);
            //Console.ReadKey();
            #endregion

            #region Vetor tipo string
            //string[] names = new string[5];
            //Names[0] = "Jhonata";
            //Names[1] = "Lucas";
            //Names[2] = "Diabrete";
            //Names[3] = "João";
            //Names[4] = "Amendoin";

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //Console.WriteLine(names[4]);

            #endregion

            #region Declarando valor do vetor na inicializacao

            string[] nome2 = {
               "Jhonata",
                "Leandro",
                "Gabriel"
            };
            Console.WriteLine(nome2[0]);
            Console.WriteLine(nome2[1]);
            Console.WriteLine(nome2[2]);
            #endregion
            Console.ReadKey();
        }
    }
}
