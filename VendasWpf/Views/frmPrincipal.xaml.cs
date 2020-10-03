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
using System.Windows.Shapes;

namespace VendasWpf.Views
{
    /// <summary>
    /// Interaction logic for frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menusair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //usa-se o var para dica do tipo
            MessageBoxResult resultado = MessageBox.Show("Deseja Fechar?", "Vendas WPF", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (resultado == MessageBoxResult.No)
            {
                //cancela o evento de fechar
                e.Cancel = true;
            }
        }

        // Metodo para abrir outro formulário
        private void menuCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            SubMenu.Visibility = Visibility.Visible;
            ParentPanel.Children.Clear();
            frmCadastrarCliente pChild = new frmCadastrarCliente();
            ParentPanel.Children.Add(pChild);
        }


        private void menuCadastrarVendedor_Click(object sender, RoutedEventArgs e)
        {
            SubMenu.Visibility = Visibility.Visible;
            ParentPanel.Children.Clear();
            frmCadastrarVendedor pChild = new frmCadastrarVendedor();
            ParentPanel.Children.Add(pChild);
        }


        private void menuCadastrarProduto_Click_1(object sender, RoutedEventArgs e)
        {
            SubMenu.Visibility = Visibility.Visible;
            ParentPanel.Children.Clear();
            frmCadastrarProduto pChild = new frmCadastrarProduto();
            ParentPanel.Children.Add(pChild);
        }


        private void menuCadastrarVenda_Click(object sender, RoutedEventArgs e)
        {
            SubMenu.Visibility = Visibility.Visible;
            ParentPanel.Children.Clear();
            frmCadastrarVenda pChild = new frmCadastrarVenda();
            ParentPanel.Children.Add(pChild);
        }




        private void Close_Click(object sender, RoutedEventArgs e)
        {
            SubMenu.Visibility = Visibility.Collapsed;
            ParentPanel.Children.Clear();
            Image img = new Image
            {
                //Source = new BitmapImage(new Uri("pack://application:,,,/Images/logo.png", UriKind.RelativeOrAbsolute))
            };
            ParentPanel.Children.Add(img);
        }

        
    }
}
