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
        private void menuCadastrarProduto_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void menuCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            SubMenu.Visibility = Visibility.Visible;
            ParentPanel.Children.Clear();
            frmCadastrarCliente pChild = new frmCadastrarCliente();
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
