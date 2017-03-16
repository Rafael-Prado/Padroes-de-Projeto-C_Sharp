
using System;

namespace Delegacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerente = new Gerente();
            gerente.Trabalhar("Sistema de atendimento ao usuário");

            Console.ReadLine();


        }
    }
}
