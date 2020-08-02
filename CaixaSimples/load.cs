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
namespace CaixaSimples
{
    public partial class frmLogin : Form
    {
        private bool certo = false;

        public bool ADMuser = false;
        public frmLogin()
        {
            InitializeComponent();
           
        }
        public bool logou()
        {
            return certo;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "MONICA";
            string senha = "050618";
            
            if (usuario == txtUsuario.Text & senha == txtSenha.Text)
            {
                certo = true;
                this.Close();
                
            }
            else
            {
                
                certo = false;
                MessageBox.Show("Usuário ou Senha errada!!");
                txtSenha.Text = "";
                txtUsuario.Text = "";
                txtUsuario.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Conexao Co = new Conexao();
            System.Data.SqlClient.SqlConnection con1, con2;
            con1 = Co.NovaConexaoBdCaixa();
            con2 = Co.NovaConexaoBdAtaFinal();
            try
            {
                con1.Open();
                con2.Open();

            }
            catch(System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            finally
            {
                con1.Close(); con2.Close(); con1.Dispose(); con2.Dispose();
            }
                
        }

        //private void frmLogin_Enter(object sender, EventArgs e)
        //{

            //btnEntrar_Click(null, e);
        //}

        //private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        //{
            //MessageBox.Show(e.KeyValue + "");
            //btnEntrar_Click(sender, e);
        //}
    }
}
