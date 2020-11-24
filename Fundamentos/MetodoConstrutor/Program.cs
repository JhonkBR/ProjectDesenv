using System;

namespace MetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Jhonata";

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Sobrenome);
            Console.WriteLine(p1.AnoNascimento);

            Pessoa p2 = new Pessoa("Gabriel", "Artigas", 1985);
            Console.WriteLine(p2.Nome);
            Console.WriteLine(p2.Sobrenome);
            Console.WriteLine(p2.AnoNascimento);

            Pessoa p3 = new Pessoa("Jhonata", "Cândido", 1998);
            Console.WriteLine(p3.Nome);
            Console.WriteLine(p3.Sobrenome);
            Console.WriteLine(p3.AnoNascimento);

            Console.ReadKey();
        }
    }
}
