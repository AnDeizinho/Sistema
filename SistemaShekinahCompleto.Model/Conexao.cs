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
        

        public Conexao()
        {
            prov = Provedores.pc_servidor;
        }
        public SqlConnection NovaConexaoBdAtaFinal()
        {

            return new SqlConnection(@"Data Source = "+DataSources[(int)prov] +"; DataBase = BDAtaFinal; User ID = sa ; Password = yerdna");
        }
        public SqlConnection NovaConexaoBdCaixa()
        {
            return new SqlConnection(@"Data Source = "+DataSources[(int)prov]+"; DataBase = BDCaixa ; User ID = sa ; Password = yerdna");
        }
        void Messagens(object sender, SqlInfoMessageEventArgs e)
        {
            mensagens = e.Message;
        }
    }
}
