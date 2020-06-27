using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SistemaShekinahCompleto.Views.ViewsSecretaria
{
    /// <summary>
    /// Interaction logic for CadastrarTurmas.xaml
    /// </summary>
    public partial class CadastrarTurmas : UserControl
    {
        public CadastrarTurmas()
        {
            InitializeComponent();
        }

        private void btnProfessor_Click(object sender, RoutedEventArgs e)
        {
            Painel.Children.Clear();
            Painel.Children.Add(new SistemaShekinahCompleto.Views.ViewsSecretaria.ViewsTurmas.Professor());
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Painel.Children.Clear();
            Painel.Children.Add(new SistemaShekinahCompleto.Views.ViewsSecretaria.ViewsTurmas.Series());
        }

        private void btnTurmas_Click(object sender, RoutedEventArgs e)
        {
            Painel.Children.Clear();
            Painel.Children.Add(new SistemaShekinahCompleto.Views.ViewsSecretaria.ViewsTurmas.MontaTurma());
        }
    }
}
