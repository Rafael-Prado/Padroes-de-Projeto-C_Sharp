
namespace Adapter
{
    //transforma Adaptee em um target
    public class Adapter:Target
    {
        //compodição simples
        private Adaptee _adaptee = new Adaptee();

        //delegação simples repassando a chamada ao adaptee
        public override void Request()
        {
            //chamada de métodos com interfaces diferentes.
           _adaptee.SpecificRequest();
        }
    }
}
