using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendasWpf.Models;

namespace VendasWpf.DAL
{
    class VendaDAO
    {

        private static Context _context = SingletonContext.GetInstance();

        public static bool Cadastrar(Venda venda)
        {
                _context.Vendas.Add(venda);
                _context.SaveChanges();
                return true;
            
        }

        public static List<ItemVenda> ListarVendas() => _context.ItemVendas.ToList();

    }
}
