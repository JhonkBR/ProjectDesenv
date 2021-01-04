using System;
using System.Collections.Generic;
using System.Text;

namespace Emcapsular
{
    class Conta
    {

        private string _cliente;
        private Double _saldo;
        private double _taxa = 10;

        public string cliente {
            get { return _cliente; }
            set {
                if (value != "Gabriel" && value != "Logan")
                {
                    _cliente = "Visitante";
                    _saldo = 0;
                }
                else {

                    _cliente = value;
                    _saldo = 100;
                }
            }
        }

        public double Saldo { get { return _saldo; } private set { _saldo = value; } }



        public void sacar(double valor) {
            valor += _taxa;
            _saldo -= valor;
        }

        public void Depositar(double valor)
        {

            _saldo += valor;
        }

    }
}
