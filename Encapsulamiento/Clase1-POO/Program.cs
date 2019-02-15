using System;

namespace Clase1_POO
{
    class Program
    {
        //static int valor = 67;
        //public static void CalcularMetros()
        //{

        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            FiguraGeometrica Cuadrado = new FiguraGeometrica();
            Cuadrado.Id = 1;
            Console.WriteLine(Cuadrado.Id);
            Console.ReadKey();
            FiguraGeometrica Rectangulo = new FiguraGeometrica();

        }
    }
}
