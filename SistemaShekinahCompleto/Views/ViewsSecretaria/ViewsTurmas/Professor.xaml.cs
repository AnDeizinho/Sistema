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
namespace SistemaShekinahCompleto.Views.ViewsSecretaria.ViewsTurmas
{
    /// <summary>
    /// Interaction logic for Professor.xaml
    /// </summary>
    public partial class Professor : UserControl
    {
        TodasAsProfessoras Professores;
        TurmasDAO turmas = new TurmasDAO();
        enum transacao { Indefinido, Novo, Alterar, Deletar }
        transacao tras = transacao.Indefinido;
        public Professor()
        {
            string msg = "";
            Professores = new TodasAsProfessoras();
            if (turmas.CarregaProfessores(Professores, ref msg) == RetornosDoModel.Erro)
            {
                MessageBox.Show(msg);
            }
            
            InitializeComponent();
            carregaLista();
        }
        void carregaLista()
        {
            for (int i = 0; i < Professores.Count; i++)
            {
                LsBx.Items.Add(Professores[i].professor);
            }
        }
        void limpa()
        {
            tras = transacao.Indefinido;
            txtProf.IsEnabled = false;
            BtnSalvar.IsEnabled = false;
            BtnCancelar.IsEnabled = false;
            txtProf.Text = "";
        }
        
        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            if (tras == transacao.Indefinido)
            {
                tras = transacao.Novo;
                txtProf.IsEnabled = true;
                BtnSalvar.IsEnabled = true;
                BtnCancelar.IsEnabled = true;
                txtProf.Text = "";
                txtProf.Focus();
            }
        }
        void CadastrarProfessor(ref ProfessorEnt prof)
        {
            string mensagem = "";
            RetornosDoModel ret = turmas.InsertProfessor(ref prof, ref mensagem);
            switch (ret)
            {
                case RetornosDoModel.Erro:
                    MessageBox.Show(mensagem);
                    limpa();
                    break;
                case RetornosDoModel.Existe:
                    MessageBox.Show(mensagem);
                    limpa();
                    break;
                case RetornosDoModel.Cadastrado:
                    
                    Professores.Add(prof);
                    LsBx.Items.Add(prof.professor);
                    limpa();
                    break;
            }
        }
        void DeletarProfessor(ref ProfessorEnt prof)
        {
            string msg = "";
            RetornosDoModel retorno = turmas.DeletarProfessor(ref prof, ref msg);
            if (retorno == RetornosDoModel.Erro)
            {
                MessageBox.Show(msg);
            }
            else
            {
                LsBx.Items.Remove(prof.professor);
                Professores.Remove(prof);
            }

        }
        void AlterarProfessor(ref ProfessorEnt prof)
        {
            tras = transacao.Alterar;
            string mesg = "";
            prof.professor = txtProf.Text;
            RetornosDoModel ret = turmas.AlterarProfessor(ref prof, ref mesg);
            if (ret == RetornosDoModel.Erro)
                MessageBox.Show(mesg);
            else if (ret == RetornosDoModel.Existe)
            {
                MessageBox.Show(mesg);
            }
            else
            {
                int i = LsBx.SelectedIndex;
                Professores[i] = prof;
                LsBx.Items[i] = prof.professor;
            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            limpa();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            switch (tras)
            {
                case transacao.Novo:
                    ProfessorEnt prof = new ProfessorEnt
                    {
                        id_prof = 0,
                        professor = txtProf.Text,
                        login = "",
                        tipo_de_usuario = "",
                        senha = ""
                    };
                    CadastrarProfessor(ref prof);
                    tras = transacao.Indefinido;
                    break;
                case transacao.Alterar:
                    ProfessorEnt profe = new ProfessorEnt
                    {
                        id_prof = Professores[LsBx.SelectedIndex].id_prof,
                        professor =  Professores[LsBx.SelectedIndex].professor ,
                        tipo_de_usuario = Professores[LsBx.SelectedIndex].tipo_de_usuario,
                        login = Professores[LsBx.SelectedIndex].login,
                        senha  = Professores[LsBx.SelectedIndex].senha,

                    };
                        AlterarProfessor(ref profe);
                        tras = transacao.Indefinido;
                        break;
            }
        }

        private void btnDeletar_Click(object sender, RoutedEventArgs e)
        {
            ProfessorEnt profe  = Professores[LsBx.SelectedIndex];
            DeletarProfessor(ref profe);
            
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (tras == transacao.Indefinido)
            {
                tras = transacao.Alterar;
                txtProf.IsEnabled = true;
                BtnSalvar.IsEnabled = true;
                BtnCancelar.IsEnabled = true;
                
                txtProf.Text = LsBx.Items[LsBx.SelectedIndex].ToString();
                txtProf.Focus();
            }
        }
    }
}
