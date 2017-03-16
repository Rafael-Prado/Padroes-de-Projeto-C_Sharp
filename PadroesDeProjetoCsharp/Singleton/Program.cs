
using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var con = ConexaoBD.Instance();
            con.StringConexao = "Sql server";
            con.Open();

            var con2 = ConexaoBD.Instance();
            con2.Open();
            // Comprovando que é mesma conexão

            if (con == con2)
                Console.WriteLine("É a mesma conexão");

            Console.ReadLine();
        }
    }
}
