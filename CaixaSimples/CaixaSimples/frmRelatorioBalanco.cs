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
    public partial class frmRelatorioBalanco : frmFormulario
    {
        string[] Parametros;
        public frmRelatorioBalanco(string [] parametros)
        {
            Parametros = parametros;
            InitializeComponent();
        }

        private void frmRelatorioBalanco_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dtInicio", Parametros[0]));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dtfinal", Parametros[1]));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dinheiro", Parametros[2]));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("saidas", Parametros[3]));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("debito", Parametros[4]));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("credito", Parametros[5]));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ttcartao", Parametros[6]));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ttentradas", Parametros[7]));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ttespecie", Parametros[8]));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fundo", Parametros[9]));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ttprodutos", Parametros[10]));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ttdeposito", Parametros[11]));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("apresentado", Parametros[12]));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("conclusao", Parametros[13]));
            
            // TODO: This line of code loads data into the 'DataSource.tblResumo_De_Caixas' table. You can move, or remove it, as needed.
            this.tblResumo_De_CaixasTableAdapter.FillBalanco(this.DataSource.tblResumo_De_Caixas, Convert.ToDateTime(Parametros[0]).Date, Convert.ToDateTime(Parametros[1]).Date);

            this.reportViewer1.RefreshReport();
        }
    }
}
