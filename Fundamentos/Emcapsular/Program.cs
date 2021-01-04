using System;

namespace Emcapsular
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta c = new Conta();

            c.cliente = "Gabriel";


            Double valor = 100;
            c.Depositar(valor);


            Double valor2 = 50;
            c.sacar(valor2);


            Console.WriteLine("Cliente: " + c.cliente);
            Console.WriteLine("Saldo" + c.Saldo);
            Console.ReadKey();


        }
    }
}
