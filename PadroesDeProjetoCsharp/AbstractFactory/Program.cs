
using System;

namespace AbstractFactory
{

    //Cliente
    class Program
    {
        static void Main(string[] args)
        {
           
            DbFactory db = new SqlFactory();

            var con = db.CreatConnection();
            con.Open();

            var cmd = db.CreatCommad();
            cmd.Execute();

            Console.ReadLine();
        }
    }
}
