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
    /// Interaction logic for AtualizaAluno.xaml
    /// </summary>
    public partial class AtualizaAluno : UserControl
    {
        AlunoEnt aluno;
        Modo modo;
        TurmasEnt Turmas;
        public AtualizaAluno()
        {
            InitializeComponent();
            modo = Modo.NovoCliente;
            Titulo.Content = "Novo Aluno";
            aluno = new AlunoEnt();
            
        }
        public AtualizaAluno(ClienteEnt cli)
        {
            aluno = new AlunoEnt();
            aluno.Atribuir(cli);
            InitializeComponent();
            txtid_cliente.Text = aluno.id_cliente.ToString();
           

        }
        public AtualizaAluno(AlunoEnt ent)
        {
            modo = Modo.AlterarCadastro;
            Titulo.Content = "Atualizar Dados Do Aluno";
            InitializeComponent();
            nome.Text = ent.nome;
            
            txtid_aluno.Text = "" + ent.id_aluno;
            txtid_cliente.Text = ""+ent.id_cliente;

          
        }

        void txtfone_pai_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        void txtfone_pai_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
