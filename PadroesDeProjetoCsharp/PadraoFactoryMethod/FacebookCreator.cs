
namespace PadraoFactoryMethod
{
    public class FacebookCreator: Creator
   {
        public override Autenticacao CreInstance()
        {
            return new AutenticacaoFacebook();
        }
    }
}
