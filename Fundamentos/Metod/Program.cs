using System;

namespace Metod
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Metodo com retornos
            //Console.WriteLine("Digite o nome");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Digite o sobrenome");
            //string sobrenome = Console.ReadLine();
            //Metodos metod = new Metodos();
            //Console.WriteLine(metod.MontaNome(nome, sobrenome));
            //Console.WriteLine(Convert.ToString(metod.Pi()));
            #endregion


            #region Overloading ou sobrecarga
            Console.WriteLine("Digite seu nome: ");
            var nome = Console.ReadLine();
            Metodos metod = new Metodos();
            metod.Cumprimentar();
            metod.Cumprimentar(nome);
            #endregion



            Console.ReadKey();
        }
    }
}
