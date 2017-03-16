
using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            MeioTransporte carro = new Carro();
            carro.Modelo = "Astra";
            carro.Mover();

            MeioTransporte aviao = new Aviao();
            aviao.Modelo = "F22";
            aviao.Mover();

            Console.ReadLine();

        }
    }
}
