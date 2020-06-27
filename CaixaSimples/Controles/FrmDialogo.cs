using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaShekinahCompleto.DAO;
using SistemaShekinahCompleto.Entidades;
namespace CaixaSimples.Controles
{
    public partial class FrmDialogo : frmFormulario
    {
        public FrmDialogo()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    AlunosDAO dao = new AlunosDAO();
                    AlunoEnt aluno = dao.SelectPorId(textBox1.Text.ToInt());
                    Form formulario = new frmFormulario() { FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable };
                    formulario.Controls.Add(new frmAluno(aluno, Tranz.Alterar));
                    formulario.Size = formulario.Controls[0].Size;
                    formulario.ShowDialog();
                    this.Close();
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }
    }
}
