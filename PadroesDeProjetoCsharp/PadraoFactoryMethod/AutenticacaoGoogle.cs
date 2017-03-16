
using System;

namespace PadraoFactoryMethod
{
    //Product Concreto
    public class AutenticacaoGoogle: Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Autenticado via Google!!!");
        }
    }
}
