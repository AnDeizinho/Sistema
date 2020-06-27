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
    public partial class CHcontratoBoletofrm : frmFormulario
    {
        int Id_Cliente;
        DataTable bind;
        public CHcontratoBoletofrm(int id, DataTable bi)
        {
            bind = bi;
            Id_Cliente = id;
            InitializeComponent();
            
        }
        private void insere(string meses, string ano,DateTime data, double valorIntegral, int cb, double parcela_minima, DateTime vencimento, double taxa)
        {
            SqlCommand cmd = new SqlCommand(@"
                                                if(select count (0 ) from tbl_Mes where id_Cliente = @id and ano = @ano and meses = @meses) = 0
                                                INSERT INTO [dbo].[tbl_Mes]
                                                           ([id_Cliente]
                                                           ,[Meses]
                                                           ,[ANO]
                                                           ,[Data]
                                                           ,[Valor]
                                                           ,[cb]
                                                           ,[parcela_min]
                                                           ,[Data_venc]
                                                           ,[Taxa_pos_venc])
                                                     VALUES
                                                           (@id
                                                           ,@Meses
                                                           ,@ANO
                                                           ,@Data
                                                           ,@Valor
                                                           ,@cb
                                                           ,@parcela_min
                                                           ,@Data_venc
                                                           ,@Taxa_pos_venc)
		                                                else 
		                                                print ('já exite contrato para o ano selecionado')", new SistemaShekinahCompleto.Model.Conexao().NovaConexaoBdAtaFinal());
            try
            {
                
                cmd.Parameters.AddWithValue("@id", Id_Cliente);
                cmd.Parameters.AddWithValue("@Meses", meses);
                cmd.Parameters.AddWithValue("@ANO", ano);
                cmd.Parameters.AddWithValue("@Data", data.Date);
                cmd.Parameters.AddWithValue("@Valor", valorIntegral);
                cmd.Parameters.AddWithValue("@cb", cb);
                cmd.Parameters.AddWithValue("@parcela_min", parcela_minima);
                cmd.Parameters.AddWithValue("@Data_Venc", vencimento.Date);
                cmd.Parameters.AddWithValue("@Taxa_pos_venc", taxa);
                cmd.Connection.Open();
                

                if(cmd.ExecuteNonQuery() == -1)
                    throw new Exception("já existe contrado neste ano");
                cmd.Connection.Close();
            }
            catch (Exception Erro)
            {
                 throw Erro;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        private void CHcontratoBoletofrm_Load(object sender, EventArgs e)
        {
            CH.CheckOnClick = true;
            for (int i = 0; i < CH.Items.Count; i++)
            {
                CH.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool EvalidoString(TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool EvalidoInt(TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.Text = "0";
                return true;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txt.Text);
                    return true;
                }
                catch
                {
                    txt.Focus();
                    return false;
                }
            }
        }
        private bool EvalidoDouble(TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDouble(txt.Text);
                    return true;
                }
                catch
                {
                    txt.Focus();
                    return false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (EvalidoString(txtano) == false)
                return;
            if (EvalidoDouble(txtValor) == false)
                return;
            if (EvalidoInt(txtcb) == false)
                return;
            if (EvalidoDouble(txtminimo) == false)
                return;
            if (EvalidoDouble(txttaxa) == false)
                return;
            if (EvalidoInt(txtvencimento) == false)
                return;


            registra();
        }
        private void registra()
        {
            try
            {
                string ms = "";
                int iniciomes = CH.Items.Count - CH.CheckedItems.Count;
                DateTime vencimento = Convert.ToDateTime(txtvencimento.Text + "-01-" + txtano.Text);

                for (int i = 0; i < CH.CheckedItems.Count; i++)
                {
                    insere(CH.CheckedItems[i].ToString(), txtano.Text, DateTime.Now.Date, Convert.ToDouble(txtValor.Text), Convert.ToInt32(txtcb.Text), Convert.ToDouble(txtminimo.Text), vencimento.AddMonths(iniciomes + i).Date, Convert.ToDouble(txttaxa.Text));
                    //ms += CH.CheckedItems[i].ToString() + "  " + vencimento.AddMonths(i + iniciomes).Date.ToString() + "\n";
                }

                DataRow li = bind.NewRow();
                li[0] = CH.CheckedItems.Count;
                li[1] = txtano.Text;
                bind.Rows.Add(li);
                MessageBox.Show("cadastrados \n" + ms);
                this.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
