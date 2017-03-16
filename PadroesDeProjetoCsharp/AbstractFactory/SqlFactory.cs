using System;


namespace AbstractFactory
{
    public class SqlFactory:DbFactory
    {
        public override DBConnection CreatConnection()
        {
            return new SqlConnection();
        }

        public override DbCommad CreatCommad()
        {
            return new SqlCommad();
        }
    }
}
