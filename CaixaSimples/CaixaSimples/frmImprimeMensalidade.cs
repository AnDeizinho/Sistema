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
    
    public partial class frmImprimeMensalidade : frmFormulario
    {
        
        string[] args ;
        string[] nomes = { "cliente", "cpf", "mes", "valor", "ano", "dia", "mesAtual", "anoAtual" };
        int cod = 0;
        string anoRec = "";
        string nome = "_____________________", cpf = "___.___.___-__";
        DataTable dados = new DataTable();
        
        public frmImprimeMensalidade()
        {
            SqlDataAdapter adp =  new SqlDataAdapter("select * from tbl_Alunos where id_Cliente = 0", new SqlConnection(StatusDoCaixa.conStringBDAtaFinal));
            
            InitializeComponent();
            adp.Fill(this.BDAtaFinalDataSet.tbl_Alunos);
            
        }
        public frmImprimeMensalidade(string[] argumentos, int id, string ano)
        {
            PaiouMae dialog = new PaiouMae();
            dialog.ShowDialog();
            if (dialog.GetDados() == DadosDo.pai)
            {
                SqlDataAdapter adp1 = new SqlDataAdapter("select pai, cpf_pai from tbl_Cliente where id_cliente = " + id, new SqlConnection(StatusDoCaixa.conStringBDAtaFinal));
                adp1.Fill(dados);
                if(dados.Rows[0][0].ToString() != "")
                    nome = dados.Rows[0][0].ToString();
                if(dados.Rows[0][1].ToString() != "           -")
                    cpf = dados.Rows[0][1].ToString();
            }
            else if (dialog.GetDados() == DadosDo.mae)
            {
                SqlDataAdapter adp1 = new SqlDataAdapter("select mae, cpf_mae from tbl_Cliente where id_cliente = " + id, new SqlConnection(StatusDoCaixa.conStringBDAtaFinal));
                adp1.Fill(dados);
                if(dados.Rows[0][0].ToString() != "")
                    nome = dados.Rows[0][0].ToString();
                if (dados.Rows[0][1].ToString() != "           -")
                    cpf = dados.Rows[0][1].ToString();
            }
            else
            {

                
            }

            InitializeComponent();
            args = argumentos;
            cod = id;
            anoRec = ano;
        }

        private void frmImprimeMensalidade_Load(object sender, EventArgs e)
        {
            
            if (args != null)
            {
                
                    // TODO: This line of code loads data into the 'BDAtaFinalDataSet.tbl_Alunos' table. You can move, or remove it, as needed.
                    Microsoft.Reporting.WinForms.ReportParameter[] parametros = { new Microsoft.Reporting.WinForms.ReportParameter(nomes[0], nome), 
                                                                        new Microsoft.Reporting.WinForms.ReportParameter(nomes[1], cpf),
                                                                        new Microsoft.Reporting.WinForms.ReportParameter(nomes[2], args[0]),
                                                                        new Microsoft.Reporting.WinForms.ReportParameter(nomes[3], args[1]),
                                                                        new Microsoft.Reporting.WinForms.ReportParameter(nomes[4], args[2]),
                                                                        new Microsoft.Reporting.WinForms.ReportParameter(nomes[5], args[3]),
                                                                        new Microsoft.Reporting.WinForms.ReportParameter(nomes[6], args[4]),
                                                                        new Microsoft.Reporting.WinForms.ReportParameter(nomes[7], args[5])};
                    this.reportViewer1.LocalReport.SetParameters(parametros[0]);
                    this.reportViewer1.LocalReport.SetParameters(parametros[1]);
                    this.reportViewer1.LocalReport.SetParameters(parametros[2]);
                    this.reportViewer1.LocalReport.SetParameters(parametros[3]);
                    this.reportViewer1.LocalReport.SetParameters(parametros[4]);
                    this.reportViewer1.LocalReport.SetParameters(parametros[5]);
                    this.reportViewer1.LocalReport.SetParameters(parametros[6]);
                    this.reportViewer1.LocalReport.SetParameters(parametros[7]);


                }
            
            
            this.tbl_AlunosTableAdapter.CodCliente(this.BDAtaFinalDataSet.tbl_Alunos, cod, anoRec);
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }
    }
}
