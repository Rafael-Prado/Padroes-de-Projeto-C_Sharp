
using System;

namespace PadraoFactoryMethod
{
    //Client
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new FacebookCreator();
            creators[1] = new GoogleCriator();

            foreach (var c in creators)
            {
                Autenticacao aut = c.CreInstance();
                aut.Autenticar();
            }

            Console.ReadLine();
        }
    }
}
