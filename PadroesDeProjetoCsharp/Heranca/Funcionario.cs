using System;

namespace Heranca
{
    public class Funcionario: Pessoa
    {
        
        public string Departamento;

        public void Trabalhando()
        {
            Console.WriteLine(Nome + "trabalhando....");
        }
    }
}
