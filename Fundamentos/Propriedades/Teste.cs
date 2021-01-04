using System;
using System.Collections.Generic;
using System.Text;

namespace Propriedades
{
    public class Teste
    {

        // Definição de Campo
        private string _nome;

        private string _sobrenome;

        private int _idade;

        // Definição de uma propriedade

        public string Nome { get { return _nome; } set { _nome = value; } }

        public string Sobrenome { get; set; } = "Jhonata";
        public int Idade { get { return _idade; } set { if (value < 18) { Console.WriteLine("Idade não pode ser inferior a 18 anos"); } else { _idade = value; }; } }
        public void Apresetar() {

            if (Nome!= null) {

                Console.WriteLine("Bem vindo" + Nome);
            }
        }
    }
}
