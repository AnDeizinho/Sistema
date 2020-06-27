using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaShekinahCompleto.Entidades
{
    public class ClienteEnt : ClienteAbs
    {
        public ClienteEnt()
        {
            Limpa();
        }
        bool EstaVasio(string variavel)
        {
            if (variavel == "" || variavel == null)
                return true;
            return false;
        }
        bool EstaVasio(int variavel)
        {
            if (variavel == null)
                return true;
            return false;
        }
        public void PodeCadastrar()
        {
            if (EstaVasio(pai) == true)
                throw new ExceptionCliente("Digite o Nome do Pai");
            if (EstaVasio(mae) == true)
                throw new ExceptionCliente("Digite o Nome da Mãe");
            if (EstaVasio(cpf_pai) == true)
                throw new ExceptionCliente("Digite o CPF do pai");
            if (EstaVasio(cpf_mae) == true)
                throw new ExceptionCliente("Digite o CPF da mãe");
        }
        public void Limpa()
        {
            id_cliente = 0;
            pai = "";
            mae = "";
            cpf_pai = "";
            cpf_mae = "";
            fone_pai = "";
            fone_mae = "";
            endereco = "";
            numero = "";
            bairro = "";
            complemento = "";
            cidade = "";
            estado = "";
            cep = "";
            filhos = 0;
            RG = "";
        }



        public override string ToString()
        {
            return string.Format("CC={0} | Pai={1} | Mãe={2} | Cpf Pai={3} | Cpf Mãe={4} | Fone Pai={5} | Fone Mãe={6} | Endereço={7} | Número {8} |" +
            " Bairro={9} | Complem.={10} | Cidade={11} | UF={12} | CEP={13} | Filhos={14} | RG={15}", id_cliente,
            pai,
            mae,
            cpf_pai,
            cpf_mae,
            fone_pai,
            fone_mae,
            endereco,
            numero,
            bairro,
            complemento,
            cidade,
            estado,
            cep,
            filhos,
            RG);
        }
       
    }
}
