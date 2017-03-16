using System;

namespace Bridge
{
    public class ExportacaoDoc: ExportacaoImpl
    {
        public override void Exportar()
        {
            Console.WriteLine("Exportando doc");
        }
    }
}
