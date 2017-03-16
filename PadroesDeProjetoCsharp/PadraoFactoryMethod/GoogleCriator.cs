
namespace PadraoFactoryMethod
{
    //concrete creator
    public class GoogleCriator: Creator
    {
        public override Autenticacao CreInstance()
        {
            return new AutenticacaoGoogle();
        }
    }
}
