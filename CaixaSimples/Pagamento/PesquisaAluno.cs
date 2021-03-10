using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaShekinahCompleto.Model;

namespace CaixaSimples.Pagamento
{
    public class InfoPag
    {
        public int Id_cliente { get; set; }
        public string NomeAluno { get; set; }
        public string AnoRecente { get; set; }
        public string Turma { get; set; }
        public string AnoContrato { get; set; }
    }
    public partial class PesquisaAluno : Form
    {
        
        public InfoPag Info { get; set; }
        public PesquisaAluno()
        {
            Info = new InfoPag();
            InitializeComponent();
            lbalunos.RowHeadersVisible = false;
            
        }

        private void txtAluno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DbCliente bd = new DbCliente();
                   
                    lbalunos.DataSource = bd.Select(string.Format("select id_aluno, id_cliente, nome, Descricao, ano_recente from tbl_alunos a join tbl_turma t on a.id_turma = t.id_turma  where nome like '%{0}%'", txtAluno.Text));
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void lbalunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex >= 0)
            {

                Info.Id_cliente = int.Parse(((DataGridView)sender).Rows[e.RowIndex].Cells["id_cliente"].Value.ToString());
                Info.NomeAluno = ((DataGridView)sender).Rows[e.RowIndex].Cells["nome"].Value.ToString().Trim();
                Info.Turma = ((DataGridView)sender).Rows[e.RowIndex].Cells["Descricao"].Value.ToString().Trim();
                Info.AnoRecente = ((DataGridView)sender).Rows[e.RowIndex].Cells["nome"].Value.ToString().Trim();
                
                this.Close();

                
            }
        
        }

        
    }
}
