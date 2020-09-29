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
    /// Interaction logic for frmCadastrarProduto.xaml
    /// </summary>
    public partial class frmCadastrarProduto : Window
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }


        private void btnSomar_Click(object sender, RoutedEventArgs e)
        {
            int n1 = Convert.ToInt32(txtNumero1.Text);  //nomedacaixadeTexto.Text para recuperar o input
            int n2 = Convert.ToInt32(txtNumero2.Text);
            int soma = n1 + n2;
            MessageBox.Show($"Soma: {soma}","Resultado",MessageBoxButton.OK,MessageBoxImage.Exclamation);
        }
    }
}
