using System;
using System.Collections.Generic;
using System.Text;

namespace heranca
{
    sealed class Bicicleta : Veiculo
    {
        public void Pedalar() {
            Console.WriteLine("Pedalando");
        }


        public override void Acelerar() {//Override define que o método está sendo implementado
            Console.WriteLine("Acelerou a bicicleta!");
        }
        public override void Parar()
        {//Override define que o método está sendo implementado
            Console.WriteLine("Parou a bicicleta!");
        }

    }
}
