

namespace Interfaces
{
    public class Documento : Arquivo, IImprimir, IEditavel
    {

        private string Descricao { get; set; }

        public Documento(string descricao)
        {
            this.Descricao = descricao;
        }


        public void Imprimir()
        {
            throw new System.NotImplementedException();
        }

        public void Editar()
        {
            throw new System.NotImplementedException();
        }
    }
}
