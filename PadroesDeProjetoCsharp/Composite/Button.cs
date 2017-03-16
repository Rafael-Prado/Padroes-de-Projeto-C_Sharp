using System;

namespace Composite
{
    public class Button: Componete
    {
        public Button(string nome) :
            base(nome)
        {
        }
        public override void Add(Componete c)
        {
            Console.WriteLine("Não é possivel adicionar este componete");
        }

        public override void Remove(Componete c)
        {
            Console.WriteLine("Não é possivel Remove este componete");
        
        }

        public override void Display()
        {
            Console.WriteLine(_nome);
        }

       
    }
}
