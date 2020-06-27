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
    public partial class frmRelatorioMatricula : frmFormulario
    {
        int id_Aluno = 0;
        int id_Cliente = 0;
        public frmRelatorioMatricula(int idA, int idC)
        {
            id_Aluno = idA;
            id_Cliente = idC;
            InitializeComponent();
        }

        private void frmRelatorioMatricula_Load(object sender, EventArgs e)
        {
            DataTable tblCliente = new DataTable();
            DataTable tblAluno = new DataTable();

            DadosDeFichaMatricula dados = new DadosDeFichaMatricula();
            dados.id_Aluno(id_Aluno);
            dados.id_Cliente(id_Cliente);
            dados.carregaAluno(tblAluno);
            dados.carregaCliente(tblCliente);
            string []args = {"","","","", ""};

            if (tblCliente.Rows[0]["cpf_pai"].ToString() != "           -")
                args[0] = tblCliente.Rows[0]["cpf_Pai"].ToString();
            else
                args[0] = "";

            if (tblCliente.Rows[0]["cpf_mae"].ToString() != "           -")
                args[1] = tblCliente.Rows[0]["cpf_mae"].ToString();
            else
                args[1] = "";

            if (tblCliente.Rows[0]["fone_Pai"].ToString() != "(  )     -")
                args[2] = tblCliente.Rows[0]["fone_Pai"].ToString();
            else
                args[2] = "";
            if (tblCliente.Rows[0]["fone_mae"].ToString() != "(  )     -")
                args[3] = tblCliente.Rows[0]["fone_mae"].ToString();
            else
                args[3] = "";

            if (tblCliente.Rows[0]["cep"].ToString() == "     -")
                args[4] = "";
            else
                args[4] = tblCliente.Rows[0]["cep"].ToString();

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nomeAluno", tblAluno.Rows[0]["nome"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("serie", tblAluno.Rows[0]["ano"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("turno", tblAluno.Rows[0]["turno"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dtNascimento", Convert.ToDateTime(tblAluno.Rows[0]["nascimento"].ToString()).ToString("dd/MM/yyyy")));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("sexo", tblAluno.Rows[0]["sexo"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("natural", tblAluno.Rows[0]["naturalidade"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("uf", tblAluno.Rows[0]["uf"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dadosClinicos", tblAluno.Rows[0]["dadosClinicos"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("remedios", tblAluno.Rows[0]["remedios"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ano", tblAluno.Rows[0]["ano_recente"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("situacao", "Cursando"));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nomePai", tblCliente.Rows[0]["pai"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nomeMae", tblCliente.Rows[0]["mae"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cpfpai", args[0]));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cpfmae", args[1]));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fonepai", args[2]));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fonemae", args[3]));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ender", tblCliente.Rows[0]["endereco"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("numero", tblCliente.Rows[0]["numero"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("bairro", tblCliente.Rows[0]["bairro"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("comple", tblCliente.Rows[0]["complemento"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cidade", tblCliente.Rows[0]["cidade"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("estado", tblCliente.Rows[0]["estado"].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cep", args[4]));

            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 150;

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("codA", id_Aluno.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("codC", id_Cliente.ToString()));
            this.reportViewer1.RefreshReport();
        }
    }
}
