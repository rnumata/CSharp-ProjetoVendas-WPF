﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VendasWpf.Models
{
    [Table("Vendas")]
    class Venda : BaseModel
    {

        public Venda()
        {
            Cliente = new Cliente();
            Vendedor = new Vendedor();
            Itens = new List<ItemVenda>();
        }

        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<ItemVenda> Itens { get; set; }

       

    }
}
