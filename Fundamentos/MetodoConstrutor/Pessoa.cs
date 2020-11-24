using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoConstrutor
{
    class Pessoa
    {
        public string Nome;
        public string Sobrenome;
        public int AnoNascimento;
        int Idade;

        #region Método construtor
        // O Método construtor adiciona valores ao iniar a instancia, valores "padrão"
        public Pessoa() {

            Nome = "Desconhecido";
            Sobrenome = "Nenhum";
            AnoNascimento = 0;
            Idade = 0;
        }

        // sobrecarga de construtor
        public Pessoa(string Nome, string Sobrenome, int AnoNascimento)
        {

            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.AnoNascimento = 2002;
            Idade = idade();

        }

        public int idade() {
            return 2020 - AnoNascimento;

        }


        #endregion

    }
}
