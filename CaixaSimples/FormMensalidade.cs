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
using SistemaShekinahCompleto.Entidades;
using SistemaShekinahCompleto.DAO;
namespace CaixaSimples
{
    public partial class FormMensalidade : frmFormulario
    {
        Pagamento.InfoPag Info;
        DataTable Tbl_Mensalidade;
        DataTable Tbl_Historico;
        public FormMensalidade(Pagamento.InfoPag Inf, DataTable men, DataTable his)
        {
            Info = Inf;
            Tbl_Mensalidade = men;
            Tbl_Historico = his;
            InitializeComponent();
            listaMensalidade();
            this.cbMes.SelectedIndex = System.Convert.ToInt32(System.DateTime.Now.Month.ToString()) - 1;
            this.cbPagamento.SelectedIndex = 0;
            
            
        }
        

        private void FormMensalidade_Load(object sender, EventArgs e)
        {
            txtCC.Text = "" + Info.Id_cliente;
            //MessageBox.Show(DateTime.Now.Month.ToString());
        }

        
        private void cadastra(DateTime data, string serie, string aluno, string mes,string ano, string forma, double valor)
        {
            SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@id", txtCC.Text);
            comando.Parameters.AddWithValue("@Data", data);
            comando.Parameters.AddWithValue("@Serie", serie);
            comando.Parameters.AddWithValue("@Aluno", aluno);
            comando.Parameters.AddWithValue("@Mes", mes);
            comando.Parameters.AddWithValue("@ano", ano);
            comando.Parameters.AddWithValue("@Forma_Pagamento", forma);
            comando.Parameters.AddWithValue("@Valor", valor);
            comando.CommandText = "INSERT INTO [tbl_Mensalidade] (id_cliente, [Data],[Serie],[Aluno],[Mes],[Ano],[Forma_Pagamento],[Valor]) VALUES (@id, @Data, @Serie, @Aluno, @Mes,@ano, @Forma_Pagamento, @Valor)";
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        private void Mensalidade()
        {
            SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDAtaFinal);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@id", txtCC.Text);
            comando.Parameters.AddWithValue("@Data", StatusDoCaixa.data.Date);
            
            comando.Parameters.AddWithValue("@Mes", cbMes.Text);
            comando.Parameters.AddWithValue("@ano", Info.AnoContrato);
            
            comando.Parameters.AddWithValue("@Valor", Convert.ToDouble(txtValor.Text));
            comando.CommandText = "update [tbl_Mes] set Data = @Data, Valor = Valor + @Valor where id_cliente = @id and Meses = @mes and ANO = @ano";
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        private void imprimeReciboLimpo()
        {
            if (MessageBox.Show("deseja imprimir um recibo?", "imprimir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmImprimeMensalidade forma = new frmImprimeMensalidade();
                forma.ShowDialog();
            }
            else
            {
                return;
            }
        }
        private void imprimeReciboPreenchido(string[] args, int codigo_do_Cliente, string ano)
        {
            if (MessageBox.Show("deseja imprimir um recibo?", "imprimir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmImprimeMensalidade forma = new frmImprimeMensalidade(args, codigo_do_Cliente, ano);
                forma.ShowDialog();
            }
            else
            {
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                //dialogo.ShowDialog();
                cadastra(StatusDoCaixa.data.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute).AddSeconds(DateTime.Now.Second), Info.Turma, Info.NomeAluno, cbMes.Text,Info.AnoContrato, cbPagamento.Text, Convert.ToDouble(Convert.ToDouble(txtValor.Text).ToString("N")));
                
                if (Info.Id_cliente> 0)
                {
                    Mensalidade();
                    listaMensalidade();
                }

                
                    string []argumentos = {cbMes.Text, txtValor.Text, Info.AnoContrato, DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString()};
                    imprimeReciboPreenchido(argumentos, Info.Id_cliente, Info.AnoContrato);
                
                

                if (MessageBox.Show("Sucesso ao concluir \ndeseja continuar? ", "capition", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    cbMes.Focus();
                    txtValor.Text = "";
                    
                }
                else
                {
                    this.Close();
                }
                

                
            }
            catch(Exception erro)
            {
                MessageBox.Show("ERRO\nDigite Apenas numeros, se nescessário separe os centavos com vírgula!!!\n " + erro.ToString());
            }
        }

       

        private void imprimi_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string texto = "\t\tteste de impressao\n\t";
            texto += "Série : \t\t\t" + Info.Turma + "\n\t";
            texto += "Aluno : \t\t\t" + Info.NomeAluno + "\n\t";
            texto += "Mes : \t\t\t" + cbMes.Text + "\n\t";
            texto += "Forma de Pagamento : \t" + cbPagamento.Text + "\n\t";
            texto += "Valor : \t\t\t" + Convert.ToDouble(txtValor.Text).ToString("C");
            
            Font font = new Font("Arial", 18,FontStyle.Bold);
            Brush bru = Brushes.Black;
            e.Graphics.DrawString(texto, font, bru, new PointF(5, 20));

        }

        

        
        private void listaMensalidade()
        {
            
            dataGridView1.DataSource = Tbl_Mensalidade;

            DTGV.DataSource = Tbl_Historico;
            

        }
        
        private void txtValor_Validating(object sender, CancelEventArgs e)
        {
            if (txtValor.Text != "")
            {
                try
                {
                    double valor = Convert.ToDouble(txtValor.Text);
                    txtValor.Text = valor.ToString("N");
                }
                catch
                {
                    txtValor.Text = "";
                    txtValor.Focus();
                }
            }
            else
            {
                txtValor.Focus();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            imprimeReciboLimpo();
        }

        
        

       
    }
}
