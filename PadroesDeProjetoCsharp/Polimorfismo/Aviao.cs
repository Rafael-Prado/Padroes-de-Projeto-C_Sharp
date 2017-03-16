
using System;

namespace Polimorfismo
{
    public class Aviao: MeioTransporte
    {

        public override void Mover()
        {
            Console.WriteLine(Modelo + "  voaando...");
        }
    }
}
