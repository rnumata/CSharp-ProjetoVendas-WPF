using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendasWpf.Models
{

    [Table("Clientes")]
    class Cliente : Pessoa
    {
        public String Email { get; set; }

       //public override string ToString()
       //{
       //   return $"{Id} | {Nome}";
       //}
    }

    


}
