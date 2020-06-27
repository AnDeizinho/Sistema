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
    public partial class frmDeposito : frmFormulario
    {
        
        public frmDeposito()
        {
            InitializeComponent();
            
        }
        private void deposita(double valor)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDCaixa);
                conexao.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@Data", StatusDoCaixa.data.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute).AddSeconds(DateTime.Now.Second));
                comando.Parameters.AddWithValue("@valor", valor);
                comando.CommandText = "insert into tblDeposito (Data, Valor_Deposito) values (@Data, @valor)";
                comando.ExecuteNonQuery();
                

                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao Depositar");
            }
        }
        private void listarGrid()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDCaixa);
                conexao.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@Data", StatusDoCaixa.data.Date);
                comando.Parameters.AddWithValue("@amanha", StatusDoCaixa.data.Date.AddDays(1));
                comando.CommandText = "select Data, Valor_Deposito from tblDeposito where Data >= @data and Data < @amanha";
                comando.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(comando);
                DataTable tblDeposito = new DataTable();
                adp.Fill(tblDeposito);
                tblDeposito.Columns[0].ColumnName = "Data";
                tblDeposito.Columns[1].ColumnName = "Valor de depósito";
                grid.DataSource = tblDeposito;

                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao Carregar o DataGrid");
            }
        }
        private void frmDeposito_Load(object sender, EventArgs e)
        {
            listarGrid();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text != "")
            {
                deposita(Convert.ToDouble(Convert.ToDouble(txtValor.Text).ToString("N")));
                listarGrid();
                this.Close();
            }
        }
    }
}
