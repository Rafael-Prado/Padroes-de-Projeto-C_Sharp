
using System;

namespace Adapter
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Método Request de target foi chamado!!");
        }
    }
}
