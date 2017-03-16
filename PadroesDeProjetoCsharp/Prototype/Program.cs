
using System;

namespace Prototype
{
    //Client
    class Program
    {
        static void Main(string[] args)
        {
            //criando objeto protótipo e um clone livro
            var p1 = new Livro(1,"design Patterns", 20.00);
            var c1 = (Livro) p1.Clone();
            Console.WriteLine("Clonado: " + c1.Descricao);

            //criando objeto protótipo e um clone dvd
            var p2 = new Dvd(1, "POO", 30.00);
            var c2 = (Dvd)p2.Clone();
            Console.WriteLine("Clonado: " + c2.Descricao);

            Console.ReadLine();


        }
    }
}
