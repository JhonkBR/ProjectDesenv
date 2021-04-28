using System;

namespace heranca
{
    public class Humano
    {

        // Método virtual é semelhante ao abstrato porém já possui uma implementação base
        // Método sealed é lacra/tranca o método para não ser mais modificado ou seja não será mais HERDADO
        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }

        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.Cabelos");
        }

    }

    public class Pessoa : Humano 
    {
        //a assinatura Override define que é uma método que está sendo sobescrevido
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }

        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.Cabelos");
        }

    }

    public class Homem : Pessoa
    {
        //public override void Olhos()
        //{
        //    Console.WriteLine("Homem.Olhos");
        //}

        public override void Cabelos()
        {
            Console.WriteLine("Homem.Cabelos");
        }

    }
}
