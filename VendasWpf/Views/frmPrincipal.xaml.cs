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
        /// 1- Instancia o formulário a ser aberto
        /// 2- aplica o metodo ShowDialog()
        private void menuCadastrarProduto_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarProduto frm = new frmCadastrarProduto();
            frm.ShowDialog();
        }
    }
}
