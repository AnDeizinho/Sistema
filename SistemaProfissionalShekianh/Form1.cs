using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaProfissionalShekianh
{
    public partial class Form1 : Form
    {
        bool oculto = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            if (oculto == false)
            {

                pnControle.Width = 50;
                PnForm.Location = new Point(55, PnForm.Location.Y);
                PnForm.Width += 181;
                oculto = true;
            }
            else
            {
                PnForm.Location = new Point(236, PnForm.Location.Y);
                pnControle.Width = 231;
                PnForm.Width -= 181;
                oculto = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (AbriForm("Caixa") == false)
            {
                Caixa ca = new Caixa();
                ca.TopLevel = false;
                PnForm.Controls.Add(ca);
                ca.Show();
            }
        }
        bool AbriForm(string formulario)
        {
            
            foreach (Form i in PnForm.Controls)
            {
                if (i.Text != formulario)
                {
                    i.WindowState = FormWindowState.Minimized;
                }
                else { i.WindowState = FormWindowState.Normal;  return true; }
            }
                return false;
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AbriForm("Secretaria") == false)
            {
                Secretaria sec = new Secretaria();
                sec.TopLevel = false;
                PnForm.Controls.Add(sec);
                sec.Show();
            }
        }
    }
}
