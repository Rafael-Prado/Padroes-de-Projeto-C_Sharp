
using System;

namespace AbstractFactory
{
    public class SqlConnection: DBConnection
    {
        public override void Open()
        {
            Console.WriteLine("Método open foi chamado!!");
        }
    }
}
