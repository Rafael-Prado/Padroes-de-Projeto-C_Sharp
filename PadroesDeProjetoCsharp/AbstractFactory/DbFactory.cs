
namespace AbstractFactory
{
    public abstract class DbFactory
    {
        public abstract DBConnection CreatConnection();
        public abstract DbCommad CreatCommad();
    }
}
