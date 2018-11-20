using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo_Figuras
{
    class retangulo : Figura
    {
        public double largura { get; set; }
        public double altura { get; set; }

        public retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public override double area()
        {
            return largura * altura;
        }

        public override double perimetro()
        {
            return 2 * (largura + altura);
        }

    }
        
}
