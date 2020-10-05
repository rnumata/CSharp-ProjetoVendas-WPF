using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VendasWpf.Models
{
    class Context : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemVenda> ItemVendas { get; set; }
        public DbSet<Venda> Vendas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb;Database=VendasWPF;Trusted_Connection=true").UseLazyLoadingProxies();
        }

    }
}
