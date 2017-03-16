
namespace Bridge
{
    //Abstraction
    public abstract class Exportacao
    {
        //Composição
        protected ExportacaoImpl _ExportacaoImpl;

        public ExportacaoImpl ExportacaoImpl
        {
            set { this._ExportacaoImpl = value;}
        }

        public virtual void Exportar()
        {
            //implementação por delegação
            _ExportacaoImpl.Exportar();
        }
    }

   
}
