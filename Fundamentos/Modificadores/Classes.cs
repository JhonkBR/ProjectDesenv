using System;
using System.Collections.Generic;
using System.Text;

namespace Modificadores
{
    class Teste
    {
        public string Nome;
        public string Sobrenome;

        public void Metodo1() 
        { 
        
        }

        public void Metodo2()
        { 
        
        }
    }

    class Humano
    {
        // Protected semelhante ao private mas define que é particular da classe e de quem HERDAR
        protected string nome;
        private string sobrenome;
        // INTERNAL DEFINE QUE A PROPRIEDADE É VALIDO SOMENTE PARA ESSA APLICAÇÃO, CASO SEU SISTEMA ESTEJA INTEGRADO COM OUTRAS COMPILAÇÕES
        internal int idade;
    }

    class Homem : Humano
    {
        public void Metodo1()
        {
            nome = "";
            idade = 1;
        }
    }


}
