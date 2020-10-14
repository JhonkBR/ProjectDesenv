using System;

namespace Fundamentos
{
    class Program
    {
        enum Notas
        {
            Minimo,
            Media,
            Maxima 

        }

        struct Pessoa
        {
            public string nome;


        }
        static void Main(string[] args)
        {

            /* Variável do tipo var possui seu tipo definido a partir do primeiro recebimento e depois 
                * permanece com esse tipo até o encerramento do sistema */

            #region Tipo Objetive

            object obj = 100;
            object Obj1 = "dsad";


            #endregion

            #region Tipo enum
            Notas notasAlunos = Notas.Minimo;
            #endregion

            #region tipo Const
            /*Utilizado para definir uma variável constante ou seja a partir que foi declarado o primeiro valor não poderá mais ser alterada*/

            const string nome = "Jhonata";
            // nome = "Diego"; // O sistema não permite alterar
            #endregion

            #region Tipo Struct

            Pessoa p1 = new Pessoa();

            p1.nome = "Jhonata Cândido";

            Pessoa p2 = new Pessoa();
            p2.nome = "Rapariga";
            //Console.WriteLine(p1.nome);
            //Console.WriteLine();

            #endregion





            Console.ReadKey();

    }
    }
}