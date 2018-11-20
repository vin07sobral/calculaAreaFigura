using System;
using System.Collections.Generic;
using System.Globalization;

namespace Calculo_Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            Console.Write("Quantas figuras você ira digitar?");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Figura " + i + "Triangulo ou retangulo (t/r)");
                string ch = (Console.ReadLine());
                if (ch == "t")
                {
                    Figura f = Tela.letTriangulo();
                    lista.Add(f);
                }
                else
                {
                    Figura f = Tela.lerRetangulo();
                    lista.Add(f);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Área das figuras: ");
            for (int i=1; i<=N; i++)
            {
                Console.WriteLine("Figura " + i + ": " + lista[i].area());
            }





            Console.ReadLine();
        }
    }
}
