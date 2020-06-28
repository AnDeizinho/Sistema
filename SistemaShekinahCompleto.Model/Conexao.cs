using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace SistemaShekinahCompleto.Model
{
    enum Provedores { Monica, pc_servidor }
    public class Conexao
    {
        Provedores prov;
        public string mensagens { get; private set; }
        string[] DataSources = {"Monica",@"PC-SERVIDOR,1433\SQLEXPRESS" };
        SqlConnection conata;
        SqlConnection concaixa;

        public Conexao()
        {
            prov = Provedores.pc_servidor;
            conata = new SqlConnection(@"Data Source = " + DataSources[(int)prov] + "; DataBase = BDAtaFinal; User ID = sa ; Password = yerdna");
            concaixa = new SqlConnection(@"Data Source = "+DataSources[(int)prov]+"; DataBase = BDCaixa ; User ID = sa ; Password = yerdna");
            
        }
        public SqlConnection NovaConexaoBdAtaFinal()
        {

            return conata;
        }
        public SqlConnection NovaConexaoBdCaixa()
        {
            return concaixa;
        }
        void Messagens(object sender, SqlInfoMessageEventArgs e)
        {
            mensagens = e.Message;
        }
    }
}
