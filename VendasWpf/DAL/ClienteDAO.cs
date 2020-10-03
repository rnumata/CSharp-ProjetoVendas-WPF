using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendasWpf.Models;

namespace VendasWpf.DAL
{
    class ClienteDAO
    {

        private static Context _context = SingletonContext.GetInstance();


        public static bool Cadastrar(Cliente cliente)
        {
            if (BuscarPorCpf(cliente.Cpf) == null)
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return true;
            }
            return false;
        }


        public static Cliente BuscarPorCpf(string cpf)
        {
            return _context.Clientes.FirstOrDefault(x => x.Cpf == cpf);
        }


        public static void RemoverCliente(Cliente cliente)
        {
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();        
        }


        public static void AtualizarCliente(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }


        public static List<Cliente> Listarclientes() => _context.Clientes.ToList();

        public static Cliente BuscarPorId(int id) => _context.Clientes.Find(id);

    }
}
