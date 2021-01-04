using System;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            Bicicleta b = new Bicicleta();

            c.Acelerar();
            b.Acelerar();
            c.Parar();
            b.Parar();

            Console.ReadKey();

            
        }
    }
}
