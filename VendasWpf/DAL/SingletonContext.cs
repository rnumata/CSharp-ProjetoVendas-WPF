using System;
using System.Collections.Generic;
using System.Text;
using VendasWpf.Models;

namespace VendasWpf.DAL
{   

    /// <summary>
    ///  Classe que garante apenas um objeto de conexao com o BD
    /// </summary>
    class SingletonContext
    {

        private static Context _context;

        public static Context GetInstance()
        {
            if (_context == null)
            {
                _context = new Context();
            }

            return _context;
        }


    }
}
