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
    public partial class frmFechaCaixa : frmFormulario
    {
        public frmFechaCaixa()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {

        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDCaixa);
                conexao.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@statu", 'f');
                comando.Parameters.AddWithValue("@vApre", Convert.ToDouble(Convert.ToDouble(txtValor.Text).ToString("N")));
                comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
                comando.CommandText = "update tblResumo_De_Caixas set Status = @statu, Valor_Apresentado = @vApre where Data = @data";
                comando.ExecuteNonQuery();
                conexao.Close();
               
                MessageBox.Show("Sucesso na operação");
                this.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show("ERRO na operação" + erro);
            }
        }

        private void frmFechaCaixa_Load(object sender, EventArgs e)
        {

        }

        //private void btnAbrir_Click(object sender, EventArgs e)
        //{

            
        
    }
}
