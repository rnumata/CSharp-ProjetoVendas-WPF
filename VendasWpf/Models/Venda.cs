using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendasWpf.Models
{
    [Table("Vendas")]
    public class Venda : BaseModel
    {

        public Venda()
        {
            Cliente = new Cliente();
            Vendedor = new Vendedor();
            Itens = new List<ItemVenda>();
        }

        public virtual Cliente Cliente { get; set; }

        public virtual Vendedor Vendedor { get; set; }

        public virtual List<ItemVenda> Itens { get; set; }

       

    }
}
