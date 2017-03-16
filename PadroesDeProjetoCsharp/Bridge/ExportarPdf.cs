using System;

namespace Bridge
{

    public class ExportarPdf : ExportacaoImpl
    {
        public override void Exportar()
        {
            Console.WriteLine("Exportando Pdf...");
        }
    }
}
