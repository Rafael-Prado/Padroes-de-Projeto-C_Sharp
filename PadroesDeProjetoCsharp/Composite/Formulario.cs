
using System;
using System.Collections.Generic;

namespace Composite
{
    public class Formulario: Componete
    {
        private List<Componete>_children = new List<Componete>(); 

        public Formulario(string nome) 
            : base(nome)
        {
        }

        public override void Add(Componete c)
        {
            this._children.Add(c);
        }

        public override void Remove(Componete c)
        {
            this._children.Remove(c);
        }

        public override void Display()
        {
           Console.WriteLine(_nome);
            foreach (var c in _children)
            c.Display();
        }
    }
}
