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
    /// Interaction logic for frmCadastrarVenda.xaml
    /// </summary>
    public partial class frmCadastrarVenda : UserControl
    {

        private Venda venda = new Venda();

        private double total = 0;

        //Lista de objstos dinamicos
        private List<dynamic> itens = new List<dynamic>();



        public frmCadastrarVenda()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo disparado ao carregar o formulario.
        /// </summary>
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            cboClientes.ItemsSource = ClienteDAO.Listarclientes();
            cboClientes.SelectedValuePath = "Id";
            cboClientes.DisplayMemberPath = "Nome";  //tb tem o ToString na classe

            cboVendedores.ItemsSource = VendedorDAO.ListarVendedores();
            cboVendedores.SelectedValuePath = "Id";
            cboVendedores.DisplayMemberPath = "Nome"; //tb tem o ToString na classe

            cboProdutos.ItemsSource = ProdutoDAO.ListarProdutos();
            cboProdutos.SelectedValuePath = "Id";
            cboProdutos.DisplayMemberPath = "Nome";  //tb tem o ToString na classe

        }


        private void btnAdicionarItem_Click(object sender, RoutedEventArgs e)
        {
            //Maneira de pegar o valor selecionado na ComboBox
            int pp = (int)cboProdutos.SelectedValue;
            Produto produto = ProdutoDAO.BuscarPorId(pp);
            
            PopularItensVenda(produto);
            PopularDataGrid(produto);

            dtaProdutos.ItemsSource = itens;
            dtaProdutos.Items.Refresh();

            total += Convert.ToInt32(txtQuantidade.Text) * produto.Preco;
            lblTotal.Content = $"Total: {total:C2}";
        }


        private void PopularDataGrid(Produto produto)
        {

            //Objeto dinamico que vai receber qq coisa. pode definir qq atributo (string, int, bool, objeto..). Só para abastecer o datagrid
            dynamic item = new
            {
                Nome = produto.Nome,
                Preco = produto.Preco.ToString("C2"),
                Quantidade = Convert.ToInt32(txtQuantidade.Text),
                Subtotal = (Convert.ToInt32(txtQuantidade.Text) * produto.Preco).ToString("C2")
            };

            itens.Add(item);

        }


        private void PopularItensVenda(Produto produto)
        {
            venda.Itens.Add(
                new ItemVenda
                {
                    Produto = produto,
                    Preco = produto.Preco,
                    Quantidade = Convert.ToInt32(txtQuantidade.Text)
                }
            );
        }

    }
}
