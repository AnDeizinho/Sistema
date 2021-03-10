using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaSimples
{
    public partial class imprimi : frmFormulario
    {
        DataSet tabelas = new DataSet();

        public imprimi()
        {
            
            InitializeComponent();

        }

        private void imprimi_Load(object sender, EventArgs e)
        {
            

        }

        private void tbl_MensalidadeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void imprimi_Load_1(object sender, EventArgs e)
        {
            
            this.tbl_MensalidadeTableAdapter.Fill(this.bDcaixaDataSet.tbl_Mensalidade, StatusDoCaixa.data.Date, StatusDoCaixa.data.Date.AddDays(1));
            // TODO: This line of code loads data into the 'DataSource.tbl_Mensalidade' table. You can move, or remove it, as needed.
            //this.tbl_MensalidadeTableAdapter.Fill(this.DataSource.tbl_Mensalidade, StatusDoCaixa.data.Date, StatusDoCaixa.data.Date.AddDays(1));
            // TODO: This line of code loads data into the 'DataSource.tblResumo_De_Caixas' table. You can move, or remove it, as needed.
            this.tblResumo_De_CaixasTableAdapter.Fill(this.DataSource.tblResumo_De_Caixas, StatusDoCaixa.data.Date);
            // TODO: This line of code loads data into the 'DataSource.tblProdutos' table. You can move, or remove it, as needed.
            this.tblProdutosTableAdapter.Fill(this.DataSource.tblProdutos, StatusDoCaixa.data.Date, StatusDoCaixa.data.Date.AddDays(1));
            // TODO: This line of code loads data into the 'DataSource.tblSaida' table. You can move, or remove it, as needed.
            this.tblSaidaTableAdapter.Fill(this.DataSource.tblSaida, StatusDoCaixa.data.Date, StatusDoCaixa.data.Date.AddDays(1));
            // TODO: This line of code loads data into the 'DataSource.tblDeposito' table. You can move, or remove it, as needed.
            this.tblDepositoTableAdapter.Fill(this.DataSource.tblDeposito, StatusDoCaixa.data.Date, StatusDoCaixa.data.Date.AddDays(1));
            // TODO: This line of code loads data into the 'DataSource.tblSaida' table. You can move, or remove it, as needed.
            
           

            reportar.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportar.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportar.ZoomPercent = 100;
            // TODO: This line of code loads data into the 'dataSource.tblDeposito' table. You can move, or remove it, as needed.
            //this.tblDepositoTableAdapter.Fill(this.dataSource.tblDeposito, StatusDoCaixa.data.Date, StatusDoCaixa.data.Date.AddDays(1));
            // TODO: This line of code loads data into the 'dataSource.tblProdutos' table. You can move, or remove it, as needed.
            //this.tblProdutosTableAdapter.Fill(this.dataSource.tblProdutos, StatusDoCaixa.data.Date, StatusDoCaixa.data.Date.AddDays(1));
            // TODO: This line of code loads data into the 'dataSource.tblSaida' table. You can move, or remove it, as needed.
            //this.tblSaidaTableAdapter.Fill(this.dataSource.tblSaida, StatusDoCaixa.data.Date, StatusDoCaixa.data.Date.AddDays(1));
            this.reportar.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data", StatusDoCaixa.vardata));
            this.reportar.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dinheiro", StatusDoCaixa.vardinheiro));
            this.reportar.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("saida", StatusDoCaixa.varsaida));
            this.reportar.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("debito", StatusDoCaixa.vardebito));
            this.reportar.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("credito", StatusDoCaixa.varcredito));
            this.reportar.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ttcartao", StatusDoCaixa.varcartao));
            this.reportar.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ttentrada", StatusDoCaixa.varentrada));
            this.reportar.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ttprodutos", StatusDoCaixa.varproduto));
            this.reportar.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ttespecie", StatusDoCaixa.varespecie));
            this.reportar.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fdCaixa", StatusDoCaixa.varcaixa));
            this.reportar.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ttDeposito", StatusDoCaixa.vardeposito));
            this.reportar.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("vApresentado", StatusDoCaixa.varapresentado));

            this.reportar.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("conclusao", StatusDoCaixa.varconclusao));
            //this.tbl_MensalidadeTableAdapter.Adapter.SelectCommand.CommandText = "Select * from tbl_Mensalidade where Data >= '" + StatusDoCaixa.data.Date.ToString() + "' and Data < '" + StatusDoCaixa.data.Date.AddDays(1).ToString() + "'";
            //this.tbl_MensalidadeTableAdapter.Adapter.;
            // TODO: This line of code loads data into the 'dataSource.tbl_Mensalidade' table. You can move, or remove it, as needed.
            //this.tbl_MensalidadeTableAdapter.Fill(this.dataSource.tbl_Mensalidade,StatusDoCaixa.data.Date, StatusDoCaixa.data.Date.AddDays(1));
            // TODO: This line of code loads data into the 'dataSource.tblResumo_De_Caixas' table. You can move, or remove it, as needed.
            //this.tblResumo_De_CaixasTableAdapter.Fill(this.dataSource.tblResumo_De_Caixas, StatusDoCaixa.data.Date);


            this.reportar.RefreshReport();
        }
    }
}
