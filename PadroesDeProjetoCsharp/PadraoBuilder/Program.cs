
using System;

namespace PadraoBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            VeiculoBuilder builder;
            var director = new Director();

            builder = new CarroBuilder();
            director.Construct(builder);
            builder.Veiculo.Mostrar();



            Console.ReadLine();
        }
    }
}
