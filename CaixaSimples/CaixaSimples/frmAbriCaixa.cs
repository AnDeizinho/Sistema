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
    public partial class frmAbriCaixa : frmFormulario
    {
        
        public frmAbriCaixa()
        {
            
            InitializeComponent();
        }
        private void abrirCaixa(double fundo)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDCaixa);
                conexao.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.Parameters.AddWithValue("@Data", StatusDoCaixa.data.Date);
                comando.Parameters.AddWithValue("@Status", 'a');
                comando.Parameters.AddWithValue("@Dinheiro", 0);
                comando.Parameters.AddWithValue("@Saida", 0);
                comando.Parameters.AddWithValue("@Debito", 0);
                comando.Parameters.AddWithValue("@Credito", 0);
                comando.Parameters.AddWithValue("@Total_Cartao", 0);
                comando.Parameters.AddWithValue("@Total_Entrada", 0);
                comando.Parameters.AddWithValue("@Total_Produtos", 0);
                comando.Parameters.AddWithValue("@Total_Especie", 0);
                comando.Parameters.AddWithValue("@Fundo_De_Caixa", fundo);
                comando.Parameters.AddWithValue("@Total_Deposito", 0);
                comando.Parameters.AddWithValue("@Valor_Apresentado", 0);
                comando.Parameters.AddWithValue("@Conclusao", 0);
                comando.CommandText = @"INSERT INTO tblResumo_De_Caixas (Data, Status, Dinheiro, Saida, Debito, Credito, Total_Cartao, Total_Entrada,Total_Produtos, Total_Especie, Fundo_De_Caixa, Total_Deposito, Valor_Apresentado, Conclusao) VALUES (@Data, @Status, @Dinheiro, @Saida, @Debito, @Credito, @Total_Cartao, @Total_Entrada, @Total_Produtos ,@Total_Especie, @Fundo_De_Caixa, @Total_Deposito, @Valor_Apresentado, @Conclusao)";
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao Abrir Caixa!!!!");
            }
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if(txtFundo.Text == "")
            {
                txtFundo.Text = "0";
            }

            abrirCaixa(Convert.ToDouble(Convert.ToDouble(txtFundo.Text).ToString("N")));
            MessageBox.Show("Caixa aberto com sucesso");
            this.Close();

        }

        private void frmAbriCaixa_Load(object sender, EventArgs e)
        {

        }
    }
}
