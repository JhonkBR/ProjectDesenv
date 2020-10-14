using System;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region conversão explicita
            //ushort num
            //1 = 100;
            //byte num2 = (byte)num1;

            float numero1 = 1600f;
            int numero2 = (int)numero1;
            #endregion


            #region Parse


            string txtnumero = "1998";

            int numero = int.Parse(txtnumero);

            //Console.WriteLine(txtnumero);

            #endregion

            #region Type convert

            double num1 = Convert.ToDouble("00,5");

            Console.WriteLine(num1);


            #endregion

            Console.ReadKey();
        }
    }
}
