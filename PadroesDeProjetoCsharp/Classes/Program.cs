
using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            var calc = new Calculadora();
            var resultado = calc.Somar(x, y);

            Console.WriteLine("Soma de {0} com {1} é {2}" , x, y, resultado);
            Console.ReadLine();

        }
    }
}
