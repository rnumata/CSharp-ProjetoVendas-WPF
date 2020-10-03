using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendasWpf.Models;

namespace VendasWpf.DAL
{
    class VendedorDAO
    {

        private static Context _context = SingletonContext.GetInstance();


        public static bool Cadastrar(Vendedor vendedor)
        {
            if (BuscarPorCpf(vendedor.Cpf) == null)
            {
                _context.Vendedores.Add(vendedor);
                _context.SaveChanges();
                return true;
            }
            return false;
        }


        public static Vendedor BuscarPorCpf(string cpf)
        {
            return _context.Vendedores.FirstOrDefault(x => x.Cpf == cpf);
        }


        public static void RemoverVendedor(Vendedor vendedor)
        {
            _context.Vendedores.Remove(vendedor);
            _context.SaveChanges();
        }


        public static void AtualizarVendedor(Vendedor vendedor)
        {
            _context.Vendedores.Update(vendedor);
            _context.SaveChanges();
        }


        public static List<Vendedor> ListarVendedores() => _context.Vendedores.ToList();

        public static Vendedor BuscarPorId(int id) => _context.Vendedores.Find(id);

    }
}
