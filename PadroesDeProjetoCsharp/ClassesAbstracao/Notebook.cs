
namespace ClassesAbstracao
{
    public class Notebook
    {
        private string _nome;

        public string GetNome()
        {
            return _nome;
        }
        public Notebook(string nome)
        {
            this._nome = nome;
        }

        //Relação de associação.

        public USB Porta1 { get; set; }
        public USB Porta2 { get; set; }
        public USB Porta3 { get; set; }


    }
}
