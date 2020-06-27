using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaSimples
{
    enum meses { JANEIRO = 1, FEVEREIRO = 2, MARÇO, ABRIL, MAIO, JUNHO, JULHO, AGOSTO, SETEMBRO, OUTUBRO, NOVEMBRO, DEZEMBRO }
    public partial class frmDevedores : frmFormulario
    {
        //string Mes = "";
        string Ano = "";
        
        meses come = meses.JANEIRO;
        meses fina = meses.JANEIRO;
        public frmDevedores(string ano)
        {
            
            Ano = ano;
            InitializeComponent();
        }
        private string concat(meses inicio, meses final, string esteAno)
        {
            StringBuilder biu = new StringBuilder();
            biu.Append("SELECT        tbl_Mes.cb, tbl_cliente.Pai, tbl_cliente.mae, tbl_cliente.fone_pai, tbl_cliente.fone_mae, tbl_cliente.filhos, tbl_mes.meses , tbl_Mes.Data, tbl_Mes.Valor ");
            biu.Append("FROM            tbl_cliente JOIN tbl_Mes ON tbl_cliente.id_cliente = tbl_Mes.id_Cliente  ");
            
            biu.Append("WHERE        tbl_cliente.filhos > 0  AND tbl_Mes.ANO ='" + esteAno + "' AND tbl_Mes.Valor = 0 ");
            meses primeirarodada = inicio;
            while (inicio <= final)
            {
                if (inicio > primeirarodada)
                {
                    biu.Append(" or tbl_cliente.filhos > 0  AND tbl_Mes.ANO ='" + esteAno + "' AND tbl_Mes.Valor = 0 and tbl_Mes.Meses = '" + inicio.ToString() + "' ");
                }
                biu.Append(" AND tbl_Mes.Meses = '" + inicio.ToString() + "' ");
                inicio++;
            }
            
            biu.Append("ORDER BY tbl_Mes.cb");
            
            return biu.ToString();
        }
        private void frmDevedores_Load(object sender, EventArgs e)
        {
            cbInicio.SelectedIndex = 1;
            cbFinal.SelectedIndex = 1;
            
        }

        private void cbInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            come = meses.JANEIRO;
            come = come + cbInicio.SelectedIndex - 1;
        }

        private void cbFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            fina = meses.JANEIRO;
            fina += cbFinal.SelectedIndex -1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (cbInicio.SelectedIndex == 0 || cbFinal.SelectedIndex == 0)
            {
                cbInicio.Focus();
                return;
            }

            if (cbFinal.SelectedIndex < cbInicio.SelectedIndex)
            {
                cbInicio.Focus();
                return;
            }


            this.reportViewer1.Clear();
            BDDevedores.tbl_cliente.Clear();
            
            int linhas = 0;

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mes", cbInicio.Text));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mesFinal", cbFinal.Text));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ano", Ano));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data", DateTime.Now.Date.ToString("dd/MM/yyyy")));
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            //string periodo = "";
            //mesIndex++;
            //if (mesIndex <= 9)
            //{
                //periodo = "0" + mesIndex;
            //}
            //else
            //{
                //periodo = "" + mesIndex;
            //}
            // TODO: This line of code loads data into the 'BDDevedores.tbl_cliente' table. You can move, or remove it, as needed.


            SqlDataAdapter adapt = new SqlDataAdapter(concat(come, fina, Ano), StatusDoCaixa.conStringBDAtaFinal);
            adapt.Fill(this.BDDevedores.tbl_cliente);
            linhas = this.BDDevedores.tbl_cliente.Rows.Count;
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("n", "" + linhas));
            this.reportViewer1.RefreshReport();
        }
    }
}
