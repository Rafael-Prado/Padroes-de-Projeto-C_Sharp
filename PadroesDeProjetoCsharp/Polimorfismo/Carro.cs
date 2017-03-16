
using System;

namespace Polimorfismo
{
    public class Carro: MeioTransporte
    {
        public string Marca;

        public override void Mover()
        {
            Console.WriteLine( Modelo + "  Andando");
        }
    }
}
