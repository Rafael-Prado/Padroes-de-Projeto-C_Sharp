using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    //Leaf
    public class TextBox: Componete
    {

        public TextBox(string nome) :
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
