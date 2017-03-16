
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
          var email = new FacadeEmail();
            email.Enviar("Ola Mundo");

            Console.ReadLine();
        }
    }
}
