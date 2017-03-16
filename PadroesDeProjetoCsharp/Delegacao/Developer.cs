
using System;

namespace Delegacao
{
    public  class Developer:Funcionario
    {
        public void Desenvolvendo(string tarefa)
        {
            Console.WriteLine("Developer trabalhando...");
        }
    }
}
