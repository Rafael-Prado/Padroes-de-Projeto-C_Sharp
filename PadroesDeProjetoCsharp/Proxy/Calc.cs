
namespace Proxy
{
    //Subject
    public interface ICalc
    {
        int somar(int x, int y);
    }


    //RealSubject
    public class Calc : ICalc
    {
        public int somar(int x, int y)
        {
            return x + y;
        }
    }
}
