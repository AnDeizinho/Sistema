using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Threading.Tasks;
namespace SistemaShekinahCompleto.Views
{
    /// <summary>
    /// Interaction logic for Secretaria.xaml
    /// </summary>
    public partial class Secretaria : Page
    {
        SistemaShekinahCompleto.Views.ViewsSecretaria.ListaAlunos al;
        SistemaShekinahCompleto.Views.ViewsSecretaria.ListaClientes cli;
        public Secretaria()
        {
             al = new SistemaShekinahCompleto.Views.ViewsSecretaria.ListaAlunos();
             cli = new SistemaShekinahCompleto.Views.ViewsSecretaria.ListaClientes();
            InitializeComponent();
        }

        private void MnListaAluno_Click(object sender, RoutedEventArgs e)
        {
          
            meuFrame.Navigate(al);
                 
        }

        private void MnNovoAluno_Click(object sender, RoutedEventArgs e)
        {
            meuFrame.Navigate(new SistemaShekinahCompleto.Views.ViewsSecretaria.AtualizaAluno());
        }

        private void btnCadCliente_Click(object sender, RoutedEventArgs e)
        {
            meuFrame.Navigate(new SistemaShekinahCompleto.Views.ViewsSecretaria.CadastroDeCliente());
        }

        private void btnTurmas_Click(object sender, RoutedEventArgs e)
        {
            meuFrame.Navigate(new SistemaShekinahCompleto.Views.ViewsSecretaria.CadastrarTurmas());
        }

        private void btnListaCliente_Click(object sender, RoutedEventArgs e)
        {
            meuFrame.Navigate(cli);
        }

       

       
       
    }
}
