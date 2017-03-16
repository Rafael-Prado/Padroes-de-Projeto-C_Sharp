
namespace Prototype
{
     public class Livro: Item
    {
        //construtor
         public Livro(int id, string descricao, double preco) 
            : base(id, descricao, preco)
         {
         }

        //clone
         public override Item Clone()
         {
             return (Item) this.MemberwiseClone();
         }
    }
}
