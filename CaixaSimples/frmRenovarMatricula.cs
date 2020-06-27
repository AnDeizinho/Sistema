using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaShekinahCompleto.DAO;
using SistemaShekinahCompleto.Entidades;
namespace CaixaSimples
{
    public partial class frmRenovarMatricula : frmFormulario
    {
        
        DataTable tblAta = new DataTable();
        AlunoEnt Aluno;
        public frmRenovarMatricula(AlunoEnt alu)
        {
            Aluno = alu;
            InitializeComponent();
        }
        
       
        private void frmRenovarMatricula_Load(object sender, EventArgs e)
        {
            lblNome.Text += Aluno.nome + " CC = " + Aluno.id_cliente;
            
            TurmasDAO daotur = new TurmasDAO();
            TurmasEnt turmas = daotur.SelectTurmas(DateTime.Now.Year.ToString());
            lsturmas.DataSource = turmas;
        }



        

       
    }
}
