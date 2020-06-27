using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SistemaShekinahCompleto.DAO;
using SistemaShekinahCompleto.Entidades;

namespace SistemaShekinahCompleto.Views.ViewsSecretaria
{
    /// <summary>
    /// Interaction logic for ListaClientes.xaml
    /// </summary>
    public partial class ListaClientes : Page
    {
        ClienteDAO cli;
        DataTable tbl;
        public ListaClientes()
        {
            cli = new ClienteDAO();
            InitializeComponent();
            tbl = cli.Select();
            DtGrid.ItemsSource = tbl.DefaultView;
            DtGrid.AutoGenerateColumns = true;
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (DtGrid.SelectedIndex >= 0)
            {
                DataRow li = tbl.Rows[DtGrid.SelectedIndex];
                ClienteEnt cliente = new ClienteEnt()
                {
                    id_cliente = int.Parse(li["id_cliente"].ToString()),
                    pai = li["pai"].ToString(),
                    mae = li["mae"].ToString(),
                    fone_mae = li["fone_pai"].ToString(),
                    fone_pai = li["fone_mae"].ToString(),
                    cpf_pai = li["cpf_pai"].ToString(),
                    cpf_mae = li["cpf_mae"].ToString(),
                    RG = li["rg"].ToString(),
                    filhos = int.Parse(li["filhos"].ToString()),
                    cidade = li["cidade"].ToString(),
                    endereco = li["endereco"].ToString(),
                    estado = li["estado"].ToString(),
                    cep = li["cep"].ToString(),
                    bairro = li["bairro"].ToString(),
                    complemento = li["complemento"].ToString(),
                    numero = li["numero"].ToString()
                };
                this.NavigationService.Navigate(new SistemaShekinahCompleto.Views.ViewsSecretaria.CadastroDeCliente(cliente));
            }
        }
    }
}
