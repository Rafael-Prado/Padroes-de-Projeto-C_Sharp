
using System;

namespace Decorator
{
    //Concrete Component
    public class DataSet: DataSetBase
    {
        public override void Write()
        {
            //salvar dados dataset.
            Console.WriteLine("DataSet.Write() invocado!!");
        }
    }
}
