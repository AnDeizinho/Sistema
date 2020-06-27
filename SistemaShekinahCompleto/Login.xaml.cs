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
using System.Windows.Shapes;
using SistemaShekinahCompleto.Entidades;
namespace SistemaShekinahCompleto
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        UserEnt user ;
       
        public Login()
        {
            user = new UserEnt();
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                user.setSenha(txtsenha.Password);
                MainWindow MN = new MainWindow(user);
                this.Close();
                MN.Show();
                this.Visibility = System.Windows.Visibility.Hidden;
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }

        private void txtuser_LostFocus(object sender, RoutedEventArgs e)
        {
           
            try
            {
                user.setUsuario(txtuser.Text);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                txtuser.Clear();
            }
        }

        
    }
}
