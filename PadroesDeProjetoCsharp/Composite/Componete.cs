
namespace Composite
{
    public abstract class Componete
    {
        protected string _nome;

        public Componete(string nome )
        {
           this._nome = nome;
        }

        public abstract void Add(Componete c);
        public abstract void Remove(Componete c);
        public abstract void Display();


    }
}
