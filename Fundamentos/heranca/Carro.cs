using System;
using System.Collections.Generic;
using System.Text;

namespace heranca 
{
    class Carro : Veiculo
    {
        

        public int VelocidadeMaxima { get; set; }

        public void LigarMotor() {
            Console.WriteLine("O carro ligou o motor");
        }

        public override void Acelerar()
        {//Override define que o método está sendo implementado
            Console.WriteLine("Acelerou o Carro!");
        }

        public override void Parar()
        {//Override define que o método está sendo implementado
            Console.WriteLine("Parou o carro!");
        }


    }
}
