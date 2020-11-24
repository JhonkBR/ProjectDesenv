using System;
using System.Collections.Generic;
using System.Text;

namespace Metod
{
    public class Metodos
    {

        string nomeMontado;
        public string MontaNome(string nome, string sobrenome) {


            nomeMontado = nome + " " + sobrenome;


            return nomeMontado;
        }

        public double Pi() {

            return Math.PI;
        }

        #region Overloading ou sobrecarga

        public void Cumprimentar() {

            Console.WriteLine("Seja bem vindo!");
        }


        public void Cumprimentar(string nome /*O que muda é somente a sua assinatura*/ )
        {

            Console.WriteLine("Seja bem vindo "+nome+"!");
        }


        public void Hora(string nome, int hora) {

            // Comparador ternário
            string mensagem = hora  < 12 ? "Bom dia!" + nome : "Boa tarde " +nome;

        }

        public bool Comparar(int num1, int num2) {

            bool retorno = num1 == num2 ? true : false;

            return  retorno;
        }

        public bool Comparar(string txt1, string txt2)
        {

            bool retorno = txt1 == txt2 ? true : false;

            return retorno;
        }

        #endregion
    }
}
