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

        //Lista de objetos dinamicos
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
            cboClientes.ItemsSource = ClienteDAO.Listarclientes();  //já preenche o combobox
            cboClientes.SelectedValuePath = "Id";                   // É o Id do objeto que será selecionado
            cboClientes.DisplayMemberPath = "Nome";                 //É a identificacao da coluna da tabela clientes e que será mostrado seu valor. Pode ser usado o Tostring tb

            cboVendedores.ItemsSource = VendedorDAO.ListarVendedores();
            cboVendedores.SelectedValuePath = "Id";                 
            cboVendedores.DisplayMemberPath = "Nome"; 

            cboProdutos.ItemsSource = ProdutoDAO.ListarProdutos();
            cboProdutos.SelectedValuePath = "Id";     
            cboProdutos.DisplayMemberPath = "Nome";  

        }


        private void btnAdicionarItem_Click(object sender, RoutedEventArgs e)
        {
                                                                    //Maneira de pegar o valor selecionado na ComboBox
            int id = (int)cboProdutos.SelectedValue;                //SelectedValue é o valor selecionado no SelectedValuePath
            Produto produto = ProdutoDAO.BuscarPorId(id);
            
            PopularItensVenda(produto);
            PopularDataGrid(produto);

            dtaProdutos.ItemsSource = itens;                        //ItemSource do datagrid é quem recebe a lista de itens dinamicos
            dtaProdutos.Items.Refresh();                            //refresh o datagrid

            total += Convert.ToInt32(txtQuantidade.Text) * produto.Preco;
            lblTotal.Content = $"Total: {total:C2}";
        }



        /// <summary>
        /// Metodo para popular o datagrid com um objeto dinamico
        /// </summary>
        /// <param name="produto"></param>
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



        /// <summary>
        ///  Esse metodo popula o List<ItemVenda> que foi declarado e instanciado na classe Venda
        /// </summary>
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

            //ItemVenda item = new ItemVenda();
            //item.Produto = produto;
            //item.Preco = produto.Preco;
            //item.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            //venda.Itens.Add(item);
        }



        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            int idCliente = (int)cboClientes.SelectedValue;
            Cliente cliente = ClienteDAO.BuscarPorId(idCliente);
            int idVendedor = (int)cboVendedores.SelectedValue;
            Vendedor vendedor = VendedorDAO.BuscarPorId(idVendedor);

            venda.Cliente = cliente;
            venda.Vendedor = vendedor;

            if (VendaDAO.Cadastrar(venda))
            {
                MessageBox.Show("Venda Cadastrada", "VendasWPF", MessageBoxButton.OK, MessageBoxImage.Information);
            } else
            {
                MessageBox.Show("Venda NAO Cadastrada", "VendasWPF", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
