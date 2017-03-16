using System;
using System.Collections.Generic;

namespace PadraoBuilder
{
    //Produto
    public class Veiculo
    {
        private string _tipo;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        //construtor
        public Veiculo(string tipo)
        {
            this._tipo = tipo;
        }

        public string this[string Key]
        {
            get { return _parts[Key]; }
            set { _parts[Key] = value; }
        }

        public void Mostrar()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Tipo: {0}", _tipo);
            Console.WriteLine("Motor: {0}", _parts["motor"]);
            Console.WriteLine("Pneu: {0}", _parts["pneus"]);
            Console.WriteLine("Porta: {0}", _parts["portas"]);

        }
    }
}
