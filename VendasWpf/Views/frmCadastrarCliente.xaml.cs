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
    /// Interaction logic for frmCadastrarCliente.xaml
    /// </summary>
    public partial class frmCadastrarCliente : UserControl
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarInput())
            {
                Cliente cliente = new Cliente();
                cliente.Nome = txtNome.Text;
                cliente.Cpf = txtCpf.Text.Replace("-", "").Replace(".", "").Replace(",","");
                cliente.Email = txtEmail.Text;

                if (ValidarCpf.ValidaCpf(cliente.Cpf))
                {
                    if (ClienteDAO.Cadastrar(cliente))
                    {
                        MessageBox.Show("Cadastro Ok", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Information);
                        LimparCampos();
                    } else
                    {
                        MessageBox.Show("Cliente já cadastrado", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                } else
                {
                    MessageBox.Show("CPF Inválido", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            } else
            {
                MessageBox.Show("Preencher todos os campos", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void btnConsultarCliente_Click(object sender, RoutedEventArgs e)
        {
                btnCadastrarCliente.IsEnabled = false;
                Cliente cliente = ClienteDAO.BuscarPorCpf(txtCpf.Text.Replace("-", "").Replace(".", "").Replace(",", ""));
                if (cliente != null)
                {
                    txtId.Text = cliente.Id.ToString();
                    txtNome.Text = cliente.Nome;
                    txtCpf.Text = cliente.Cpf.ToString();
                    txtEmail.Text = cliente.Email;
                    txtCriadoem.Text = cliente.Criadoem.ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não cadastrado", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
                    LimparCampos();
                    btnCadastrarCliente.IsEnabled = true;
                } 
        }


        private void btnRemoverCliente_Click(object sender, RoutedEventArgs e)
        {
            btnCadastrarCliente.IsEnabled = false;
            btnConsultarCliente.IsEnabled = false;
            Cliente cliente = ClienteDAO.BuscarPorCpf(txtCpf.Text.Replace("-", "").Replace(".", "").Replace(",", ""));

            if (cliente != null)
            {
                if (ClienteDAO.RemoverCliente(cliente))
                {
                    MessageBox.Show("Cliente Removido", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparCampos();
                    btnCadastrarCliente.IsEnabled = true;
                    btnConsultarCliente.IsEnabled = true;
                } else
                {
                    MessageBox.Show("Cliente não cadastrado", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
                    LimparCampos();
                }
            } else
            {
                MessageBox.Show("Informe CPF", "VendasWpf", MessageBoxButton.OK, MessageBoxImage.Error);
                LimparCampos();
                btnCadastrarCliente.IsEnabled = true;
                btnConsultarCliente.IsEnabled = true;
            }

        }


        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtCriadoem.Clear();
            txtNome.Focus();
        }

        private bool ValidarInput()
        {
            return !string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtCpf.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text) ? true : false;

        }

        

    }
}
