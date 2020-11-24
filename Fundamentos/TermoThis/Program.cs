using System;

namespace TermoThis
{
    class Program
    {
        static void Main(string[] args)
        {
            //O termo this faz referencia a objetos da propria classe. 

            Acessar a = new Acessar();

            if (a.Login("abc"))
            {
                Console.WriteLine("Seja Bem Vindo");
            }
            else {
                Console.WriteLine("Senha Inválida");
            }

            Console.ReadKey();
        }
    }
}
