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
using SistemaShekinahCompleto.Entidades;
namespace CaixaSimples
{
    public partial class frmContratoBoleto : frmFormulario
    {
        int Id_Cliente;
        string Nome;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable ds = new DataTable();
        BindingSource bs = new BindingSource();
        public void carrega_lista_contrato()
        {

        }
        public frmContratoBoleto(ClienteEnt cli)
        {
            SqlConnection con = new SistemaShekinahCompleto.Model.Conexao().NovaConexaoBdAtaFinal();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.CommandText = @"SELECT 
      COUNT(Ano) as mensalidades
      ,[ANO]
      
      
	  FROM [tbl_Mes] where id_Cliente = @id
	  group by Ano";
            adp.SelectCommand.Connection = con;
            
            Id_Cliente = cli.id_cliente;
            Nome = cli.pai;
            adp.SelectCommand.Parameters.AddWithValue("@id", Id_Cliente);
            adp.Fill(ds);
            InitializeComponent();
            lblId.Text = "CC = " + Id_Cliente;
            lblNome.Text = Nome;
            bs.DataSource = ds;
            dtAnos.DataSource = bs;
           
        }

        private void frmContratoBoleto_Load(object sender, EventArgs e)
        {
            

        }

        private void dtAnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pn.Controls.Clear();
            if (e.RowIndex >= 0)
            {
                DSBoletosTableAdapters.tbl_MesTableAdapter adp = new DSBoletosTableAdapters.tbl_MesTableAdapter();
                adp.Connection = new SistemaShekinahCompleto.Model.Conexao().NovaConexaoBdAtaFinal();
                DSBoletos dt = new DSBoletos();
                adp.Fill(dt.tbl_Mes, dtAnos.Rows[e.RowIndex].Cells["ANO"].Value.ToString(), Id_Cliente);
                CHcontratoboletoDT ch = new CHcontratoboletoDT(dt);
                ch.TopLevel = false;
                ch.AutoScroll = true;
                pn.AutoScroll = true;
                pn.Controls.Add(ch);
                ch.Show();

            }
        }

        private void tbnNovo_Click(object sender, EventArgs e)
        {
            pn.Controls.Clear();
            CHcontratoBoletofrm fomr = new CHcontratoBoletofrm(Id_Cliente, ds);
            fomr.TopLevel = false;
            pn.Controls.Add(fomr);
            fomr.Show();
            
        }

        
    }
}
