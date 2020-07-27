using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LancaoNotaForm
{
    class RegrasCad
    {
        SqlConnection conex;
        ComunicaoDeDados conD = new ComunicaoDeDados();
        public RegrasCad(DataTable tabelaprofessor, ComboBox combo)
        {
            
            conex = new SqlConnection(DadosStaticos.strCon);
            conD.CarregaTabelaProfessores(tabelaprofessor, conex);
            try
            {
                foreach (DataRow linha in tabelaprofessor.Rows)
                {
                    combo.Items.Add(linha[1].ToString());

                }
            }
            catch
            {

            }
        }
    }
}
