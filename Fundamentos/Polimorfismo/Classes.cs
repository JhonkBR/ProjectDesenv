using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Forma
    {
        public int X { get; private set; }

        public int Y { get; private set; }

        public int Altura { get; set; }

        public int Largura { get; set; }

        public int Raio { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("praparando-se para desenhar");
        }

        public virtual void Area()
        {
        }
    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um circulo");
        }

        public override void Area()
        {
            var area = 3.14 * (Raio * Raio);
            Console.WriteLine($"Área de circulo:{area}");
        }
    }
    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um retangulo");
        }

        public override void Area()
        {
            var area = Largura * Altura;
            Console.WriteLine($"Área de retangulo:{area}");
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Triangulo");
        }

        public override void Area()
        {
            var area = (Largura * Altura)/2;
            Console.WriteLine($"Área de Triangulo:{area}");
        }
    }
}
