using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaShekinahCompleto.Entidades;
using SistemaShekinahCompleto.DAO;
namespace CaixaSimples.Controles
{
    public partial class SelecionarTurma : frmFormulario
    {
        public TurmaEnt Turma
        {
            get
            {
                
                return _turma;
            }
        }
        TurmaEnt _turma;
        TurmasEnt Turmas;
        public SelecionarTurma()
        {
            
            InitializeComponent();
        }
        public SelecionarTurma(TurmaEnt turma)
        {
            _turma = turma;
            InitializeComponent();
        }

        private void SelecionarTurma_Load(object sender, EventArgs e)
        {
            Turmas = new TurmasDAO().SelectTurmas("2019");
            ltTurmas.DataSource = Turmas;
        }
        void selecionaTurma()
        {
            _turma = Turmas[ltTurmas.SelectedIndex];
            this.Close();
        }
        private void ltTurmas_DoubleClick(object sender, EventArgs e)
        {
            selecionaTurma();
            
        }

        private void ltTurmas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                selecionaTurma();
            }
        }
    }
}
