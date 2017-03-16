using System;

namespace Decorator
{
    //Decorator
    public class DataSetDecorator: DataSetBase //Herança
    {
        protected DataSetBase _dataSetBase;

        public void SetDataBaseBase(DataSetBase dataSetBase)
        {
            this._dataSetBase = dataSetBase;
        }

        public override void Write()
        {

            Console.WriteLine("DataSet.Write() invocado!!");
            this._dataSetBase.Write();
        }

       
    }
}
