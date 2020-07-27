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
using SistemaShekinahCompleto.Model;
using SistemaShekinahCompleto.DAO;
using SistemaShekinahCompleto.Entidades;
namespace CaixaSimples
{
    public partial class frmPesquisaAlunos : Form
    {
        SqlConnection conexao = new Conexao().NovaConexaoBdAtaFinal();
        SqlDataAdapter atp;
        DataTable tbl;
        DataTable tblturma = new DataTable();
        string str = @"SELECT tbl_Alunos.[id_aluno]
	  ,tbl_alunos.id_cliente 
      ,[nome]
      ,[id_mac]
      ,tbl_turma.descricao
      ,tbl_cliente.fone_pai
      ,tbl_cliente.fone_mae
      ,[nascimento]
      ,[sexo]
      ,[naturalidade]
      ,[uf]
      ,[dadosClinicos]
      ,[remedios]
      ,[ano_recente]
      ,integral

  FROM [BDAtaFinal].[dbo].[tbl_Alunos] 
  
  join BDAtaFinal.dbo.tbl_turma 
  on tbl_alunos.id_turma = tbl_turma.id_turma
  
  join BDAtaFinal.dbo.tbl_cliente 
  on tbl_Alunos.id_cliente = tbl_cliente.id_cliente 
  
  
  ";
        void DefColunas()
        {
            dt.Columns[0].Width = 35;
            dt.Columns[1].Width = 35;
            dt.Columns[2].Width = 250;
            dt.Columns[3].Width = 100;
            dt.Columns[4].Width = 110;
            dt.Columns[5].Width = 100;
            dt.Columns[6].Width = 100;
            dt.Columns[7].Width = 70;
            dt.Columns[8].Width = 50;
            dt.Columns[10].Width = 35;
            dt.Columns[13].Width = 50;

            
        }
        void Carregamento()
        {

            cbNivel.SelectedIndex = 0;
            

            string str2 = string.Format("where tbl_turma.ano= '{0}' order by tbl_turma.descricao , nome", txtano.Text);
            SqlCommand comando = new SqlCommand(str + str2, conexao);
            atp = new SqlDataAdapter(comando);
            atp.Fill(tbl = new DataTable());
            dt.DataSource = tbl;
            lbl.Text = "Quantidade : " + dt.Rows.Count;
        }
        public frmPesquisaAlunos()
        {
            InitializeComponent();
            DefColunas();
            Carregamento();
            
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
            if (cb.SelectedIndex > 0)
            {
                string str2 = "where tbl_Alunos.id_turma = " + tblturma.Rows[cb.SelectedIndex - 1][0].ToString() + " and tbl_turma.ano = '" + txtano.Text + "' order by tbl_turma.descricao , nome";
                SqlCommand comando = new SqlCommand(str + str2, conexao);
                atp = new SqlDataAdapter(comando);
                atp.Fill(tbl = new DataTable());
                dt.DataSource = tbl;
                lbl.Text = "Quantidade = " + dt.RowCount;
            }
        }

        private void cb_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cb.SelectedIndex > 0)
            //{
            //    string str2 = "where tbl_Alunos.id_turma = " + ((TurmaEnt)cb.SelectedItem ).id_turma + " and ano_recente = '" + txtano.Text + "' order by tbl_turma.descricao , nome";
            //    SqlCommand comando = new SqlCommand(str + str2, conexao);
            //    atp = new SqlDataAdapter(comando);
            //    atp.Fill(tbl = new DataTable());
            //    dt.DataSource = tbl;
            //    lbl.Text = "Quantidade : " + dt.Rows.Count;
            //}
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            if (txtnome.Text != "")
            {
                string str3 = "where ano_recente = '" + txtano.Text + "' and nome like '%" + txtnome.Text + "%' order by tbl_turma.descricao , nome";
                SqlCommand comando = new SqlCommand(str + str3, conexao);
                atp = new SqlDataAdapter(comando);
                atp.Fill(tbl = new DataTable());
                dt.DataSource = tbl;
            }

            else if (txtnome.Text == "")
            {
                string str2 = "where ano_recente = '" + txtano.Text + "'  order by tbl_turma.descricao , nome";
                SqlCommand comando = new SqlCommand(str + str2, conexao);
                atp = new SqlDataAdapter(comando);
                atp.Fill(tbl = new DataTable());
                dt.DataSource = tbl;
            }
            lbl.Text = "Quantidade : " + dt.Rows.Count;
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
                    string str3 = "where ano_recente = '" + txtano.Text + "' and tbl_Alunos.id_cliente = " + txtCC.Text + " order by tbl_turma.descricao , nome";
                    SqlCommand comando = new SqlCommand(str + str3, conexao);
                    atp = new SqlDataAdapter(comando);
                    atp.Fill(tbl = new DataTable());
                    dt.DataSource = tbl;
                }
                catch
                {
                    MessageBox.Show("Digite somente números");
                    txtCC.Text = "";
                }
            }
            else
            {
                try
                {
                    string str2 = "where ano_recente = '" + txtano.Text + "' order by tbl_turma.descricao , nome";
                    SqlCommand comando = new SqlCommand(str + str2, conexao);
                    atp = new SqlDataAdapter(comando);
                    atp.Fill(tbl = new DataTable());
                    dt.DataSource = tbl;
                }
                catch
                {
                    MessageBox.Show("Erro ao exibir lista");
                    txtCC.Text = "";
                
                }
            }
            lbl.Text = "Quantidade : " + dt.Rows.Count;
        }

       
        private void cbNivel_Validated(object sender, EventArgs e)
        {
            cb.Items.Clear();
            tblturma.Clear();
            cb.Items.Add("Turma");
            cb.SelectedIndex = 0;
            atp = new SqlDataAdapter(string.Format("select id_turma, descricao from tbl_Turma a join tblano b on a.id_ano = b.id_ano where id_nivel = {0} and a.ano = {1}",
                (int)Enum.Parse(typeof(Niveis), cbNivel.Text), txtano.Text == "" ? int.Parse(DateTime.Now.Year.ToString()) : int.Parse(txtano.Text)), conexao);

            atp.Fill(tblturma);
            foreach (DataRow lin in tblturma.Rows)
            {
                cb.Items.Add(lin[1].ToString());
            }
            
        }
        
    }
}
