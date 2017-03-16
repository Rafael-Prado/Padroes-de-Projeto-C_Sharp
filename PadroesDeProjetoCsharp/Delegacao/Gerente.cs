
using System;

namespace Delegacao
{
    public  class Gerente
    {
        //Delegação 
        private readonly Estagiario _estagiario;
        private readonly Developer _developer;
        private readonly Arquiteto _arquiteto;

        public Gerente()
        {
            _estagiario = new Estagiario();
            _developer = new Developer();
            _arquiteto = new Arquiteto();
        }

        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Gerente recebeu a tarefa: " + tarefa);

            _estagiario.Trabalhar(tarefa);
            _arquiteto.Projetando(tarefa);
            _developer.Desenvolvendo(tarefa);
        }

    }
}
