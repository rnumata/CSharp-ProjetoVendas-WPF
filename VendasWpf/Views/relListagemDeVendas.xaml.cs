using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VendasWpf.DAL;
using VendasWpf.Models;

namespace VendasWpf.Views
{
    /// <summary>
    /// Interaction logic for relListagemDeVendas.xaml
    /// </summary>
    public partial class relListagemDeVendas : UserControl
    {

        private List<dynamic> itens = new List<dynamic>();


        public relListagemDeVendas()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            foreach (ItemVenda venda in VendaDAO.ListarVendas())
            {

                dynamic item = new
                {
                    Nome = venda.Produto.Nome,
                    Preco = venda.Preco.ToString("C2"),
                    Quantidade = venda.Quantidade,
                    Data = venda.Criadoem
                };

                itens.Add(item);
            }

            dtaVendas.ItemsSource = itens;
        }
    }
}
