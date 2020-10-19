using System;

namespace MultiplicacaoDeVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=-=-=-=-=-=  Multiplicação de vetores -=-=-=-=-=-=-");

            #region Declarando matrizes 
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] matriz3 = new int[2, 2];

            #endregion

            Console.WriteLine("Preencher a Matriz 1: ");
            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {

                    Console.Write("#1. Posição: [" + linha + "," + coluna + "]");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());
                }

            }


            Console.WriteLine("\nPreencher a Matriz 2: ");
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {

                    Console.Write("#1. Posição: [" + linha + "," + coluna + "]");
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine("=-=-=-=-=-=-=-=- Resultado da Matriz 1 X Matriz 2 -=-=-=-=-=-=-=--=");
            Console.WriteLine("Matriz: ");
            matriz3[0, 0] = 
                (matriz1[0, 0] * matriz2[0, 0])
                + (matriz1[0, 1] * matriz2[1, 0])
                + (matriz1[1, 2] * matriz2[2, 0]
                
                );
            matriz3[1, 0] =
               (matriz1[1, 0] * matriz2[0, 0])
               + (matriz1[1, 1] * matriz2[1, 0])
               + (matriz1[1, 2] * matriz2[2, 0]

               );

            matriz3[0, 1] =
               (matriz1[0, 0] * matriz2[0, 1])
               + (matriz1[1, 1] * matriz2[1, 1])
               + (matriz1[1, 2] * matriz2[2, 1]

               );

            matriz3[1, 1] =
               (matriz1[1, 0] * matriz2[0, 1])
               + (matriz1[1, 1] * matriz2[1, 1])
               + (matriz1[1, 2] * matriz2[2, 1]

               );


            Console.WriteLine("["+matriz3[0,0]+"]["+matriz3[0,1]+"]");
            Console.WriteLine("[" + matriz3[1,0] + "][" + matriz3[1, 1] + "]");
            Console.ReadKey();
        }
    }
}
