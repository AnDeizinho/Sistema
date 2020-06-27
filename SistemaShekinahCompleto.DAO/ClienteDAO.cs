using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaShekinahCompleto.Model;
using SistemaShekinahCompleto.Entidades;
using System.Data;
namespace SistemaShekinahCompleto.DAO
{
    public class ClienteDAO 
    {
        public DataTable Select()
        {
            return new DbCliente().Select();
        }
        public string Cadastrar(ClienteEnt cliente)
        {
            try
            {
                cliente.PodeCadastrar();
                DbCliente dbCliente = new DbCliente();
                string retorno="";
                switch( dbCliente.Cadastrar(cliente))
                {
                    case RetornosDoModel.Cadastrado:
                        retorno = "Cadastrado com sucesso";
                        break;
                    case RetornosDoModel.Existe:
                        retorno =  "já existe um registro como este no banco de dados";
                        break;
                    case RetornosDoModel.Erro:
                        retorno = "falha ao tentar cadastrar";
                        break;
                }
                return retorno;
            }
            catch(ExceptionCliente erro)
            {
                return erro.Message;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }
        public string Alterar(ClienteEnt cliente)
        {
            try
            {
                cliente.PodeCadastrar();
                DbCliente dbCliente = new DbCliente();

                return dbCliente.Alterar(cliente);
            }
            catch (ExceptionCliente erro)
            {
                return erro.Message;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }
        public RetornosDoModel CarregarClientePorId(ClienteEnt cliente, ref string mensagem)
        {
            DbCliente db = new DbCliente();
            return db.CarregarCliente(cliente,ref mensagem);
        }
        
        
    }
}
