
namespace Prototype
{
    public class Dvd: Item
    {
        public Dvd(int id, string descricao, double preco) : base(id, descricao, preco)
        {
        }

        public override Item Clone()
        {
            return (Item) this.MemberwiseClone();
        }
    }
}
