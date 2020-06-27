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
using SistemaShekinahCompleto.Entidades;
using SistemaShekinahCompleto.DAO;
namespace SistemaShekinahCompleto.Views.ViewsSecretaria
{
    /// <summary>
    /// Interaction logic for CadastroDeCliente.xaml
    /// </summary>
    public enum Modo { NovoCliente, AlterarCadastro }
    public partial class CadastroDeCliente : Page
    {
        ClienteEnt Cliente;
        Modo mod;
        public CadastroDeCliente(ClienteEnt cli)
        {
            mod = Modo.AlterarCadastro;
            Cliente = cli;
            InitializeComponent();
            txtCC.Text = Cliente.id_cliente.ToString();
            txtpai.Text = Cliente.pai;
            txtmae.Text = Cliente.mae;
            txtfonepai.Text = Cliente.fone_pai;
            txtfonemae.Text = Cliente.fone_mae;
            txtcpfpai.Text = Cliente.cpf_pai;
            txtcpfmae.Text = Cliente.cpf_mae;
            txtendereco.Text = Cliente.endereco;
            txtnumero.Text = Cliente.numero.ToString();
            txtbairro.Text = Cliente.bairro;
            txtcomplemento.Text = Cliente.complemento;
            txtcidade.Text = Cliente.cidade;
            txtEstado.Text = Cliente.estado;
            txtcep.Text = Cliente.cep;
            txtfilhos.Text = Cliente.filhos.ToString();
            txtrg.Text = Cliente.RG;
        }
        public CadastroDeCliente()
        {
            mod = Modo.NovoCliente;
            Cliente = new ClienteEnt();
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, RoutedEventArgs e)
        {
            switch (mod)
            {
                case Modo.NovoCliente:
                    ClienteDAO dao = new ClienteDAO();
                    MessageBox.Show(dao.Cadastrar(Cliente));
                    txtCC.Text = Cliente.id_cliente.ToString();
                    mod = Modo.AlterarCadastro;
                    break;
                case Modo.AlterarCadastro:
                    ClienteDAO dao2 = new ClienteDAO();
                    MessageBox.Show(dao2.Alterar(Cliente));
                    break;
            }
   
        }

        private void limpaTudo()
        {
            throw new NotImplementedException();
        }

        private void txtpai_LostFocus(object sender, RoutedEventArgs e)
        {
            Cliente.pai = txtpai.Text;
        }

        private void txtmae_LostFocus(object sender, RoutedEventArgs e)
        {
            Cliente.mae = txtmae.Text;
        }

        private void MaskedTextBox_Validated_1(object sender, EventArgs e)
        {
            Cliente.cpf_pai = txtcpfpai.Text;
        }

        private void txtcpfmae_Validated(object sender, EventArgs e)
        {
            Cliente.cpf_mae = txtcpfmae.Text;
        }

        private void txtfonepai_Validated(object sender, EventArgs e)
        {
            Cliente.fone_pai = txtfonepai.Text;
        }

        private void txtfonemae_Validated(object sender, EventArgs e)
        {
            Cliente.fone_mae = txtfonemae.Text;
        }

        private void txtendereco_LostFocus(object sender, RoutedEventArgs e)
        {
            Cliente.endereco = txtendereco.Text;
        }

        private void txtnumero_LostFocus(object sender, RoutedEventArgs e)
        {
            Cliente.numero = txtnumero.Text;
        }

        private void txtbairro_LostFocus(object sender, RoutedEventArgs e)
        {
            Cliente.bairro = txtbairro.Text;
        }

        private void txtcomplemento_LostFocus(object sender, RoutedEventArgs e)
        {
            Cliente.complemento = txtcomplemento.Text;
        }

        private void txtcidade_LostFocus(object sender, RoutedEventArgs e)
        {
            Cliente.cidade = txtcidade.Text;
        }

        private void txtEstado_LostFocus(object sender, RoutedEventArgs e)
        {
            Cliente.estado = txtEstado.Text;
        }

        private void txtcep_Validated(object sender, EventArgs e)
        {
            Cliente.cep = txtcep.Text;
        }

        private void txtfilhos_LostFocus(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtfilhos.Text))
                try
                {

                    Cliente.filhos = int.Parse(txtfilhos.Text);
                }
                catch
                {
                    Cliente.filhos = 0; txtfilhos.Text = "0";
                }
            else
            {
                txtfilhos.Text = "0";
                Cliente.filhos = 0;
            }
        }

        private void txtrg_LostFocus(object sender, RoutedEventArgs e)
        {
            Cliente.RG = txtrg.Text;
        }

        private void txtfilhos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab ) return;
           if(Enumero(e.Key) == false)
           {
               e.Handled= true;
           }
           
        }
        private bool Enumero(Key keys)
        {
            if (keys.ToString().Contains('1') == true)
                return true;
            else if (keys.ToString().Contains('2') == true)
                return true;
            else if (keys.ToString().Contains('3') == true)
                return true;
            else if (keys.ToString().Contains('4') == true)
                return true;
            else if (keys.ToString().Contains('5') == true)
                return true;
            else if (keys.ToString().Contains('6') == true)
                return true;
            else if (keys.ToString().Contains('7') == true)
                return true;
            else if (keys.ToString().Contains('8') == true)
                return true;
            else if (keys.ToString().Contains('9') == true)
                return true;
            else if (keys.ToString().Contains('0') == true)
                return true;
            else
                return false;

        }

        private void btnPesquisarCliente_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SistemaShekinahCompleto.Views.ViewsSecretaria.ListaClientes());
        }

        private void btnAdicionarAluno_Click(object sender, RoutedEventArgs e)
        {
            if (Cliente.id_cliente > 0)
                NavigationService.Navigate(new SistemaShekinahCompleto.Views.ViewsSecretaria.AtualizaAluno(Cliente));
            else
                MessageBox.Show("Cadastre um cliente primeiro\nou pesquise um qua já esteja cadastrado");
        }
      
    }
}
