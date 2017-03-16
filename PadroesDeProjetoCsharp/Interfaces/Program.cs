
using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var documento = new Documento("Documento Bolo");
            documento.Editar();
            documento.Imprimir();


            Console.ReadLine();
        }
    }
}
