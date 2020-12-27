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
    /// Interaction logic for MontaTurma.xaml
    /// </summary>
        
    public partial class MontaTurma : UserControl
    {
        //Atributos e Propiedades ========================
        TodasAsProfessoras Professores;
        TurmasEnt TodasAsTurmas = new TurmasEnt();
        
        TurmasDAO turmas = new TurmasDAO();
        TodasAsSeries todasasseries;
        enum transacao { Indefinido, Novo, Alterar, Deletar }
        transacao tras;
        //Construtor sem argumentos ======================
        public MontaTurma()
        {
            Professores = new TodasAsProfessoras();
            string msg = "";
            turmas.CarregaProfessores(Professores, ref msg);
            todasasseries = new TodasAsSeries();
            InitializeComponent();
            
            CarreOsCombos();


        }
        //Transacoes possimeis=========================
        private void onAlterar()
        {
            tras = transacao.Alterar;
            cbano.IsEnabled = false;

            txtTurma.IsEnabled = true;
            
            txtTurma.Focus();
            cbserie.IsEnabled = true;
            cbNivel.IsEnabled = true;
            cbturno.IsEnabled = true;
            cbprofessor.IsEnabled = true;
            
            BtnSalvar.IsEnabled = true;
            BtnCancelar.IsEnabled = true;
        }
        void onIdefinido()
        {
            tras = transacao.Indefinido;
            cbano.IsEnabled = true;
            txtTurma.IsEnabled = false;
            cbserie.IsEnabled = false;
            cbNivel.IsEnabled = false;
            cbturno.IsEnabled = false;
            cbprofessor.IsEnabled = false;
       
            BtnSalvar.IsEnabled = false;
            BtnCancelar.IsEnabled = false;

        }
        void onNovo()
        {
            tras = transacao.Novo;
            cbano.IsEnabled = false;
            txtTurma.IsEnabled = true;
            txtTurma.Text = "";
            txtTurma.Focus();
            cbserie.IsEnabled = true;
            cbNivel.IsEnabled = true;
            cbturno.IsEnabled = true;
            cbprofessor.IsEnabled = true;
            
            BtnSalvar.IsEnabled = true;
            BtnCancelar.IsEnabled = true;
            cbNivel.SelectedIndex = 0;
            cbserie.SelectedIndex = 0;
            cbturno.SelectedIndex = 0;
            cbprofessor.SelectedIndex = 0;

        }
        private void onDeletar()
        {
            tras = transacao.Deletar;
            MessageBox.Show("Sugiro que faça a edição de um turma cadastrada, caso presize realmente deletar\n contate o desenvolvedor");
        }
        //Métodos internos ========================================
        bool IsValido(ComboBox [] cbs)
        {
            foreach (var i in cbs)
            {
                if (i.SelectedIndex == 0)
                {
                    MessageBox.Show("Preencha todos os Campos");
                    return true;
                }
            }
            return false;
        }
        //Tratamento de Coleçoes==================
        void CarreOsCombos()
        {
            //cbprofessor.Items.Add(new ProfessorEnt(){professor="professor(a)", id_prof =0});
            //cbprofessor.SelectedIndex = 0;
            foreach(ProfessorEnt p in Professores)
            {
                cbprofessor.Items.Add(p.professor);
            }
            
           
            foreach(AnoEnt s in todasasseries)
            {
                cbserie.Items.Add(s.ano);
            }
            cbturno.Items.Add(Turno.Matutino.ToString());
            cbturno.Items.Add(Turno.Vespertino.ToString());
            cbNivel.Items.Add(Niveis.Fundamental.ToString());
            cbNivel.Items.Add(Niveis.Infantil.ToString());

        }
        void limpaOscombos()
        {
            cbprofessor.ItemsSource = null;
            cbserie.ItemsSource = null;
            cbNivel.ItemsSource = null;
        }
        //Eventos do Contexto a=================================
        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            
            onNovo();
            
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            if (LsBx.SelectedIndex >= 0)
            {
                
                onAlterar();
                  
            }
        }

        private void btnDeletar_Click(object sender, RoutedEventArgs e)
        {
            onDeletar();
            tras = transacao.Indefinido;
        }
        //Eventos de Cadastro =====================================
        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (IsValido(new ComboBox[] { cbano, cbNivel, cbprofessor, cbserie, cbturno }) == true)
                return;
            if (tras == transacao.Novo)
            {
                TurmaEnt tur = new TurmaEnt()
                {
                    ano = txtano.Text,
                    Ano = todasasseries[cbserie.SelectedIndex-1],
                    descricao = txtTurma.Text,
                    Professeor = Professores[cbprofessor.SelectedIndex-1],
                    Turnos = (Turno) cbturno.SelectedIndex,
                    
                };
                
                string mensagem;
                if (turmas.CadastraTurma(tur, out mensagem) != RetornosDoModel.Cadastrado)
                {
                    MessageBox.Show(mensagem);
                    onIdefinido();
                }
                else
                {
               
                    TodasAsTurmas.Add(tur);
                    LsBx.ItemsSource = null;
                    LsBx.ItemsSource = TodasAsTurmas;
                    onIdefinido();
                }
            }
            else if(tras == transacao.Alterar)
            {
                TurmaEnt tur = new TurmaEnt();
                tur.ano = txtano.Text;
                tur.descricao = txtTurma.Text;
                tur.Ano = todasasseries[cbserie.SelectedIndex -1];
                tur.Turnos = (Turno)cbturno.SelectedIndex;
                tur.Professeor = Professores[cbprofessor.SelectedIndex - 1];
                string mensagem;
                if (turmas.AtualizaTurma(tur, out mensagem) != RetornosDoModel.Cadastrado)
                {
                    MessageBox.Show(mensagem);
                    onIdefinido();
                }
                else
                {
                    
                  
                    LsBx.ItemsSource = null;
                    LsBx.ItemsSource = TodasAsTurmas;
                    onIdefinido();
                }
            }

        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
         
            onIdefinido();
        }
        private void cbano_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var lista = sender as ComboBox;
            LsBx.ItemsSource = null;
            TodasAsTurmas.Clear();
            if (lista.SelectedIndex > 0)
            {
                
                var conteudo = (TextBlock)lista.SelectedItem;
                
                TodasAsTurmas = turmas.SelectTurmas(conteudo.Text);
                LsBx.ItemsSource = TodasAsTurmas;
            }
        }

        private void LsBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var lista = sender as ListBox;
            if(lista.SelectedIndex >=0)
            {
                TurmaEnt tur = (TurmaEnt)lista.Items[lista.SelectedIndex];
                txtTurma.Text = tur.descricao;
                cbserie.SelectedItem= tur.Ano.ano;
                cbNivel.SelectedItem = tur.Ano.id_nivel.ToString();
                cbturno.SelectedItem = tur.Turnos.ToString();
                cbNivel.SelectedItem = tur.Ano.id_nivel.ToString();
                MessageBox.Show("indice da lista =" + Professores.IndexOf(tur.Professeor)+"\n"+
                tur.Professeor.professor +"\n"+tur.Professeor.id_prof + "\n" + tur.Ano); 
                
                cbprofessor.SelectedItem = tur.Professeor.professor;
                
            }
        }

        private void cbprofessor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        
       
    }
}
