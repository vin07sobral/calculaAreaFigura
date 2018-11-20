using System;
using System.Globalization;

namespace Calculo_Figuras
{
    class Tela
    {
        public static retangulo lerRetangulo()
        {
            Console.Write("Largura :");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("altura :");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return new retangulo(largura, altura);
        }

        public static triangulo lerTraingulo()
        {
            Console.Write("Lado A :");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B :");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C :");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return new triangulo(a, b, c);
        }

    }
}