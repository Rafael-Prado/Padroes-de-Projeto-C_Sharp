
using System;

namespace AbstractFactory
{
    public class SqlCommad: DbCommad
    {
        public override void Execute()
        {
            Console.WriteLine("Método Execute foi chamado!!");
        }
    }
}
