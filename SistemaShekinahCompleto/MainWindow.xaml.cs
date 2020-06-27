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
using System.Windows.Media.Animation;
using SistemaShekinahCompleto.Entidades;
namespace SistemaShekinahCompleto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SistemaShekinahCompleto.Views.InicioWF inicio;
        SistemaShekinahCompleto.Views.Secretaria sec;
        bool pequeno = false;
        public MainWindow(UserEnt usuario)
        {
            inicio = new SistemaShekinahCompleto.Views.InicioWF();
            sec = new Views.Secretaria();
            InitializeComponent();
            meuFrime.Navigate(inicio);

            // Use the Loaded event to start the Storyboard.
            btnOcultar.Click += new RoutedEventHandler(faz);
            if (usuario.Tipo == Permissao.Caixa)
            {
                btnSecretaria.IsEnabled = false;
                
            }
            
        }

        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            meuFrime.Navigate(new SistemaShekinahCompleto.Views.InicioWF());
        }

        private void btnSecretaria_Click(object sender, RoutedEventArgs e)
        {
            //myFrame.Navigate(typeof(Page2), null, new EntranceNavigationTransitionInfo());
            
            meuFrime.Navigate(new SistemaShekinahCompleto.Views.Secretaria());
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

       
        private void faz(object sender, RoutedEventArgs e)
        {
            if (pequeno == false)
            {
                Coluna.Width = new GridLength(60);
                pequeno = true;
            }
            else
            {
                Coluna.Width = new GridLength(300);
                pequeno = false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            meuFrime.Navigate(new SistemaShekinahCompleto.Views.Caixa());
        }

      
    }
}
