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
using SistemaShekinahCompleto.DAO;
using SistemaShekinahCompleto.Entidades;
namespace CaixaSimples
{
    public partial class frmCad_Cliente : frmFormulario
    {
        
       
  
        ClienteEnt Meucliente = new ClienteEnt();
        ClienteDAO clienteDao ;
        public frmCad_Cliente()
        {
           
            InitializeComponent();
        }

        
        private void txtNomePai_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomePai.Text))
            {
                MessageBox.Show("digite o nome do pai");
            }
            else
            {
                if (txtNomePai.Text.Length <= 5)
                    MessageBox.Show("nome do pai inválido");
            }
        }

        private void txtNomeMae_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeMae.Text))
            {
                MessageBox.Show("digite o nome do mãe");
            }
            else
            {
                if (txtNomeMae.Text.Length <= 5)
                    MessageBox.Show("nome do mãe inválido");
            }
            
        }

        private void frmCad_Cliente_Load(object sender, EventArgs e)
        {
            Meucliente.id_cliente = Convert.ToInt32(txtCod.Text);
            
            
        }
        void lipaOsControles()
        {

            txtNomePai.Text = "";
            txtNomeMae.Text = "";
            txtCpfPai.Text = "";
            txtCpfMae.Text = "";

            txtFonePai.Text = "";
            txtFoneMae.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtCep.Text = "";
            
        }
        private void txtCod_Validated(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {
                try
                {
                    Meucliente.id_cliente = Convert.ToInt32(txtCod.Text);
                }
                catch
                {
                    Meucliente.id_cliente = 0;
                    txtCod.Text = "0";
                    txtCod.Focus();
                    MessageBox.Show("Digite somente números no Código", "Erro ao converter para inteiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtCod.Focus();
            }

            if (Meucliente.id_cliente == 0)
            {
                lipaOsControles();
            }
            else if (Meucliente.id_cliente > 0)
            {

                clienteDao = new ClienteDAO();
                try
                {
                    string minhaMensagem = "";
                    RetornosDoModel ret = clienteDao.CarregarClientePorId(Meucliente, ref minhaMensagem);
                    if (ret == RetornosDoModel.Erro)
                    {
                        MessageBox.Show(minhaMensagem);
                    }
                    
                    txtCod.Text = Meucliente.id_cliente.ToString();
                    txtNomePai.Text = Meucliente.pai;
                    txtNomeMae.Text = Meucliente.mae;
                    txtCpfPai.Text = Meucliente.cpf_pai;
                    txtCpfMae.Text = Meucliente.cpf_mae;

                    txtFonePai.Text = Meucliente.fone_pai;
                    txtFoneMae.Text = Meucliente.fone_mae;
                    txtEndereco.Text = Meucliente.endereco;
                    txtNumero.Text = Meucliente.numero;
                    txtBairro.Text = Meucliente.bairro;
                    txtComplemento.Text = Meucliente.complemento;
                    txtCidade.Text = Meucliente.cidade;
                    txtEstado.Text = Meucliente.estado;
                    txtCep.Text = Meucliente.cep;

                    btnAluno.Enabled = true;
                    btnConc.Enabled = true;
                }
                catch (Exception erro)
                {
                    this.Meucliente.id_cliente = 0;
                    txtCod.Text = "0";
                    txtCod.Focus();
                    MessageBox.Show(erro.Message);
                    this.lipaOsControles();
                }
            }
                   
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            
                ClienteDAO cli;
                Meucliente.pai = txtNomePai.Text;
                Meucliente.mae = txtNomeMae.Text;
                Meucliente.cpf_pai = txtCpfPai.Text;
                Meucliente.cpf_mae = txtCpfMae.Text;
                Meucliente.fone_pai = txtFonePai.Text;
                Meucliente.fone_mae = txtFoneMae.Text;
                Meucliente.endereco = txtEndereco.Text;
                Meucliente.numero = txtNumero.Text;
                Meucliente.bairro = txtBairro.Text;
                Meucliente.complemento = txtComplemento.Text;
                Meucliente.cidade = txtCidade.Text;
                Meucliente.estado = txtEstado.Text;
                Meucliente.cep = txtCep.Text;
                Meucliente.RG = txtRG.Text;
                if (Meucliente.id_cliente > 0)
                {
                    

                    cli = new ClienteDAO();

                    MessageBox.Show(cli.Alterar(Meucliente));

                }
                else
                {
                    cli = new ClienteDAO();
                    MessageBox.Show(cli.Cadastrar(Meucliente));
                    txtCod.Text = Meucliente.id_cliente.ToString();
                }
           
        }

      

        private void btnAluno_Click(object sender, EventArgs e)
        {
            if (Meucliente.id_cliente == 0)
            {
                txtCod.Focus();
                return;
            }
            
            AlunoEnt alu = new AlunoEnt();
            
            alu.Atribuir(Meucliente);
            Form formulario = new frmFormulario() { FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable };
            frmAluno ctr = new frmAluno(alu, Tranz.Cadastrar);
            formulario.Controls.Add(ctr);
            formulario.Size = formulario.Controls[0].Size;
            formulario.ShowDialog();
            Meucliente.filhos = ctr.aluno.filhos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPesquisaAlunos pesq = new frmPesquisaAlunos();
            pesq.ShowDialog();
        }

     
        private void btnBoleto_Click(object sender, EventArgs e)
        {
            if (Meucliente.id_cliente > 0)
            {
                frmContratoBoleto boleto = new frmContratoBoleto(Meucliente);
                boleto.Show();
            }
            else
                txtCod.Focus();
                
            
        }
    }
}
