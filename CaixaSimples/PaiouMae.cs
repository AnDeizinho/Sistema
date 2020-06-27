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
    public enum DadosDo{nenhum,pai, mae}
    public partial class PaiouMae : frmFormulario
    {
        DadosDo dados = DadosDo.nenhum;
        public PaiouMae()
        {
            InitializeComponent();
        }

        private void PaiouMae_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dados = DadosDo.pai;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dados = DadosDo.mae;
            this.Close();
        }
        public DadosDo GetDados()
        {
            return dados;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dados = DadosDo.nenhum;
            this.Close();
        }
    }
}
