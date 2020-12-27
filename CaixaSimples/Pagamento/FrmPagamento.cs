using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaShekinahCompleto.Model;
namespace CaixaSimples.Pagamento
{
    public partial class frmPagamento : Form
    {
        public InfoPag Info { get; set; }
        public DataTable Tbl_Mensalidade { get; set; }
        public DataTable Tbl_Historico { get; set; }
        DbCliente bd = new DbCliente();
        public frmPagamento(InfoPag inf)
        {
            Info = inf;
            InitializeComponent();
            
            dt_ano.DataSource = bd.Select(string.Format("SELECT COUNT(Ano) as mensalidades,[ANO]FROM [tbl_Mes] where id_Cliente = {0} group by Ano", Info.Id_cliente));

            
        }

        private void dt_ano_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Info.AnoContrato = dt_ano.Rows[e.RowIndex].Cells["ANO"].Value.ToString().Trim();
            string cmd = string.Format("select meses, valor from tbl_mes where id_cliente = {0} and ano = '{1}'", Info.Id_cliente, Info.AnoContrato);
            Tbl_Mensalidade = bd.Select(cmd);
            Tbl_Historico = bd.Select(string.Format("select Id_Cliente, Data, Mes, Forma_pagamento, Valor from BDCaixa.DBO.tbl_Mensalidade where id_Cliente = {0} and Ano = '{1}'", Info.Id_cliente, Info.AnoContrato));
            this.Close();
        }

       
        

        
    }
}
