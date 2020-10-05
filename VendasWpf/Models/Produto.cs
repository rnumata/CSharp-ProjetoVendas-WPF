using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendasWpf.Models
{

    [Table("Produtos")]
     public class Produto : BaseModel
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        //public override string ToString()
        //{
        //    return $"{Id} | {Nome}";
        //}
    }
}
