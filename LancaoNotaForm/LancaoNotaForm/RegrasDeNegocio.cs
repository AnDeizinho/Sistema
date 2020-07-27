using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LancaoNotaForm
{
    
    class RegrasDeNegocio
    {
        int Baixas = 0;
        ComunicaoDeDados conD;
        double []notas = new double[9];
        int faltas=0;
        int IDbimestre = 0;
        int idAluno = 0;
        string ap = "";
        string r = "";
        SqlConnection conex;

        public RegrasDeNegocio(int idBimestre,int idaluno, SqlConnection con, TextBox[] text)
        {
            IDbimestre = idBimestre;
            for(int i = 0; i<9; i++)
            {
                notas[i] = Convert.ToDouble(text[i].Text);
                if(notas[i] >= 0 && notas[i]<6)
                    Baixas++;
            }
            conex = con;
            faltas = Convert.ToInt32(text[9].Text);
            conD = new ComunicaoDeDados();
            idAluno = idaluno;

        }

        public void AtualizaNotas()
        {
            defineSePassou();
            try
            {
                lanca_e_atualiza_a_ata_final();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
            
        }
        private void defineSePassou()
        {
            if (Baixas >= 4)
            {
                r = "r";
            }
            else
            {
                ap = "ap";
            }
        }
        private void lanca_e_atualiza_a_ata_final()
        {
            conD.updateNotas(conex, notas[0], notas[1], notas[2], notas[3], notas[4], notas[5], notas[6], notas[7], notas[8], ap, r, faltas, IDbimestre);
            conD.updateAta(conex, notas[0], notas[1], notas[2], notas[3], notas[4], notas[5], notas[6], notas[7], notas[8], faltas, idAluno, "2019"); 

        }
        public void AtualizaGrid(TextBox[] args, DataGridView grid, int ind)
        {
            grid.Rows[ind].Cells["port"].Value = args[0].Text;
            grid.Rows[ind].Cells["mat"].Value = args[1].Text;
            grid.Rows[ind].Cells["hist"].Value = args[2].Text;
            grid.Rows[ind].Cells["geog"].Value = args[3].Text;
            grid.Rows[ind].Cells["ciencia"].Value = args[4].Text;
            grid.Rows[ind].Cells["arte"].Value = args[5].Text;
            grid.Rows[ind].Cells["religiao"].Value = args[6].Text;
            grid.Rows[ind].Cells["ingles"].Value = args[7].Text;
            grid.Rows[ind].Cells["fisica"].Value = args[8].Text;
            grid.Rows[ind].Cells["faltas"].Value = args[9].Text;
            grid.Rows[ind].Cells["ap"].Value = ap;
            grid.Rows[ind].Cells["rep"].Value = r;

        }
        
    }
}
