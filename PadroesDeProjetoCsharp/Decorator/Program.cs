using System;

namespace Decorator
{
    class Program
    {
        //Client
        static void Main(string[] args)
        {
            //Criar ConcreteComponent

            DataSet c = new DataSet();

            //Cria decoratorConcret
            DataSetDecoratorConcret d = new DataSetDecoratorConcret();
            
            //setando objeto a ser decorado (injetando uma implemetação)
            d.SetDataBaseBase(c);
            //Chamando método da abstraçã
            d.Write();

            //chamando método injetado pelo decorator
            d.WriteXml();

            Console.ReadLine();
        }
    }
}
