using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CaixaSimples
{
    public partial class FrmBoletos : frmFormulario
    {
        int id_mensalidade = 0;
        int id_Cliente = 0;
        int indice_dt_mensalidade = 0;
        public FrmBoletos()
        {

            InitializeComponent();
        }
        private void _insertHistorico(string id, DateTime tempo, string serie, string aluno, string mes, string ano, string forma, double valor)
        {
            StringBuilder str = new StringBuilder();
            str.Append("INSERT INTO [BDcaixa].[dbo].[tbl_Mensalidade]");
            str.AppendLine("([Id_Cliente]");
            str.AppendLine(",[Data]");
            str.AppendLine(",[Serie]");
            str.AppendLine(",[Aluno]");
            str.AppendLine(",[Mes]");
            str.AppendLine(",[Ano]");
            str.AppendLine(",[Forma_Pagamento]");
            str.AppendLine(",[Valor]) ");
            str.AppendLine("  VALUES ");
           str.AppendLine("(@id");
           str.AppendLine(",@data");
           str.AppendLine(",@serie");
           str.AppendLine(",@aluno");
           str.AppendLine(",@mes");
           str.AppendLine(",@ano");
           str.AppendLine(",@forma");
           str.AppendLine(",@valor)");
           SqlConnection con = new SqlConnection(StatusDoCaixa.conStringBDCaixa);
           SqlCommand adp = new SqlCommand();
           adp.Connection = con;
           adp.CommandText = str.ToString();
           adp.Parameters.AddWithValue("@id", id);
           adp.Parameters.AddWithValue("@data", tempo.Date);
           adp.Parameters.AddWithValue("@serie", serie);
           adp.Parameters.AddWithValue("@aluno", aluno);
           adp.Parameters.AddWithValue("@mes", mes);
           adp.Parameters.AddWithValue("@ano", ano);
           adp.Parameters.AddWithValue("@forma", forma);
           adp.Parameters.AddWithValue("@valor", valor);
           con.Open();
           adp.ExecuteNonQuery();
           con.Close();

        }
        private void _validaCod()
        {
            this.dSBoletos.tbl_Mes.Clear();
            this.bDcaixaDataSet.tbl_Mensalidade.Clear();
            try
            {
                int codigo = Convert.ToInt32(txtCod.Text);
                if (codigo == 0)
                {
                    evacuar();
                    return;
                }
                if (CBCod.SelectedIndex == 0)
                {
                    this.tbl_MesTableAdapter.FillCB(this.dSBoletos.tbl_Mes, txtAno.Text, codigo);
                    if (this.dSBoletos.tbl_Mes.Rows.Count == 0)
                    {
                        MessageBox.Show("não há nenhum boleto cadastrado com esse codigo");
                        return;
                    }

                    this.tbl_MensalidadeTableAdapter.Fill_cliente(this.bDcaixaDataSet.tbl_Mensalidade, Convert.ToInt32(dSBoletos.tbl_Mes.Rows[0]["id_cliente"].ToString()),txtAno.Text);

                }
                else
                {
                    this.tbl_MesTableAdapter.Fill(this.dSBoletos.tbl_Mes, txtAno.Text, codigo);
                    this.tbl_MensalidadeTableAdapter.Fill_cliente(this.bDcaixaDataSet.tbl_Mensalidade, Convert.ToInt32(dSBoletos.tbl_Mes.Rows[0]["id_cliente"].ToString()),txtAno.Text);
                }

                id_Cliente = Convert.ToInt32(dSBoletos.tbl_Mes.Rows[0]["id_cliente"].ToString());
                txtpai.Text = dSBoletos.tbl_Mes.Rows[0]["pai"].ToString();
                txtmae.Text = dSBoletos.tbl_Mes.Rows[0]["mae"].ToString();
                txtboleto.Text = dSBoletos.tbl_Mes.Rows[0]["cb"].ToString();
                txtminimo.Text = dSBoletos.tbl_Mes.Rows[0]["parcela_min"].ToString();
                txtTaxa.Text = dSBoletos.tbl_Mes.Rows[0]["Taxa_pos_venc"].ToString();
                DataVencimento.Value= Convert.ToDateTime(dSBoletos.tbl_Mes.Rows[0]["data_venc"].ToString()).Date;
                habilitaTudo();
                
            }
            catch(Exception erro)
            {
                evacuar();
                MessageBox.Show(erro.ToString());
            }
        }
        private void FrmBoletos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDcaixaDataSet1.tbl_Mensalidade' table. You can move, or remove it, as needed.
            
            //this.tbl_MesTableAdapter.Fill(this.dSBoletos.tbl_Mes);
            CBCod.SelectedIndex= 0;
            desabilitaTudo();


        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            _validaCod();
        }
        private void evacuar()
        {
            txtCod.Clear();
            desabilitaTudo();
            limpaTudo();
        }
        private void limpaTudo()
        {
            txtpai.Clear();
            txtmae.Clear();
            txtmeses.Clear();
            txtminimo.Clear();
            txtValor.Clear();
            txtboleto.Clear();
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                indice_dt_mensalidade = e.RowIndex;
                id_mensalidade = Convert.ToInt32(dtMensalidade.Rows[e.RowIndex].Cells["id_meses"].Value.ToString());
                txtmeses.Text = dtMensalidade.Rows[e.RowIndex].Cells["meses"].Value.ToString();
                date.Value = Convert.ToDateTime(dtMensalidade.Rows[e.RowIndex].Cells["data"].Value.ToString()).Date;
                txtValor.Text = Convert.ToDouble(dtMensalidade.Rows[e.RowIndex].Cells["valor"].Value.ToString()).ToString("N");
                DataVencimento.Value = Convert.ToDateTime(dtMensalidade.Rows[e.RowIndex].Cells["Data_venc"].Value.ToString());
                date.Focus();
            }
        }
        private void desabilitaTudo()
        {
            //txtboleto.Enabled = false;
            //txtminimo.Enabled = false;
            tbnSalvar.Enabled = false;
            //txtboleto.Focus();
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
            btnLancar.Enabled = false;
        }
        private void habilitaTudo()
        {
            //txtboleto.Enabled = true;
            //txtminimo.Enabled = true;
            //tbnSalvar.Enabled = true;
            //txtboleto.Focus();
            btnAtualizar.Enabled = true;
            btnDeletar.Enabled = true;
            btnLancar.Enabled = true;
        }
        private void hambienteAtualiza()
        {
            txtboleto.Enabled = true;
            txtminimo.Enabled = true;
            tbnSalvar.Enabled = true;
            txtTaxa.Enabled = true;
            DataVencimento.Enabled = true;
            txtboleto.Focus();
            btnAtualizar.Enabled = false;
            btnDeletar.Enabled = false;
            btnLancar.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            hambienteAtualiza();
        }

        private void tbnSalvar_Click(object sender, EventArgs e)
        {
            habilitaTudo();
            txtboleto.Enabled = false;
            txtminimo.Enabled = false;
            tbnSalvar.Enabled = false;
            txtTaxa.Enabled = false;
            DataVencimento.Enabled = false;
            try
            {
                AtualizaBoleto(txtboleto.Text, Convert.ToDouble(txtminimo.Text), id_Cliente, DataVencimento.Value.Date, txtTaxa.Text == "" ? 0 : Convert.ToDouble(txtTaxa.Text));
                AtualizaBoleto(id_mensalidade, DataVencimento.Value.Date);
                textBox3_Validated(null, null);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
                textBox3_Validated(null, null);
            }
            
        }
        private void AtualizaBoleto(string cb, double parcela, int id, DateTime Data_vencimento, double taxa = 0)
        {
            StringBuilder str = new StringBuilder();
            str.Append("update tbl_mes set cb = @cb" );
            str.AppendLine(", parcela_min = @parcela");
            str.AppendLine(", Taxa_pos_venc = @taxa");
            //str.AppendLine(", Data_venc = @data");
            str.AppendLine("where id_Cliente = @id");
            SqlConnection con = new SqlConnection(StatusDoCaixa.conStringBDAtaFinal);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = str.ToString();
            cmd.Parameters.AddWithValue("@cb", cb);
            cmd.Parameters.AddWithValue("@parcela", parcela);
            cmd.Parameters.AddWithValue("@taxa", taxa);
            //cmd.Parameters.AddWithValue("@data", Data_vencimento);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            

        }
        private void AtualizaBoleto( int id_mes, DateTime Data_vencimento)
        {
            StringBuilder str = new StringBuilder();
            str.Append("update tbl_mes set ");
            //str.AppendLine(", parcela_min = @parcela");
            //str.AppendLine(", Taxa_pos_venc = @taxa");
            str.AppendLine("Data_venc = @data");
            str.AppendLine("where id_meses = @id");
            SqlConnection con = new SqlConnection(StatusDoCaixa.conStringBDAtaFinal);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = str.ToString();
            //cmd.Parameters.AddWithValue("@cb", cb);
            //cmd.Parameters.AddWithValue("@parcela", parcela);
            //cmd.Parameters.AddWithValue("@taxa", taxa);
            cmd.Parameters.AddWithValue("@data", Data_vencimento);
            cmd.Parameters.AddWithValue("@id", id_mes);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show(id_mensalidade + " " + id_mes);



        }
        
        private void _AtualizaVencimentos( int id, DateTime vencimento)
        {
            StringBuilder str = new StringBuilder();
            str.Append("update tbl_mes set ");
            
            str.AppendLine(", Data_venc = @venc");

            str.AppendLine("where id_meses = @id");
            SqlConnection con = new SqlConnection(StatusDoCaixa.conStringBDAtaFinal);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = str.ToString();
            
            cmd.Parameters.AddWithValue("@venc", vencimento);

            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }
        
        private void AtualizaBoleto(double parcela, int id, DateTime tempo, DateTime vencimento)
        {
            StringBuilder str = new StringBuilder();
            str.Append("update tbl_mes set valor = @parcela" );
            str.AppendLine(", data = @data");
            str.AppendLine(", data_venc = @vencimento");
            str.AppendLine("where id_meses = @id" );
            SqlConnection con = new SqlConnection(StatusDoCaixa.conStringBDAtaFinal);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = str.ToString();
            cmd.Parameters.AddWithValue("@parcela", parcela);
            cmd.Parameters.AddWithValue("@data", tempo.Date);
            cmd.Parameters.AddWithValue("@vencimento", vencimento);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            
            try
            {
                double valor = Convert.ToDouble(dtMensalidade.Rows[indice_dt_mensalidade].Cells["valor"].Value.ToString());
                if (valor > 0)
                {
                    if (MessageBox.Show("O valor de " + txtmeses.Text + " é maior que 0\nTem certeza que deseja continuar?", "O Valor não é 0", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        AtualizaBoleto(Convert.ToDouble(txtValor.Text), id_mensalidade,date.Value.Date, DataVencimento.Value);
                        dtMensalidade.Rows[indice_dt_mensalidade].Cells["valor"].Value = Convert.ToDouble(txtValor.Text).ToString("N");
                        dtMensalidade.Rows[indice_dt_mensalidade].Cells["data"].Value = date.Value.Date;
                        _insertHistorico(id_Cliente + "", date.Value.Date, "Indisp...", "Indisp...", txtmeses.Text, txtAno.Text, "Boleto", Convert.ToDouble(txtValor.Text));
                        tbl_MensalidadeTableAdapter.Fill_cliente(bDcaixaDataSet.tbl_Mensalidade, id_Cliente, txtAno.Text);
                        MessageBox.Show("lançado com sucesso");
                    }
                    else
                    {

                        return;
                    }
                }
                else
                {
                    AtualizaBoleto(Convert.ToDouble(txtValor.Text), id_mensalidade,date.Value.Date, DataVencimento.Value);
                    dtMensalidade.Rows[indice_dt_mensalidade].Cells["valor"].Value = Convert.ToDouble(txtValor.Text).ToString("N");
                    dtMensalidade.Rows[indice_dt_mensalidade].Cells["data"].Value = date.Value.Date;
                    _insertHistorico(id_Cliente + "", date.Value.Date, "Indisp...", "Indisp...", txtmeses.Text, txtAno.Text, "Boleto", Convert.ToDouble(txtValor.Text));
                    tbl_MensalidadeTableAdapter.Fill_cliente(bDcaixaDataSet.tbl_Mensalidade, id_Cliente, txtAno.Text);
                    MessageBox.Show("lançado com sucesso");
                }

                
                
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
                textBox3_Validated(null, null);
            }
        }

       

        

        private void txtTaxa_Validated(object sender, EventArgs e)
        {
            try
            {
                double val = Convert.ToDouble(txtTaxa.Text);
                txtTaxa.Text = val.ToString("N");
            }
            catch
            {
                txtTaxa.Text = "0,00";
            }
        }

        private void DataVencimento_Validated(object sender, EventArgs e)
        {
            
        }

       

        

       
    }
}
