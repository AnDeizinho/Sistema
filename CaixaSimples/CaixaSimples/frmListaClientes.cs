using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CaixaSimples
{
    public partial class frmListaClientes : Form
    {
        
        SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDAtaFinal);
        SqlDataAdapter atp;
        DataTable tbl;
        DataTable tblTurma = new DataTable();
        
       
        string str = @"SELECT TOP 1000 tbl_Cliente.[id_cliente] 
      ,[Pai]
      ,[mae]
      ,[cpf_pai]
      ,[cpf_mae]
      ,[fone_pai]
      ,[fone_mae]
      ,[endereco]
      ,[numero]
      ,[bairro]
      ,[complemento]
      ,[cidade]
      ,[estado]
      ,[cep]
      ,data
      ,Meses
      ,filhos
      ,Valor
      ,CB
  FROM [BDAtaFinal].[dbo].[tbl_cliente] 
  
  join BDAtaFinal.dbo.tbl_Mes on tbl_cliente.id_cliente = tbl_Mes.id_Cliente
  
  where ANO = '";

        private string strComando(string ano, string mes)
        {
            string mesDaData = "";
            if (cb.SelectedIndex <= 9)
            {
                mesDaData = "0" + cb.SelectedIndex;
            }
            else
            {
                mesDaData = "" + cb.SelectedIndex;
            }
            string strFinal = @"'
            
  order by Valor, pai";
            return str + ano + "' and Meses = '" + mes +  strFinal;
            
        }
        
        public frmListaClientes()
        {
            InitializeComponent();
            
            dt.Columns[0].Width = 35;
            dt.Columns[1].Width = 35;
            dt.Columns[2].Width = 230;
            dt.Columns[3].Width = 230;
            dt.Columns[4].Width = 2;
            dt.Columns[5].Width = 2;
            dt.Columns[6].Width = 2;
            dt.Columns[7].Width = 2;
            dt.Columns[8].Width = 2;
            dt.Columns[9].Width = 2;
            dt.Columns[10].Width = 2;
            dt.Columns[11].Width = 2;
            dt.Columns[12].Width = 2;
            dt.Columns[13].Width = 2;
            dt.Columns[14].Width = 2;
            dt.Columns[15].Width = 100;
            dt.Columns[16].Width = 100;
            dt.Columns[17].Width = 50;
            dt.Columns[18].Width = 50;

            cb.SelectedIndex = Convert.ToInt32(DateTime.Now.Month);
            cbCod.SelectedIndex = 0;
            
            
        }
        private void contador()
        {
            

            
                double total = 0;
                
                foreach (DataGridViewRow linha in dt.Rows)
                {
                    total += Convert.ToDouble(linha.Cells["clmValor"].Value.ToString());
                }
                
            
            lbl.Text = "Quantidade = " + dt.Rows.Count +" | " + cb.Text + " = " + total.ToString("C"); ;
        }
        private DataTable Carrega_tbl(string com, SqlConnection con)
        {
            SqlCommand comando = new SqlCommand(com, con);
            atp = new SqlDataAdapter(comando);
            atp.Fill(tbl = new DataTable());
            return tbl;
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            string strcomado = strComando(txtano.Text, cb.Text);
            
            tbl = Carrega_tbl(strcomado, conexao);
                
            
            dt.DataSource = tbl;
            
            
            cbCod_Validated(null, null);
            cbResp.SelectedIndex = 0;
            
            
            
            
        }

        private void textBox1_Validating(object sender, KeyEventArgs e)
        {
            /*
            
            if (txtnome.Text != "" & e.KeyValue == 13)
            {
                string str3 = "where ano_recente = '" + txtano.Text + "' and nome like '%" + txtnome.Text + "%' order by tbl_turma.descricao , nome";
                SqlCommand comando = new SqlCommand(str + str3, conexao);
                atp = new SqlDataAdapter(comando);
                atp.Fill(tbl = new DataTable());
                dt.DataSource = tbl;
            }

            else if (txtnome.Text == "" & e.KeyValue == 13)
            {
                string str2 = "where ano_recente = '" + txtano.Text + "' order by tbl_turma.descricao , nome";
                SqlCommand comando = new SqlCommand(str + str2, conexao);
                atp = new SqlDataAdapter(comando);
                atp.Fill(tbl = new DataTable());
                dt.DataSource = tbl;
            }*/
        }

        private void txtnome_Validating(object sender, CancelEventArgs e)
        {
            /*if (txtnome.Text != "" )
            {
                string str3 = "where ano_recente = '" + txtano.Text + "' and nome like '%" + txtnome.Text + "%' order by tbl_turma.descricao , nome";
                SqlCommand comando = new SqlCommand(str + str3, conexao);
                atp = new SqlDataAdapter(comando);
                atp.Fill(tbl = new DataTable());
                dt.DataSource = tbl;
            }

            else if (txtnome.Text == "" )
            {
                string str2 = "where ano_recente = '" + txtano.Text + "' order by tbl_turma.descricao , nome";
                SqlCommand comando = new SqlCommand(str + str2, conexao);
                atp = new SqlDataAdapter(comando);
                atp.Fill(tbl = new DataTable());
                dt.DataSource = tbl;
            }*/
        }

        private void cb_Validated(object sender, EventArgs e)
        {
            if(cb.SelectedIndex == 0)
            {
                cb.Focus();
            }
        }

        private void cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb.SelectedIndex > 0)
            {
                Form1_Load(null, null);
                contador();
            }
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            string resp = "";
            if (cbResp.SelectedIndex == 0)
            {
                resp = "pai";
            }
            else
            {
                resp = "mae";
            }
            if (txtnome.Text != "")
            {
                string str3 = txtano.Text + "' and " + resp + " like '%" + txtnome.Text + "%' and meses = '" + cb.Text + "' order by Valor , " + resp;
                
                    
                    SqlCommand comando = new SqlCommand(str + str3, conexao);
                    SqlDataAdapter atp2 = new SqlDataAdapter(comando);
                    
                    atp2.Fill(tbl = new DataTable());
                    
                    
                
                dt.DataSource = tbl;
            }

            else if (txtnome.Text == "")
            {
                string str2 = txtano.Text + "'  and meses = '" + cb.Text + "' order by Valor ," + resp;
                
                    
                    SqlCommand comando = new SqlCommand(str + str2, conexao);
                    SqlDataAdapter atp2 = new SqlDataAdapter(comando);

                atp2.Fill(tbl = new DataTable());
                 
                
                dt.DataSource = tbl;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtCC_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtCC_TextChanged(object sender, EventArgs e)
        {
            if (txtCC.Text != "")
            {
                try
                {
                    string strFinal = @"
  
  order by Valor, pai";
                     
                    
                    SqlCommand comando = new SqlCommand(str + txtano.Text + "' and Meses = '" + cb.Text + "' and tbl_cliente.id_cliente = " + txtCC.Text + strFinal, conexao);
                    atp = new SqlDataAdapter(comando);
                    atp.Fill(tbl = new DataTable());
                    dt.DataSource = tbl;
                    
                }
                catch
                {
                    MessageBox.Show("Digite somente números\n");
                    txtCC.Text = "";
                }
            }
            else
            {
                try
                {
                    cb_SelectedValueChanged(null, null);
                }
                catch
                {
                    MessageBox.Show("Erro ao exibir lista");
                    txtCC.Text = "";
                
                }
            }
            
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
            {
                txtCod.Focus();
                return;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtCod.Text);
                }catch
                {
                    txtCod.Focus();
                    return;
                }
            }
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                conexao.Open();
                comando.Parameters.AddWithValue("@mes", cb.Text);
                comando.Parameters.AddWithValue("@ano", txtano.Text);
                comando.Parameters.AddWithValue("@data", dtData.Value.Date);
                comando.Parameters.AddWithValue("@Valor", Convert.ToDouble(txtValor.Text));
                comando.Parameters.AddWithValue("@codigo", Convert.ToInt32(txtCod.Text));
                comando.CommandText = "update tbl_mes set data = @data, valor = @valor where ANO = @ano and Meses = @mes and " + coluna + " = @codigo";
                comando.ExecuteNonQuery();
                conexao.Close();
                //txtCod_TextChanged(null, null);
                //Form1_Load(null, null);
                MessageBox.Show("Sucesso na operação");
                txtCod_TextChanged(null, null);
                dtData.Value = DateTime.Now.Date;
                txtCod.Focus();
                txtCod.Text = "";
                txtValor.Text = "0,00";
            }
            catch
            {
                MessageBox.Show("Erro na operação");
            }

            
        }

        private void txtCod_Validated(object sender, EventArgs e)
        {
            try
            {
                if (txtCod.Text != "")
                {
                    int id = Convert.ToInt32(txtCod.Text);
                    if (id == 0)
                    {
                        
                        cb.Focus();
                        return;
                    }

                    SqlCommand comando = new SqlCommand("select id_Cliente from tbl_mes where " + coluna + " = " + id, conexao);
                    atp = new SqlDataAdapter(comando);
                    tbl = new DataTable();
                    atp.Fill(tbl);
                    if (tbl.Rows.Count == 0)
                    {
                        MessageBox.Show(cbCod.Text + " invalido");
                        
                        txtCod.Text = "";
                        return;
                    }
                    else
                    {
                        SqlCommand cmd2 = new SqlCommand("select id_aluno from tbl_Alunos where id_Cliente = " + tbl.Rows[0][0].ToString(), conexao);
                        SqlDataAdapter atp2 = new SqlDataAdapter(cmd2);
                        DataTable tbl2 = new DataTable();
                        atp2.Fill(tbl2);
                        if (tbl2.Rows.Count == 1)
                        {
                            txtValor.Text = "285,00";
                        }
                        else if (tbl2.Rows.Count == 2)
                        {
                            txtValor.Text = "490,00";
                        }
                        else if (tbl2.Rows.Count == 3)
                        {
                            txtValor.Text = "640,00";
                        }
                    }

                }
                else
                {
                    
                    txtCod.Text = "";
                }
                   
                
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
                txtCod.Text = "";
                
            }
        }
        
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtValor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
            
        }

        private void txtValor_Validated(object sender, EventArgs e)
        {
            try
            {
                txtValor.Text = Convert.ToDouble(txtValor.Text).ToString("N");
                
                
            }
            catch
            {
                txtValor.Text = "";
                txtValor.Focus();
                
            }
        }
        string coluna = "";
        private void cbCod_Validated(object sender, EventArgs e)
        {
            if(cbCod.SelectedIndex == 0)
            {
                coluna = "id_Cliente";
            }else if(cbCod.SelectedIndex == 1)
            {
                coluna = "cb";
            }
        }

        private void dt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            if (e.RowIndex >= 0)
            {
                txtCodAltera.Focus();
                txtCodAltera.Text = dt.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCBAltera.Text = dt.Rows[e.RowIndex].Cells["clmCB"] .Value.ToString();
                txtNomePai.Text = dt.Rows[e.RowIndex].Cells["clmNomePai"].Value.ToString();
                txtNomeMae.Text = dt.Rows[e.RowIndex].Cells["clmnomeMae"].Value.ToString();
                txtFonePai.Text = dt.Rows[e.RowIndex].Cells["clmFonePai"].Value.ToString();
                txtFoneMae.Text = dt.Rows[e.RowIndex].Cells["clmFoneMae"].Value.ToString();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtCodAltera.Text != "")
            {
                int codigoParaAlterar = 0;
                int codigoBoleto = 0;
                try
                {
                    codigoParaAlterar = Convert.ToInt32(txtCodAltera.Text);
                    codigoBoleto = Convert.ToInt32(txtCBAltera.Text);
                }
                catch
                {
                    codigoParaAlterar = 0;
                    codigoBoleto = 0;
                    txtCodAltera.Focus();
                    txtCodAltera.Text = "";
                    txtCBAltera.Text = "";
                    txtNomePai.Text = "";
                    txtNomeMae.Text = "";
                    txtFonePai.Text = "";
                    txtFoneMae.Text = "";
                    txtCodAltera.Focus();
                    return;
                }

                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexao;
                    conexao.Open();
                    comando.Parameters.AddWithValue("@id", codigoParaAlterar);
                    comando.Parameters.AddWithValue("@CB", codigoBoleto);
                    comando.Parameters.AddWithValue("@pai", txtNomePai.Text);
                    comando.Parameters.AddWithValue("@mae", txtNomeMae.Text);
                    comando.Parameters.AddWithValue("@fonePai", txtFonePai.Text);
                    comando.Parameters.AddWithValue("@foneMae", txtFoneMae.Text);
                    comando.CommandText = "update tbl_Cliente set pai = @pai, mae = @mae, fone_pai = @fonePai, fone_mae = @foneMae where id_Cliente = @id";
                    comando.ExecuteNonQuery();
                    comando.CommandText = "update tbl_mes set cb = @CB where ano = '" + txtano.Text + "' and id_cliente = @id";
                    comando.ExecuteNonQuery();

                    

                    conexao.Close();

                    cb_SelectedValueChanged(null, null);
                    
                    MessageBox.Show("Atualizado Com Sucesso");
                    txtCodAltera.Text = "";
                    txtCBAltera.Text = "";
                    txtNomePai.Text = "";
                    txtNomeMae.Text = "";
                    txtFonePai.Text = "";
                    txtFoneMae.Text = "";
                    cb.Focus();
                }
                catch(Exception erro)
                {
                    MessageBox.Show("erro\n" + erro.ToString());
                    txtCodAltera.Text = "";
                    txtCBAltera.Text = "";
                    txtNomePai.Text = "";
                    txtNomeMae.Text = "";
                    txtFonePai.Text = "";
                    txtFoneMae.Text = "";
                    txtCodAltera.Focus();
                    return;
                }
            }
            else
            {
                txtCodAltera.Focus();
                return;
            }
        }

        private void txtCodAltera_Validated(object sender, EventArgs e)
        {
            int codigoParaAlterar = 0;
            
            try
            {
                codigoParaAlterar = Convert.ToInt32(txtCodAltera.Text);
                
                SqlCommand comando = new SqlCommand("select id_cliente from tbl_Cliente where id_cliente = " + codigoParaAlterar, conexao);
                SqlDataAdapter adapita = new SqlDataAdapter(comando);
                DataTable verifica = new DataTable();
                adapita.Fill(verifica);
                if (verifica.Rows.Count == 0)
                {
                    MessageBox.Show("Codigo Invalido");
                    codigoParaAlterar = 0;
                    
                    txtCodAltera.Focus();
                    txtCodAltera.Text = "";
                    txtCBAltera.Text = "";
                    txtNomePai.Text = "";
                    txtNomeMae.Text = "";
                    txtFonePai.Text = "";
                    txtFoneMae.Text = "";
                    txtCodAltera.Focus();
                    return;
                }
            }
            catch
            {
                
                codigoParaAlterar = 0;
                
                txtCodAltera.Focus();
                txtCodAltera.Text = "";
                txtCBAltera.Text = "";
                txtNomePai.Text = "";
                txtNomeMae.Text = "";
                txtFonePai.Text = "";
                txtFoneMae.Text = "";
                txtCodAltera.Focus();
                cb.Focus();
                return;
            }
        }
        private string strEntradaAvulsa(string ano, string mes, string cod)
        {
            string strFinal = @"
  
  order by Valor, pai";
            return str + ano + "' and Meses = '" + mes + "' and tbl_Cliente.id_cliente = " + cod + strFinal;

        }
        private string buscarPorBoleto(string ano, string mes, string cod)
        {
            string strFinal = " order by valor, pai";

            return str + ano + "' and Meses = '" + mes + "' and cb = " + cod + strFinal;
        }
        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {
                try
                {
                    Convert.ToInt32(txtCod.Text);
                }
                catch
                {
                    txtCod.Text = "";
                    return;
                }

                switch (cbCod.SelectedIndex)
                {
                    case 0:
                        atp = new SqlDataAdapter(strEntradaAvulsa(txtano.Text, cb.Text, txtCod.Text), conexao);
                        tbl = new DataTable();
                        atp.Fill(tbl);
                        dt.DataSource = tbl;
                        break;
                    case 1:
                        atp = new SqlDataAdapter(buscarPorBoleto(txtano.Text, cb.Text, txtCod.Text), conexao);
                        tbl = new DataTable();
                        atp.Fill(tbl);
                        dt.DataSource = tbl;
                        break;
                }
            }
            contador();


        

        }

        private void dt_DataSourceChanged(object sender, EventArgs e)
        {
            contador();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmDevedores dev = new frmDevedores( txtano.Text);
            dev.ShowDialog();
        }

        
        
    }
}
