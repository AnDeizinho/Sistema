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
using System.Drawing.Printing;
using SistemaShekinahCompleto.DAO;
using SistemaShekinahCompleto.Entidades;
namespace CaixaSimples
{
    public partial class frmMenu : Form
    {
        DataGridView dgvImprimi = new DataGridView();
        DataTable tblRMensalidade = new DataTable();
        DataTable tblRProdutos = new DataTable();
        DataTable tblRDepositos = new DataTable();
        DataTable tblRSaidas = new DataTable();
        public frmMenu()
        {
            
            InitializeComponent();
        }
        private async void inicia(DateTime DataDoCaixa)
        {
                
                lblDinheiro.Text = "Dinheiro: R$ ";
                lblSaida.Text = "Saída: R$ ";
                lblDebito.Text = "Débito: R$ ";
                lblCredito.Text = "Crédito: R$ ";
                lblTotalCartao.Text = "Total Cartão: R$ ";
                lblTotalEntradas.Text = "Total Entradas: R$ ";
                lblProdutos.Text = "Total Produtos: R$ ";
                lblTotalSpecie.Text = "Total Espécie : R$ ";
                lblFundoDeCaixa.Text = "Fundo de Caixa : R$ ";
                lblTotalDeposito.Text = "Total de Depósito : R$ ";
                lblValorApresentado.Text = "Valor Apresentado : R$ "; ;

                lblData.Text = "Data do Caixa : ";
                try
                {
                    carregaStatusCaixa(DataDoCaixa);


                }
                catch (Exception ERRO)
                {
                    MessageBox.Show(ERRO.ToString());
                }
            
            
        }
        private void carregaLetras()
        {
            lblDinheiro.Text += StatusDoCaixa.dinheiro.ToString("N");
            lblSaida.Text += StatusDoCaixa.saida.ToString("N");
            lblDebito.Text += StatusDoCaixa.debito.ToString("N");
            lblCredito.Text += StatusDoCaixa.credito.ToString("N");
            lblTotalCartao.Text += StatusDoCaixa.ttcartao.ToString("N");
            lblTotalEntradas.Text += StatusDoCaixa.ttentrada.ToString("N");
            lblProdutos.Text += StatusDoCaixa.ttprodutos.ToString("N");
            lblTotalSpecie.Text += StatusDoCaixa.ttespecie.ToString("N");
            lblFundoDeCaixa.Text += StatusDoCaixa.fdCaixa.ToString("N");
            lblTotalDeposito.Text += StatusDoCaixa.ttDeposito.ToString("N");
            lblValorApresentado.Text += StatusDoCaixa.valoApresentado.ToString("N");

            lblData.Text += StatusDoCaixa.data.ToString("dd/MM/yyyy");
            if(StatusDoCaixa.conclusao < 0 )
            {
                lblConclusao.Text = "Faltando : R$" + StatusDoCaixa.conclusao.ToString("N");
                lblConclusao.ForeColor = Color.Red;
            }
            else if (StatusDoCaixa.conclusao > 0)
            {
                lblConclusao.Text = "Sobrando : R$" + StatusDoCaixa.conclusao.ToString("N");
                lblConclusao.ForeColor = Color.Green;
            }
            else if (StatusDoCaixa.conclusao == 0)
            {
                lblConclusao.Text = "Caixa Exato !!";
                lblConclusao.ForeColor = Color.Green;
            }


        }
        private async void carregaStatusCaixa(DateTime DataDoCaixa)
        {
            int existe = await Task.Run(()=>verificaStatusCaixa(DataDoCaixa));
            if (existe == 0)
            {
                MessageBox.Show("Caixa Não existe");
                this.btnMensalidade.Enabled = false;
                this.btnRelatorio.Enabled = false;
                this.btnDeposito.Enabled = false;
                this.btnProdutos.Enabled = false;
                this.btnFechaCaixa.Enabled = false;
                this.btnSaida.Enabled = false;
                this.btnAbriCaixa.Enabled = true;
                this.lblStatu.Text = "Caixa Não existe";
                //carregaLetras();

            }
            else if (existe == 1)
            {

                await Task.Run(() => StatusDoCaixa.Calculos());



                DataTable tabela = await Task.Run(() =>
                {
                    SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDCaixa);
                    
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexao;
                    comando.Parameters.AddWithValue("@data", DataDoCaixa);
                    comando.CommandText = "select * from tblResumo_De_Caixas where Data = @data";
                    SqlDataAdapter adp = new SqlDataAdapter(comando);
                    DataTable tbl = new DataTable();
                    adp.Fill(tbl);
                    return tbl;
                });

                await Task.Run(() =>
                {
                    StatusDoCaixa.idCaixa = Convert.ToInt32(tabela.Rows[0][0].ToString());
                    StatusDoCaixa.data = Convert.ToDateTime(tabela.Rows[0][1].ToString());
                    StatusDoCaixa.status = Convert.ToChar(tabela.Rows[0][2].ToString());
                    StatusDoCaixa.dinheiro = Convert.ToDouble(tabela.Rows[0][3].ToString());
                    StatusDoCaixa.saida = Convert.ToDouble(tabela.Rows[0][4].ToString());
                    StatusDoCaixa.debito = Convert.ToDouble(tabela.Rows[0][5].ToString());
                    StatusDoCaixa.credito = Convert.ToDouble(tabela.Rows[0][6].ToString());
                    StatusDoCaixa.ttcartao = Convert.ToDouble(tabela.Rows[0][7].ToString());
                    StatusDoCaixa.ttentrada = Convert.ToDouble(tabela.Rows[0][8].ToString());
                    StatusDoCaixa.ttprodutos = Convert.ToDouble(tabela.Rows[0][9].ToString());
                    StatusDoCaixa.ttespecie = Convert.ToDouble(tabela.Rows[0][10].ToString());
                    StatusDoCaixa.fdCaixa = Convert.ToDouble(tabela.Rows[0][11].ToString());
                    StatusDoCaixa.ttDeposito = Convert.ToDouble(tabela.Rows[0][12].ToString());
                    StatusDoCaixa.valoApresentado = Convert.ToDouble(tabela.Rows[0][13].ToString());
                    StatusDoCaixa.conclusao = Convert.ToDouble(tabela.Rows[0][14].ToString());

                });




                
                if (StatusDoCaixa.status == 'a')
                {
                    //MessageBox.Show("caixa aberto");
                    this.btnMensalidade.Enabled = true;
                    this.btnRelatorio.Enabled = true;
                    this.btnDeposito.Enabled = true;
                    this.btnProdutos.Enabled = true;
                    this.btnFechaCaixa.Enabled = true;
                    this.btnSaida.Enabled = true;
                    this.btnAbriCaixa.Enabled = false;
                    this.lblStatu.Text = "Caixa em Aberto";
                }

                if (StatusDoCaixa.status == 'f')
                {
                    //MessageBox.Show("caixa aberto");
                    this.btnMensalidade.Enabled = false;
                    this.btnRelatorio.Enabled = true;
                    this.btnDeposito.Enabled = false;
                    this.btnProdutos.Enabled = false;
                    this.btnFechaCaixa.Enabled = false;
                    this.btnSaida.Enabled = false;
                    this.btnAbriCaixa.Enabled = false;
                    this.lblStatu.Text = "Caixa Fechado";
                }

                carregaLetras();
            }
            else if (existe > 1)
            {
                MessageBox.Show("caixa duplicado solicite Suporte Tecnico");
                this.btnMensalidade.Enabled = false;
                this.btnRelatorio.Enabled = false;
                this.btnDeposito.Enabled = false;
                this.btnProdutos.Enabled = false;
                this.btnFechaCaixa.Enabled = false;
                this.btnSaida.Enabled = false;
                this.btnAbriCaixa.Enabled = false;
                this.lblStatu.Text = "Caixa Duplicado";
                //carregaLetras();
            }
        }
        private int verificaStatusCaixa(DateTime DataDoCaixa)
        {
            int retorno = 0;
            SqlConnection conexao = new SistemaShekinahCompleto.Model.Conexao().NovaConexaoBdCaixa();
            conexao.Open();
            
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", DataDoCaixa);
            comando.CommandText = "SELECT COUNT(Data) from tblResumo_De_Caixas where Data = @data";
            SqlDataAdapter adp = new SqlDataAdapter(comando);
            DataTable tabela = new DataTable();
            adp.Fill(tabela);
            
            foreach (DataRow linha in tabela.Rows)
            {
                retorno = Convert.ToInt32(linha[0].ToString());
                
            }
            conexao.Close();
            return retorno;

        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.ShowDialog();
            try
            {
                Elemento.Child = new SistemaShekinahCompleto.InicioWF();
            }
            catch
            {

            }

            DateTime data = DateTime.Now.Date;
            inicia(data);

        }
        public void Login_Adm()
        {
            btnMensalidade.Enabled = false;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmAbriCaixa abr = new frmAbriCaixa();
            abr.ShowDialog();
            inicia(DateTime.Now.Date);
        }

        private void btnMensalidade_Click(object sender, EventArgs e)
        {
            FormMensalidade mes = new FormMensalidade();
            mes.ShowDialog();
            inicia(StatusDoCaixa.data);


        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            StatusDoCaixa.vardata = lblData.Text;
            StatusDoCaixa.vardinheiro = lblDinheiro.Text;
            StatusDoCaixa.varsaida = lblSaida.Text;
            StatusDoCaixa.vardebito = lblDebito.Text;
            StatusDoCaixa.varcredito = lblCredito.Text;
            StatusDoCaixa.varcartao = lblTotalCartao.Text;
            StatusDoCaixa.varentrada = lblTotalEntradas.Text;
            StatusDoCaixa.varproduto = lblProdutos.Text;
            StatusDoCaixa.varespecie = lblTotalSpecie.Text;
            StatusDoCaixa.varcaixa = lblFundoDeCaixa.Text;
            StatusDoCaixa.vardeposito = lblTotalDeposito.Text;
            StatusDoCaixa.varapresentado = lblValorApresentado.Text;
            StatusDoCaixa.varconclusao = lblConclusao.Text;
            frmRelatorio fo = new frmRelatorio();
            
            
            
            
            fo.ShowDialog();
            //dialogo.ShowDialog();
            
            inicia(StatusDoCaixa.data.Date);
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            frmDeposito dep = new frmDeposito();
            dep.ShowDialog();
            inicia(StatusDoCaixa.data.Date);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProduto prod = new frmProduto();
            prod.ShowDialog();
            inicia(StatusDoCaixa.data.Date);
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            frmSaida said = new frmSaida();
            said.ShowDialog();
            inicia(StatusDoCaixa.data);
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            frmHistorico his = new frmHistorico();
            his.ShowDialog();
            inicia(StatusDoCaixa.data);

        }

        private void btnFechaCaixa_Click(object sender, EventArgs e)
        {
            frmFechaCaixa fech = new frmFechaCaixa();
            fech.ShowDialog();
            inicia(StatusDoCaixa.data.Date);
        }
        private void carregaTblMensalidade()
        {
            
            SqlConnection conexao = new SistemaShekinahCompleto.Model.Conexao().NovaConexaoBdCaixa();
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            comando.Parameters.AddWithValue("@data1", StatusDoCaixa.data.Date.AddDays(1));
            comando.CommandText = "SELECT Data, Serie,Aluno, Mes, Forma_Pagamento, Valor FROM tbl_Mensalidade where Data >= @data and Data < @data1";
            comando.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(comando);
            adp.Fill(tblRMensalidade);
            dgvImprimi.DataSource = tblRMensalidade;
            conexao.Close();
            
        }
       

        private void tbn_Cd_Cliente_Click(object sender, EventArgs e)
        {
            frmCad_Cliente cad = new frmCad_Cliente();
            
            cad.ShowDialog();
        }
        
        private void btn_Cd_Aluno_Click(object sender, EventArgs e)
        {
            
            try
            {
                Controles.FrmDialogo frm = new Controles.FrmDialogo();
                frm.Show();
            }
            catch (Exception or)
            {
                MessageBox.Show(or.Message);
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaAlunos pesq = new frmPesquisaAlunos();
            pesq.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmListaClientes list = new frmListaClientes();
            list.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmBoletos bole = new FrmBoletos();
            bole.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmTurmas tur = new frmTurmas();
            tur.ShowDialog();
        }
    }
}
