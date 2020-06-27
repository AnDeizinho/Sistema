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

namespace CaixaSimples
{
    public partial class frmHistorico : frmFormulario
    {
        public frmHistorico()
        {
            InitializeComponent();
        }
        private void listarDatasRecentes()
        {
            try
            {
                SqlConnection conexao =new SistemaShekinahCompleto.Model.Conexao().NovaConexaoBdCaixa();
                conexao.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@hoje", DateTime.Now.Date);
                comando.Parameters.AddWithValue("@dtinicio", DateTime.Now.AddDays(-15).Date);
                comando.CommandText = "select Data from tblResumo_De_Caixas where Data <= @hoje and Data >= @dtinicio";
                SqlDataAdapter adp = new SqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adp.Fill(tabela);
                foreach (DataRow linha in tabela.Rows)
                {
                    lista.Items.Add(Convert.ToDateTime(linha[0].ToString()).ToString("dd/MM/yyyy"));
                }
                conexao.Close();
            }
            catch
            {

                MessageBox.Show("Erro ao listar listBox");
            }
        }
        private void frmHistorico_Load(object sender, EventArgs e)
        {
            listarDatasRecentes();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            StatusDoCaixa.data = DtData.Value.Date;
            this.Close();
        }

        private void lista_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime data = Convert.ToDateTime(lista.SelectedItem.ToString());
                DtData.Value = data.Date;
            }
            catch
            {

            }
            //MessageBox.Show("item selecionado " + lista.SelectedItem +"valor selecionado " + lista.SelectedValue + "texto "+lista.Text);
        }

        private void btnBalanco_Click(object sender, EventArgs e)
        {
            FrmBalanco bal = new FrmBalanco();
            bal.ShowDialog();
        }

        
    }
}
