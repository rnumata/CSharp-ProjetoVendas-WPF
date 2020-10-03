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
using VendasWpf.Utils;

namespace VendasWpf.Views
{
    /// <summary>
    /// Interaction logic for frmCadastrarVendedor.xaml
    /// </summary>
    public partial class frmCadastrarVendedor : UserControl
    {
        private Vendedor vendedor;

        public frmCadastrarVendedor()
        {
            InitializeComponent();
        }



        private void btnCadastrarVendedor_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarInput())
            {
                vendedor = new Vendedor();
                vendedor.Nome = txtNome.Text;
                vendedor.Cpf = txtCpf.Text.Replace("-", "").Replace(".", "").Replace(",", "");
                vendedor.Salario = Convert.ToDouble(txtSalario.Text);

                if (ValidarCpf.ValidaCpf(vendedor.Cpf))
                {
                    if (VendedorDAO.Cadastrar(vendedor))
                    {
                        MessageBox.Show("Cadastro Ok", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Information);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Vendedor já cadastrado", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("CPF Inválido", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencher todos os campos", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnConsultarVendedor_Click(object sender, RoutedEventArgs e)
        {
            vendedor = VendedorDAO.BuscarPorCpf(txtCpf.Text.Replace("-", "").Replace(".", "").Replace(",", ""));
            if (vendedor != null)
            {
                btnCadastrarVendedor.IsEnabled = false;
                btnRemoverVendedor.IsEnabled = true;
                btnAtualizarVendedor.IsEnabled = true;

                txtId.Text = vendedor.Id.ToString();
                txtNome.Text = vendedor.Nome;
                txtCpf.Text = vendedor.Cpf.ToString();
                txtSalario.Text = vendedor.Salario.ToString();
                txtCriadoem.Text = vendedor.Criadoem.ToString();
            }
            else
            {
                MessageBox.Show("Cliente não cadastrado", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
                LimparCampos();
                btnCadastrarVendedor.IsEnabled = true;
            }
        }

        private void btnRemoverVendedor_Click(object sender, RoutedEventArgs e)
        {
            if (vendedor != null)
            {
                btnCadastrarVendedor.IsEnabled = true;
                btnConsultarVendedor.IsEnabled = true;
                btnRemoverVendedor.IsEnabled = false;
                btnAtualizarVendedor.IsEnabled = false;

                VendedorDAO.RemoverVendedor(vendedor);
                MessageBox.Show("Vendedor Removido", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparCampos();
            }
            else
            {
                btnCadastrarVendedor.IsEnabled = true;
                btnConsultarVendedor.IsEnabled = true;

                MessageBox.Show("Vendedor não foi removido", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
                LimparCampos();
            }

        }

        private void btnAtualizarVendedor_Click(object sender, RoutedEventArgs e)
        {
            if (vendedor != null)
            {
                btnCadastrarVendedor.IsEnabled = true;
                btnConsultarVendedor.IsEnabled = true;
                btnRemoverVendedor.IsEnabled = false;
                btnAtualizarVendedor.IsEnabled = false;

                vendedor.Nome = txtNome.Text;
                vendedor.Cpf = txtCpf.Text.Replace("-", "").Replace(",", "").Replace(".", "");
                vendedor.Salario = Convert.ToDouble(txtSalario.Text);
                VendedorDAO.AtualizarVendedor(vendedor);
                MessageBox.Show("Vendedor Atualizado", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Vendedor não foi alterado", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
                LimparCampos();
            }
        }


        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtSalario.Clear();
            txtCriadoem.Clear();
            txtNome.Focus();
        }

        private bool ValidarInput()
        {
            return !string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtCpf.Text) && !string.IsNullOrWhiteSpace(txtSalario.Text) ? true : false;

        }


    }
}
