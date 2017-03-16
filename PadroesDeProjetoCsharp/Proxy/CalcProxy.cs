
namespace Proxy
{
    public class CalcProxy: ICalc
    {
        //RealSubject
        private Calc _calc;
        public int somar(int x, int y)
        {
            //instancia por demanda (lazy)
            if (_calc == null)
            {
                _calc = new Calc();
            }
            //repassando chamada ao RealSubject
            return _calc.somar(x, y);
        }
    }
}
