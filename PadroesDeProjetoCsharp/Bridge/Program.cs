
using System;

namespace Bridge
{
    class Program
    {
        //Client
        static void Main(string[] args)
        {
            var expor = new ExportacaoEx();
            //Injetando o objeto implementação
            expor.ExportacaoImpl = new ExportacaoDoc();
            expor.Exportar();

            Console.ReadLine();
        }
    }
}
