
using System.Collections;

namespace Flyweight
{
    public class FlyweightFactory
    {
        private Hashtable _flyweight = new Hashtable();

        public FlyweightFactory()
        {
            _flyweight.Add("A", new ConcreteFlyweight());
            _flyweight.Add("B", new ConcreteFlyweight());
            _flyweight.Add("C", new ConcreteFlyweight());
        }

        public Flyweight getFlyweight(string Key)
        {
            return (Flyweight) _flyweight[Key];
        }
    }
}
