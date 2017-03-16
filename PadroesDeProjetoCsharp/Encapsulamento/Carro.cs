
using System;
using System.Reflection;

namespace Encapsulamento
{

    public class Bateria
    {
        
    }

    public class SuperBateria : Bateria
    {
        
    }



    public class Motor
    {

    }

    public class Carro
    {
        //Encapsulamento detalhes carro
        private Motor _motor;
        private SuperBateria _bateria;
        public string Nome { get; }


        //Construtor
        public Carro(string nome)
        {
            Console.WriteLine("Criando Objeto carro");
            this.Nome = nome;
            _motor = new Motor();
            _bateria = new SuperBateria();

        }

        private void Ingnicao()
        {
            Console.WriteLine("Voi dado ingnição no carro...");
        }

        public int NumeroPeneus()
        {
            return 4;
        }

        public void Ligar()
        {
         
            Console.WriteLine("Ligar veiculo.....");
            Ingnicao();
        }

        public void Mover()
        {
            Console.WriteLine("Moverveiculo.....");

        }

        public void Abastecer()
        {
            Console.WriteLine("Abastecer veiculo.....");

        }
    }
}
