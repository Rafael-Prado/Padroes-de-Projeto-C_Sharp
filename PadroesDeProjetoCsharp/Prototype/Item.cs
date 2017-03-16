
using Microsoft.SqlServer.Server;

namespace Prototype
{
    public abstract class Item
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public double Preco { get; set; }


        public Item( int id, string descricao, double preco)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        //clone
        public abstract Item Clone();

    }
}
