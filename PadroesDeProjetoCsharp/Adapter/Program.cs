
using System;

namespace Adapter
{
    //client
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();

            Console.ReadLine();
        }
    }
}
