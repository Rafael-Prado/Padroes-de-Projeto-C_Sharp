
using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro Astra = new Carro("Astra GSI");
            
            Console.WriteLine(Astra.Nome + " Nome Foi Criado");
            Astra.Ligar();
            Astra.Mover();
            Astra.Abastecer();
            Astra.Mover();

            Console.ReadLine();
        }
    }
}
