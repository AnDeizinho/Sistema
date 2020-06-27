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
    public partial class FormMensalidade : frmFormulario
    {
        DataTable tbl_turma = new DataTable();
        adp adapt;
        int id_Cliente = 0;
        public FormMensalidade()
        {
            InitializeComponent();
            this.cbSerie.SelectedIndex = 0;
            this.cbMes.SelectedIndex = System.Convert.ToInt32(System.DateTime.Now.Month.ToString()) - 1;
            this.cbPagamento.SelectedIndex = 0;
            this.cbano.SelectedIndex = 0;
            
        }

        private void FormMensalidade_Load(object sender, EventArgs e)
        {
            txtCC.Text = "" + id_Cliente;
            adapt = new adp("select id_turma, descricao from tbl_turma");
            adapt.Preencher(tbl_turma);

            foreach (DataRow linha in tbl_turma.Rows)
            {
                cbSerie.Items.Add(linha[1].ToString());
            }

            //MessageBox.Show(DateTime.Now.Month.ToString());
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender,KeyEventArgs e)
        {
           


            
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            comando.Parameters.AddWithValue("@ano", cbano.Text);
            
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
                cadastra(StatusDoCaixa.data.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute).AddSeconds(DateTime.Now.Second), cbSerie.Text, txtAluno.Text, cbMes.Text,cbano.Text, cbPagamento.Text, Convert.ToDouble(Convert.ToDouble(txtValor.Text).ToString("N")));
                id_Cliente = Convert.ToInt32(txtCC.Text);
                if (id_Cliente > 0)
                {
                    Mensalidade();
                    listaMensalidade();
                }

                
                    string []argumentos = {cbMes.Text, txtValor.Text, cbano.Text, DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString()};
                    imprimeReciboPreenchido(argumentos, id_Cliente, cbano.Text);
                
                

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

        private void dialogo_Load(object sender, EventArgs e)
        {
            
        }

        private void imprimi_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string texto = "\t\tteste de impressao\n\t";
            texto += "Série : \t\t\t" + cbSerie.Text + "\n\t";
            texto += "Aluno : \t\t\t" + txtAluno.Text + "\n\t";
            texto += "Mes : \t\t\t" + cbMes.Text + "\n\t";
            texto += "Forma de Pagamento : \t" + cbPagamento.Text + "\n\t";
            texto += "Valor : \t\t\t" + Convert.ToDouble(txtValor.Text).ToString("C");
            
            Font font = new Font("Arial", 18,FontStyle.Bold);
            Brush bru = Brushes.Black;
            e.Graphics.DrawString(texto, font, bru, new PointF(5, 20));

        }

        private void cbano_Validated(object sender, EventArgs e)
        {
            if (cbano.SelectedIndex == 0)
            {
                
                cbano.Focus();
            }
        }

        private void cbSerie_Validated(object sender, EventArgs e)
        {
            if (cbSerie.SelectedIndex == 0)
            {
                cbSerie.Focus();
            }
            else if( cbSerie.SelectedIndex > 0)
            {
                try
                {
                    int id_turma = Convert.ToInt32(tbl_turma.Rows[cbSerie.SelectedIndex - 1][0].ToString());

                    adapt = new adp("select nome from tbl_Alunos where id_turma = " + id_turma);
                    DataTable tbl_Alunos = new DataTable();

                    adapt.Preencher(tbl_Alunos);

                    foreach (DataRow linha in tbl_Alunos.Rows)
                    {
                        txtAluno.AutoCompleteCustomSource.Add(linha[0].ToString());
                    }
                }
                catch
                {
                    MessageBox.Show("erro ao carregar nomes de alunos");
                }
            }
        }
        private void listaMensalidade()
        {
            SqlCommand carregaMeses = new SqlCommand();
            carregaMeses.Parameters.AddWithValue("@id", id_Cliente);
            carregaMeses.Parameters.AddWithValue("@ano", cbano.Text);
            carregaMeses.CommandText = "select meses, valor from tbl_mes where id_cliente = @id and ano = @ano";
            adapt.SelectComando(carregaMeses);
            DataTable tbl_mes = new DataTable();
            adapt.Preencher(tbl_mes);
            dataGridView1.DataSource = tbl_mes;

            SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDCaixa);
            
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@id", txtCC.Text);
            
            comando.Parameters.AddWithValue("@ano", cbano.Text);

            
            comando.CommandText = "select Id_Cliente, Data, Mes, Forma_pagamento, Valor from tbl_Mensalidade where id_Cliente = @id and Ano = @ano";
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tblFormas = new DataTable();
            adaptador.Fill(tblFormas);
            DTGV.DataSource = tblFormas;
            

        }
        private void txtAluno_Validated(object sender, EventArgs e)
        {
            if (txtAluno.Text == "")
            {
                txtAluno.Focus();
            }
            else
            {
                adapt = new adp("select id_cliente from tbl_Alunos where nome = '" + txtAluno.Text + "'");
                DataTable tbl_Alunos_id_Cliente = new DataTable();
                adapt.Preencher(tbl_Alunos_id_Cliente);

                

                if (tbl_Alunos_id_Cliente.Rows.Count > 0)
                {
                    
                    id_Cliente = Convert.ToInt32(tbl_Alunos_id_Cliente.Rows[0][0].ToString());
                    adapt = new adp("select id_cliente from tbl_Alunos where id_cliente = " + id_Cliente  + " and ano_recente = " + cbano.Text);
                    DataTable tblId_cliente = new DataTable();
                    adapt.Preencher(tblId_cliente);

                    txtFilhos.Text = tblId_cliente.Rows.Count.ToString();

                    lblAviso.Text = "Cliente encontrado";
                    lblAviso.ForeColor = Color.Navy;

                    

                    txtCC.Text = "" + id_Cliente;

                    listaMensalidade();
                }
                else
                {
                    lblAviso.Text = "Cliente não encontrado";
                    lblAviso.ForeColor = Color.Red;

                    txtFilhos.Text = "0";
                    id_Cliente = 0;

                    txtCC.Text = "" + id_Cliente;

                    SqlCommand carregaMeses = new SqlCommand();
                    carregaMeses.Parameters.AddWithValue("@id", id_Cliente);
                    carregaMeses.Parameters.AddWithValue("@ano", cbano.Text);
                    carregaMeses.CommandText = "select meses, valor from tbl_mes where id_meses = 0";
                    adapt.SelectComando(carregaMeses);
                    DataTable tbl_mes = new DataTable();
                    adapt.Preencher(tbl_mes);
                    dataGridView1.DataSource = tbl_mes;

                    SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDCaixa);

                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexao;
                    comando.Parameters.AddWithValue("@id", txtCC.Text);

                    comando.Parameters.AddWithValue("@ano", cbano.Text);


                    comando.CommandText = "select Id_Cliente, Data, Mes, Forma_pagamento, Valor from tbl_Mensalidade where id_mensalidade = 0";
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tblFormas = new DataTable();
                    adaptador.Fill(tblFormas);
                    DTGV.DataSource = tblFormas;

                    

                }


            }
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
