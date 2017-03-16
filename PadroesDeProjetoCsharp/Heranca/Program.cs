
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var aluno = new Aluno();

            aluno.Matricula = 123;
            aluno.Nome = "Rafael";
            aluno.Estudar();
            aluno.Dormir();
            
            var funcionario = new Funcionario();

            funcionario.Nome = "Pedro";
            funcionario.Departamento = "Desenvolvimento";
            funcionario.Trabalhando();
            Console.ReadLine();
        }
    }
}
