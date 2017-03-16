
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalc clac = new CalcProxy();
            var r = clac.somar(3, 5);
            Console.WriteLine(r);

            Console.ReadLine();
        }
    }
}
