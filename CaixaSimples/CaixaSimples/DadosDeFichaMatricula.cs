using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CaixaSimples
{
    class DadosDeFichaMatricula
    {
        
        

        int Idcliente = 0;
        int Idaluno = 0;
        public void id_Cliente(int id)
        {
            Idcliente = id;
        }
        public void id_Aluno(int id)
        {
            Idaluno = id;
        }

        public void carregaCliente(DataTable tabela)
        {
            adp AdpCliente = new adp("select * from tbl_cliente where id_cliente = " + Idcliente);
            AdpCliente.Preencher(tabela);
        }
        public void carregaAluno(DataTable tabela)
        {
            adp AdpAluno = new adp("SELECT [id_aluno],[nome],tblAno.ano,tbl_turno.turno,[nascimento],[sexo],[naturalidade],[uf],[dadosClinicos],[remedios]FROM [BDAtaFinal].[dbo].[tbl_Alunos] join BDAtaFinal.dbo.tbl_turma on tbl_Alunos.id_turma = tbl_turma.id_turma join BDAtaFinal.dbo.tblAno on tbl_turma.id_ano = tblAno.id_Ano join BDAtaFinal.dbo.tbl_turno on tbl_turma.id_turno = tbl_turno.id_turno where id_aluno = " + Idaluno);
            AdpAluno.Preencher(tabela);
        }
    }
}
