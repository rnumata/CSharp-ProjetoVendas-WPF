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
    /// Interaction logic for frmCadastrarProduto.xaml
    /// </summary>
    public partial class frmCadastrarProduto : UserControl
    {

        private Produto produto;

        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrarProduto_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarInput())
            {
                produto = new Produto();
                produto.Nome = txtNome.Text;
                produto.Preco = Convert.ToDouble(txtPreco.Text);
                produto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            
                if (ProdutoDAO.Cadastrar(produto))
                {
                   MessageBox.Show("Cadastro Ok", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Information);
                   LimparCampos();
                }
                else
                {
                   MessageBox.Show("produto já cadastrado", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
                }              
            }
            else
            {
                MessageBox.Show("Preencher todos os campos", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnConsultarProduto_Click(object sender, RoutedEventArgs e)
        {
            produto = ProdutoDAO.BuscarPorNome(txtNome.Text);
            if (produto != null)
            {
                btnCadastrarProduto.IsEnabled = false;
                btnRemoverProduto.IsEnabled = true;
                btnAtualizarProduto.IsEnabled = true;

                txtId.Text = produto.Id.ToString();
                txtNome.Text = produto.Nome;
                txtPreco.Text = produto.Preco.ToString();
                txtQuantidade.Text = produto.Quantidade.ToString();
                txtCriadoem.Text = produto.Criadoem.ToString();
            }
            else
            {
                MessageBox.Show("Cliente não cadastrado", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
                LimparCampos();
                btnCadastrarProduto.IsEnabled = true;
            }
        }

        private void btnRemoverProduto_Click(object sender, RoutedEventArgs e)
        {
            if (produto != null)
            {
                btnCadastrarProduto.IsEnabled = true;
                btnConsultarProduto.IsEnabled = true;
                btnRemoverProduto.IsEnabled = false;
                btnAtualizarProduto.IsEnabled = false;

                ProdutoDAO.RemoverProduto(produto);
                MessageBox.Show("Produto Removido", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparCampos();
            }
            else
            {
                btnCadastrarProduto.IsEnabled = true;
                btnConsultarProduto.IsEnabled = true;

                MessageBox.Show("Produto não foi removido", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
                LimparCampos();
            }
        }

        private void btnAtualizarProduto_Click(object sender, RoutedEventArgs e)
        {
            if (produto != null)
            {
                btnCadastrarProduto.IsEnabled = true;
                btnConsultarProduto.IsEnabled = true;
                btnRemoverProduto.IsEnabled = false;
                btnAtualizarProduto.IsEnabled = false;

                produto.Nome = txtNome.Text;
                produto.Preco = Convert.ToDouble(txtPreco.Text);
                produto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                ProdutoDAO.AtualizarProduto(produto);
                MessageBox.Show("Produto Atualizado", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Produto não foi alterado", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
                LimparCampos();
            }
        }


        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtCriadoem.Clear();
            txtNome.Focus();
        }

        private bool ValidarInput()
        {
            return !string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtQuantidade.Text) && !string.IsNullOrWhiteSpace(txtPreco.Text) ? true : false;

        }

    }
}
