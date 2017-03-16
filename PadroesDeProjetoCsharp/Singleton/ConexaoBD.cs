
using System;

namespace Singleton
{
    public class ConexaoBD
    {
        //guarda internamente a instância
        private static ConexaoBD _instance;
        //esconder construtor
        protected ConexaoBD()
        {
            
        }

        public static ConexaoBD Instance()
        {
            if(_instance == null)
                _instance = new ConexaoBD();

            return _instance;
        }

        public string StringConexao { get; set; }
        public void Open()
        {
            Console.WriteLine("Abrindo Conexão");
        }
    }
}
