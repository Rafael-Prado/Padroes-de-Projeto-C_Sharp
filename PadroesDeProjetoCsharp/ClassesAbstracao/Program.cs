
using System;

namespace ClassesAbstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            var notebook = new Notebook("Acer");
            notebook.Porta1 = new IPhone();
            notebook.Porta2 = new Mouse();
            notebook.Porta3 = new Teclado();


            Console.ReadLine();
        }
    }
}
