using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendasWpf.Models
{

    [Table("ItensVenda")]
    public class ItemVenda : BaseModel
    {

        public ItemVenda() => Produto = new Produto();
        
        public virtual Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

    }
}
