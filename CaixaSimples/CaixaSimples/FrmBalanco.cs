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
    public partial class FrmBalanco : frmFormulario

    {
        
        double dinheiro = 0, saidas = 0, debito = 0, credito = 0, ttcartao = 0, ttentradas = 0, ttespecie = 0, fundo = 0, ttprodutos = 0, ttdeposito = 0, apresentado = 0, conclusao = 0;
        public FrmBalanco()
        {
            InitializeComponent();
        }

        private void listar()
        {
            foreach (DataGridViewRow linha in Grid.Rows)
            {
                dinheiro += Convert.ToDouble(linha.Cells[2].Value.ToString());
                saidas += Convert.ToDouble(linha.Cells[3].Value.ToString());
                debito += Convert.ToDouble(linha.Cells[4].Value.ToString());
                credito += Convert.ToDouble(linha.Cells[5].Value.ToString());
                ttcartao += Convert.ToDouble(linha.Cells[6].Value.ToString());
                ttentradas += Convert.ToDouble(linha.Cells[7].Value.ToString());
                ttespecie += Convert.ToDouble(linha.Cells[9].Value.ToString());
                fundo += Convert.ToDouble(linha.Cells[10].Value.ToString());
                ttprodutos += Convert.ToDouble(linha.Cells[8].Value.ToString());
                ttdeposito += Convert.ToDouble(linha.Cells[11].Value.ToString());
                apresentado += Convert.ToDouble(linha.Cells[12].Value.ToString());
                conclusao += Convert.ToDouble(linha.Cells[13].Value.ToString());



            }

            toolStripLabel1.Text = "Dinheiro : " + dinheiro.ToString("C");
            toolStripLabel2.Text = "Saídas : " + saidas.ToString("C");
            toolStripLabel3.Text = "Débito : " + debito.ToString("C");
            toolStripLabel4.Text = "Crédito : " + credito.ToString("C");
            toolStripLabel5.Text = "Total Cartão : " + ttcartao.ToString("C");
            toolStripLabel6.Text = "Total Entradas : " + ttentradas.ToString("C");
            toolStripLabel7.Text = "Total Produtos : " + ttprodutos.ToString("C");
            toolStripLabel8.Text = "Total Espécie : " + ttespecie.ToString("C");
            toolStripLabel9.Text = "Fundo De Caixa : " + fundo.ToString("C");
            toolStripLabel10.Text = "Total Depósito : " + ttdeposito.ToString("C");
            toolStripLabel11.Text = "Valor Apresentado : " + apresentado.ToString("C");
            toolStripLabel12.Text = "Conclusão : " + conclusao.ToString("C");
            btnImprimir.Enabled = true;
            
        }
        private async void limpar()
        {
            
            await Task.Run(() =>  {
                dinheiro = 0;
                saidas = 0;
                debito = 0;
                credito = 0;
                ttcartao = 0;
                ttentradas = 0;
                ttespecie = 0;
                fundo = 0;
                ttprodutos = 0;
                ttdeposito = 0;
                apresentado = 0;
                conclusao = 0;

                toolStripLabel1.Text = " ";
                toolStripLabel2.Text = " ";//"Saídas : " + saidas.ToString("C");
                toolStripLabel3.Text = " ";//"Débito : " + debito.ToString("C");
                toolStripLabel4.Text = " ";//"Crédito : " + credito.ToString("C");
                toolStripLabel5.Text = " ";//"Total Cartão : " + ttcartao.ToString("C");
                toolStripLabel6.Text = " ";//"Total Entradas : " + ttentradas.ToString("C");
                toolStripLabel7.Text = " ";//"Total Produtos : " + ttprodutos.ToString("C");
                toolStripLabel8.Text = " ";//"Total Espécie : " + ttespecie.ToString("C");
                toolStripLabel9.Text = " ";//"Fundo De Caixa : " + fundo.ToString("C");
                toolStripLabel10.Text = " ";//"Total Depósito : " + ttdeposito.ToString("C");
                toolStripLabel11.Text = " "; //"Valor Apresentado : " + apresentado.ToString("C");
                toolStripLabel12.Text = " ";

            });
            

        }
        private void FrmBalanco_Load(object sender, EventArgs e)
        {
            btnImprimir.Enabled = false;
            dt1.Value = DateTime.Now.AddDays(-30);// TODO: This line of code loads data into the 'bDcaixaDataSet.tblResumo_De_Caixas' table. You can move, or remove it, as needed.
            //this.tblResumo_De_CaixasTableAdapter.Fill(this.bDcaixaDataSet.tblResumo_De_Caixas);
            
        }

        

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                limpar();
                this.tblResumo_De_CaixasTableAdapter.FillBalanco(this.dataSource.tblResumo_De_Caixas, dt1.Value.Date, dt2.Value.Date);
                listar();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] arg = { dt1.Value.Date.ToString("dd/MM/yyyy"), dt2.Value.Date.ToString("dd/MM/yyyy"), dinheiro.ToString("C"), saidas.ToString("C"), debito.ToString("C"), credito.ToString("C"), ttcartao.ToString("C"), ttentradas.ToString("C"), ttespecie.ToString("C"), fundo.ToString("C"), ttprodutos.ToString("C"), ttdeposito.ToString("C"), apresentado.ToString("C"), conclusao.ToString("C") };
            frmRelatorioBalanco bal = new frmRelatorioBalanco(arg);
            bal.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        
    }
}
