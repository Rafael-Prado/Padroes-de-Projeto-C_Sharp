
using System;

namespace Decorator
{
    public class DataSetDecoratorConcret: DataSetDecorator
    {
        public override void Write()
        {
            Console.WriteLine("DataSet.Write() invocado!!");
            this._dataSetBase.Write();
        }

        public  void WriteXml()
        {
            Console.WriteLine("DataSet.WriteXml() invocado!!");
        }
    }
}
