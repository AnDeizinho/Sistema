using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaShekinahCompleto.Entidades
{
    public class ExceptionCliente : Exception
    {
        public ExceptionCliente(string msg)
            : base(msg)
        {

        }
    }
    public abstract class ClienteAbs
    {
        public int id_cliente { get; set; }
        public string pai { get; set; }
        public string mae { get; set; }
        public string cpf_pai { get; set; }
        public string cpf_mae { get; set; }
        public string fone_pai { get; set; }
        public string fone_mae { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public int filhos { get; set; }
        public string RG { get; set; }

        public void Atribuir(ClienteAbs cli)
        {
            id_cliente = cli.id_cliente;
            pai = cli.pai;
            mae = cli.mae;
            cpf_pai = cli.cpf_pai;
            cpf_mae = cli.cpf_mae;
            fone_pai = cli.fone_pai;
            fone_mae = cli.fone_mae;
            endereco = cli.endereco;
            numero = cli.numero;
            bairro = cli.bairro;
            complemento = cli.complemento;
            cidade = cli.cidade;
            estado = cli.estado;
            cep = cli.cep;
            filhos = cli.filhos;
            RG = cli.RG;
        }

    }
}
