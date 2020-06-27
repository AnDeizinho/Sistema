using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaShekinahCompleto.Entidades;
using SistemaShekinahCompleto.DAO;
namespace CaixaSimples
{
    public enum Tranz { Indef, Alterar, Cadastrar }
    public enum Sexo { Indef, M, F }
    public enum Integral { Indef, não,Sim}
    public partial class frmAluno : UserControl
    {
        public AlunoEnt aluno { get; private set; }
        AlunosDAO alunoDAO;
        Tranz tranzacao;

        //==================================
        
        public frmAluno(Tranz tra)
        {
            aluno = new AlunoEnt();
            alunoDAO = new AlunosDAO();
            tranzacao = tra;
            InitializeComponent();
        }
        public frmAluno(AlunoEnt al, Tranz tra)
        {
            alunoDAO = new AlunosDAO();
            InitializeComponent();
            tranzacao = tra;
            aluno = al;
            CarregaControles(aluno);
            if (tra == Tranz.Cadastrar)
            {
                cb.SelectedIndex = 0;
                cbIntegral.SelectedIndex = 0;
            }
            else if (tra == Tranz.Alterar)
            {
                cb.SelectedIndex = (int)Enum.Parse(typeof(Sexo), aluno.sexo);
                cbIntegral.SelectedIndex = (int)Enum.Parse(typeof(Integral), aluno.integral);
            }
            
            
        }
        private void frmAluno_Load(object sender, EventArgs e)
        {
            
            txtCod.Text = "" + aluno.id_cliente;
         

        }
        private void CarregaAluno(AlunoEnt al)
        {
            al.id_aluno = txtCA.Text.ToInt();
            al.id_cliente = txtCod.Text.ToInt();
            al.nome = txtNome.Text;
            al.ano_recente = txtAno.Text;
            //al.turma deve estar pré carregado
            al.nascimento = data.Value.Date;
            al.naturalidade = txtnat.Text;
            al.uf = txtuf.Text;
            al.sexo = cb.SelectedIndex > 0 ? cb.Text : "";
            al.integral = cbIntegral.SelectedIndex > 0 ? cbIntegral.Text : "";
            al.remedios = txtremedio.Text;
            al.dadosClinicos = txtclinicos.Text;
            al.id_mac = mask.Text;

        }
        private void CarregaControles(AlunoEnt al)
        {
            aluno = al;
            txtCod.Text = aluno.id_cliente.ToString();
            txtCA.Text = aluno.id_aluno.ToString();
            txtNome.Text = aluno.nome;
            txtAno.Text = aluno.ano_recente;
            cbTurma.Text = aluno.turma.ToString();
            txtnat.Text = aluno.naturalidade;
            txtuf.Text = aluno.uf;
            data.Value = aluno.nascimento.Date < data.MinDate ? data.MinDate : aluno.nascimento.Date;
            
            txtremedio.Text = aluno.remedios;
            txtclinicos.Text = aluno.dadosClinicos;
            mask.Text = aluno.id_mac;
            txtAno.Text = aluno.ano_recente;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CarregaAluno(aluno);
                switch (tranzacao)
                {
                    case Tranz.Alterar:
                        alunoDAO.AtualizarAluno(aluno);
                        MessageBox.Show("alterado com Sucesso");
                        break;
                    case Tranz.Cadastrar:
                        string msg = alunoDAO.InserirNovoAluno(aluno);
                        tranzacao = Tranz.Alterar;
                        MessageBox.Show(msg == "" ? "cadastrado com sucesso" : msg);
                        txtCA.Text = aluno.id_aluno.ToString();
                        aluno.filhos++;
                        break;
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
            
        }

        private void btnturma_Click(object sender, EventArgs e)
        {
            
            Controles.SelecionarTurma ctr = new Controles.SelecionarTurma();
            ctr.ShowDialog();
            aluno.turma = ctr.Turma;
            cbTurma.Text = aluno.turma.ToString();
            
        }
       
       
    }
}
