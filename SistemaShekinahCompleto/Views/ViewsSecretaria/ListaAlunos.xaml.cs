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
using SistemaShekinahCompleto.DAO;
using System.Data;
using SistemaShekinahCompleto.Entidades;
namespace SistemaShekinahCompleto.Views.ViewsSecretaria
{
    /// <summary>
    /// Interaction logic for ListaAlunos.xaml
    /// </summary>
    
    public partial class ListaAlunos : Page
    {
        AlunosDAO lista;
        TurmasDAO turmas;
        AlunosEnt tbl;
        //System.Windows.Forms.BindingSource Bd;
        
        public ListaAlunos()
        {
            //this.Content = "Garregando os Dados";
           // Bd = new System.Windows.Forms.BindingSource();
            turmas = new TurmasDAO();
            tbl = new AlunosEnt();
            lista = new AlunosDAO();

            tbl = lista.TodosOsAlunos();
            
            
            InitializeComponent();
            
            
          
        }
        void carregaComboBox()
        {
            TurmaEnt Tr = new TurmaEnt();
            Tr.descricao = "Todos";
            cbTurmas.Items.Add(Tr);
            cbTurmas.SelectedIndex=1;
            foreach (TurmaEnt T in turmas.SelectTurmas("2019"))
            {
                cbTurmas.Items.Add(T);
            }
        }
        void Select()
        {
            if (tbl.Count > 0) 
                tbl.Clear();
          
           //
            tbl = lista.TodosOsAlunos();
            MeuGrid.ItemsSource = tbl;
            TotalLinhas();

        }
        void Select(int idturma)
        {
            if (tbl.Count > 0)
                 tbl.Clear();
                MeuGrid.ItemsSource = null;
                tbl=lista.TodosOsAlunos(idturma);
                MeuGrid.ItemsSource = tbl;
               
               
                
            TotalLinhas();
        }

        void TotalLinhas()
        {
            lblTT.Content = "Total = " + MeuGrid.Items.Count;
         }
      
        private void MeuGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (MeuGrid.SelectedIndex >= 0)
            {
                
                AlunoEnt aluno = MeuGrid.Items[MeuGrid.SelectedIndex] as AlunoEnt;
               // MessageBox.Show(aluno.ToString());
               //NavigationService.Navigate(new SistemaShekinahCompleto.Views.ViewsSecretaria.AtualizaAluno( aluno));
            }
        }

        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
            Select();
            carregaComboBox();
        }

        private void cbTurmas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbTurmas.SelectedIndex > 1)
            {
                TurmaEnt t = cbTurmas.Items[cbTurmas.SelectedIndex] as TurmaEnt;
                Select(t.id_turma);
            }
            else
            {
                Select();
            }
        }

        private void btnAltera_Click(object sender, RoutedEventArgs e)
        {
            
        }

       
        

        

        
    }
}
