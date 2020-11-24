using System;

namespace TipoDelegate
{
    class Program
    {

        //O Delegate e criado na raiz da classe.

        delegate void Conta(int a, int b);

        static void Main(string[] args)
        {

            Matematica m = new Matematica();
            Conta c  = null; // Não precisa instanciar*****

            c += m.Somar;
            c += m.Subtrair;
            c += m.Divisao;

            // Você adiciona os métodos no delegate a qual no  final ele executa porém somente se possuir o mesmo retorno.
            c(5, 5);

            Console.ReadKey();
        }
    }
}
