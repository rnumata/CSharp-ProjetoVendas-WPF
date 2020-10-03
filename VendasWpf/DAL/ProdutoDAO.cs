using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendasWpf.Models;

namespace VendasWpf.DAL
{
    class ProdutoDAO
    {

        private static Context _context = SingletonContext.GetInstance();


        public static bool Cadastrar(Produto produto)
        {
            if (BuscarPorNome(produto.Nome) == null)
            {
                _context.Produtos.Add(produto);
                _context.SaveChanges();
                return true;
            }
            return false;
        }


        public static Produto BuscarPorNome(string nome)
        {
            return _context.Produtos.FirstOrDefault(x => x.Nome == nome);
        }


        public static void RemoverProduto(Produto produto)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }


        public static void AtualizarProduto(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }


        public static List<Produto> ListarProdutos() => _context.Produtos.ToList();

        public static Produto BuscarPorId(int id) => _context.Produtos.Find(id);

    }
}
