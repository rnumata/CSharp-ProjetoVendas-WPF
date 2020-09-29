using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Text;

namespace VendasWpf.Models
{

    [Table("Vendedores")]
    class Vendedor : Pessoa
    {
        public double Salario { get; set; }

    }
}
