﻿using System;
using System.Collections.Generic;
using System.Text;

namespace heranca
{
    abstract class Veiculo
    {

        public string Cor { get; set; }
        public string Marca { get; set; }

        public abstract void Acelerar();

        public abstract void Parar();
    }
}
