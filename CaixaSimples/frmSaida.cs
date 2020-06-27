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
    public partial class frmSaida : frmFormulario
    {
        public frmSaida()
        {
            InitializeComponent();
        }
        private void deposita(double valor)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(@StatusDoCaixa.conStringBDCaixa);
                conexao.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@Data", StatusDoCaixa.data.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute).AddSeconds(DateTime.Now.Second));
                comando.Parameters.AddWithValue("@valor", valor);
                comando.Parameters.AddWithValue("@desc", txtDescricao.Text);
                comando.CommandText = "insert into tblSaida (Data, Valor_Saida, Descricao) values (@Data, @valor, @desc)";
                comando.ExecuteNonQuery();


                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao Retirar");
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
                comando.CommandText = "select Data, Valor_Saida, Descricao from tblSaida where Data >= @data and Data < @amanha";
                comando.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(comando);
                DataTable tblSaida = new DataTable();
                adp.Fill(tblSaida);
                grid.DataSource = tblSaida;

                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao Carregar o DataGrid");
            }
        }
        private void frmSaida_Load(object sender, EventArgs e)
        {
            listarGrid();
        }
        private void depositaDoDeposito(double valor)
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
        private void btnSaida_Click(object sender, EventArgs e)
        {
            if (txtValor.Text != "")
            {
                if (MessageBox.Show("Deseja abater do Depósito ?", "Abeter?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    depositaDoDeposito(Convert.ToDouble(Convert.ToDouble(txtValor.Text).ToString("N")) * (-1));
                    deposita(Convert.ToDouble(Convert.ToDouble(txtValor.Text).ToString("N")));

                }
                else
                {
                    deposita(Convert.ToDouble(Convert.ToDouble(txtValor.Text).ToString("N")));
                }

                listarGrid();
                this.Close();
            }
        }
    }
}
