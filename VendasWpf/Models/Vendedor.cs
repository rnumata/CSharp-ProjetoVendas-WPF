using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Text;

namespace VendasWpf.Models
{

    [Table("Vendedores")]
     public class Vendedor : Pessoa
    {
        public double Salario { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }


        //public override string ToString()
        //{
        //    return $"{Id} | {Nome}";
        //}

    }
}
