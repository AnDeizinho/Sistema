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
namespace CaixaSimples
{
    public partial class frmAluno : frmFormulario
    {
        adp adapt = new adp("select id_turma, descricao from tbl_turma");
        DataTable turmatbl = new DataTable();
        int id_Codigo_Cliente = 0;
        int id_Codigo_aluno = 0;
        public frmAluno()
        {
            InitializeComponent();
        }
        public void inserirCodigoCliente(int cod)
        {
            id_Codigo_Cliente = cod;
            txtCod.Text = "" + id_Codigo_Cliente;
            txtCod.Enabled = false;
        }
        private void frmAluno_Load(object sender, EventArgs e)
        {
            
            txtCod.Text = "" + id_Codigo_Cliente;
            txtcodAluno.Text = "" + id_Codigo_aluno;

            btnDes.Enabled = false;
            
            adapt.Preencher(turmatbl);
            cbTurma.SelectedIndex = 0;
            cb.SelectedIndex = 0;
            cbIntegral.SelectedIndex = 0;

            
            foreach (DataRow linha in turmatbl.Rows)
            {
                cbTurma.Items.Add(linha[1].ToString());
            }
            btnCadastrar.Enabled = false;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbIntegral.SelectedIndex == 0)
            {
                cbIntegral.Focus();
                return;
            }
            if (cb.SelectedIndex == 0)
            {
                cb.Focus();
                return;
            }

            if (id_Codigo_Cliente > 0)
            {

                SqlCommand comando = new SqlCommand();
                comando.Parameters.AddWithValue("@idAluno", id_Codigo_aluno);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@idCli", Convert.ToInt32(txtCod.Text));
                comando.Parameters.AddWithValue("@turma", Convert.ToInt32(turmatbl.Rows[cbTurma.SelectedIndex-1][0].ToString()));
                comando.Parameters.AddWithValue("@dt", data.Value.Date);
                comando.Parameters.AddWithValue("@sex", cb.Text);
                comando.Parameters.AddWithValue("@nat", txtnat.Text);
                comando.Parameters.AddWithValue("@uf", txtuf.Text);
                comando.Parameters.AddWithValue("@cli", txtclinicos.Text);
                comando.Parameters.AddWithValue("@rem", txtremedio.Text);
                comando.Parameters.AddWithValue("@mac", mask.Text);
                comando.Parameters.AddWithValue("@integral", cbIntegral.Text);
                comando.CommandText = "update tbl_Alunos set nome = @nome, id_cliente = @idCli, id_turma = @turma, nascimento = @dt, sexo = @sex, naturalidade = @nat, uf = @uf, dadosClinicos = @cli, remedios = @rem, id_mac = @mac, integral = @integral where id_aluno = @idAluno";
                adapt.UpdateComando(comando);
                
                

                if (MessageBox.Show("Cadastrado com Sucesso,\ndeseja imprimir Ficha de Matrícula ?", "imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    frmRelatorioMatricula form = new frmRelatorioMatricula(id_Codigo_aluno, id_Codigo_Cliente);
                    form.ShowDialog();

                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("informe qual o codigo do Cliente");
            }
           
        }

        private void cbTurma_Validated(object sender, EventArgs e)
        {
            SqlCommand IdDaTurma = new SqlCommand("select id_turma from tbl_turma where descricao = '" + cbTurma.Text + "'");
            adapt.SelectComando(IdDaTurma);
            DataTable tblIdDaTurma = new DataTable();
            adapt.Preencher(tblIdDaTurma);
            int idDaTurmaInteger = 0;

            if (cbTurma.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um turma");
                cbTurma.Focus();
                return;
            }

            if (id_Codigo_aluno == 0)
            {
                if (id_Codigo_Cliente > 0)
                {
                    
                    if (tblIdDaTurma.Rows.Count > 0)
                    {
                        idDaTurmaInteger = Convert.ToInt32(tblIdDaTurma.Rows[0][0].ToString());
                    }
                    else
                    {
                        MessageBox.Show("erro no id da turma informe ao técnico", "Erro Urgente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //adiciona um aos filhos do cliente
                    SqlCommand adicionaFilho = new SqlCommand();
                    
                    adicionaFilho.CommandText = "update tbl_Cliente set filhos = filhos + 1 where id_cliente = " + id_Codigo_Cliente;
                    adapt.UpdateComando(adicionaFilho);

                    //Cadastra na tabela de alunos
                    SqlCommand comando = new SqlCommand();
                    comando.Parameters.AddWithValue("@nome", txtNome.Text);
                    comando.Parameters.AddWithValue("@idCli", Convert.ToInt32(txtCod.Text));
                    comando.Parameters.AddWithValue("@turma", Convert.ToInt32(turmatbl.Rows[cbTurma.SelectedIndex - 1][0].ToString()));
                    comando.Parameters.AddWithValue("@ano", txtAno.Text);
                    
                    comando.CommandText = "insert into tbl_Alunos (nome, id_cliente, ano_recente, id_turma, integral) values(@nome, @idCli, @ano, @turma, 'não')";
                    adapt.InsertComando(comando);
                    MessageBox.Show("cadastrado na tabela aluno com sucesso");
                    //==================//===============================//

                    //carrega o texte box txtCodaluno com o id do aluno
                    adapt.SelectComando(new SqlCommand("select id_aluno from tbl_Alunos where nome = '" + txtNome.Text + "'"));
                    DataTable tabeladoid = new DataTable();

                    adapt.Preencher(tabeladoid);

                    id_Codigo_aluno = Convert.ToInt32(tabeladoid.Rows[0][0].ToString());
                    txtcodAluno.Text = "" + id_Codigo_aluno;
                    //===================================================//

                    //cadastra na tabela de notas e de bimestre caso cbTura form no fundamental
                    if (idDaTurmaInteger >= 1 && idDaTurmaInteger <= 9)
                    {
                        //tabela notas
                        SqlCommand cmd = new SqlCommand();
                        cmd.Parameters.AddWithValue("@id", id_Codigo_aluno);
                        cmd.Parameters.AddWithValue("@ano", txtAno.Text);
                        cmd.CommandText = "insert into tbl_Notas ([id_aluno],[ano],[port],[mat],[hist],[geog],[ciencia],[arte],[religiao],[ingles],[fisica],[faltas]) values (@id, @ano, 0,0,0,0,0,0,0,0,0,0)";
                        adapt.InsertComando(cmd);
                        //desabilita o cbturma para não duplicar dados
                        cbTurma.Enabled = false;

                        //tabela bimestre inseri os 4 bimestre de uma vez
                        int bi = 1;
                        while (bi <= 4)
                        {
                            SqlCommand cmd1 = new SqlCommand();
                            cmd1.Parameters.AddWithValue("@id", id_Codigo_aluno);
                            cmd1.Parameters.AddWithValue("@ano", txtAno.Text);
                            cmd1.Parameters.AddWithValue("@bi", bi);
                            cmd1.CommandText = "insert into tbl_Bimestre (id_aluno, ano, [port],[mat],[hist],[geog],[ciencia],[arte],[religiao],[ingles],[fisica],[faltas], bimestre) values (@id, @ano,0,0,0,0,0,0,0,0,0,0, @bi)";
                            adapt.InsertComando(cmd1);
                            bi++;
                        }

                    }
                    btnCadastrar.Enabled = true;
                    
                }
                else
                {
                    MessageBox.Show("informe qual o codigo do Cliente");
                    return;
                }
            }
            
            else if (id_Codigo_aluno > 0 )
            {
                
                SqlCommand comando = new SqlCommand();

                comando.Parameters.AddWithValue("@index", Convert.ToInt32(turmatbl.Rows[cbTurma.SelectedIndex - 1][0].ToString()));
                comando.Parameters.AddWithValue("@ano", txtAno.Text);
                comando.Parameters.AddWithValue("@id", id_Codigo_aluno);
                comando.CommandText = "update tbl_Alunos set id_turma = @index, ano_recente = @ano  where id_aluno = @id";
                adapt.InsertComando(comando);
                
                
                if (idDaTurmaInteger >= 1 && idDaTurmaInteger <= 9)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@id", id_Codigo_aluno);
                    cmd.Parameters.AddWithValue("@ano", txtAno.Text);
                    cmd.CommandText = "insert into tbl_Notas (id_aluno, ano) values (@id, @ano)";
                    adapt.InsertComando(cmd);

                    //desabilita o cbturma para não duplicar dados
                    cbTurma.Enabled = false;

                    //tabela bimestre inseri os 4 bimestre de uma vez
                    int bi = 1;
                    while (bi <= 4)
                    {
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Parameters.AddWithValue("@id", id_Codigo_aluno);
                        cmd1.Parameters.AddWithValue("@ano", txtAno.Text);
                        cmd1.Parameters.AddWithValue("@bi", bi);
                        cmd1.CommandText = cmd1.CommandText = "insert into tbl_Bimestre (id_aluno, ano, [port],[mat],[hist],[geog],[ciencia],[arte],[religiao],[ingles],[fisica],[faltas], bimestre) values (@id, @ano,0,0,0,0,0,0,0,0,0,0, @bi)";
                        adapt.InsertComando(cmd1);
                        bi++;
                    }
                }

                btnCadastrar.Enabled = true;
                
            }
        }

        private void cb_Validated(object sender, EventArgs e)
        {
            if (cb.SelectedIndex == 0)
            {
                
                cb.Focus();
            }
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Focus();

            }
            else
            {
                if (txtNome.Text != "" & id_Codigo_aluno == 0)
                {
                    adapt.SelectComando(new SqlCommand("Select id_Aluno from tbl_alunos where nome = '" + txtNome.Text + "'"));
                    DataTable tblVerivica = new DataTable();
                    adapt.Preencher(tblVerivica);
                    if (tblVerivica.Rows.Count > 0)
                    {
                        string mensagem = "já existe(m) " + tblVerivica.Rows.Count + " aluno(s) com este nome.";
                        foreach (DataRow lin in tblVerivica.Rows)
                        {
                            mensagem = mensagem + "\nCA = " + lin[0].ToString();

                        }
                        MessageBox.Show(mensagem);
                        txtNome.Text = "";
                        txtcodAluno.Focus();
                        return;
                    }
                }
            }
        }

        private void txtCod_Validated(object sender, EventArgs e)
        {
            try
            {
                id_Codigo_Cliente = Convert.ToInt32(txtCod.Text);
                if (id_Codigo_Cliente == 0)
                {
                    MessageBox.Show("digite um codigo Válido");
                    txtCod.Focus();
                }

                if (id_Codigo_Cliente > 0)
                {
                    DataTable tbl = new DataTable();
                    adapt.SelectComando(new SqlCommand("select * from tbl_Cliente where id_Cliente = " + id_Codigo_Cliente));
                    adapt.Preencher(tbl);
                    if (tbl.Rows.Count == 0)
                    {
                        txtCod.Text = "0";
                        txtCod.Focus();
                        id_Codigo_Cliente = 0;
                        MessageBox.Show("Não há cliente com esse codigo", "Registro não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        txtCod.Enabled = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("digite somente numeros", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCod.Text = "0";
                txtCod.Focus();
                id_Codigo_Cliente = 0;
            }
        }

        private void txtcodAluno_Validated(object sender, EventArgs e)
        {
            if (txtcodAluno.Text != "")
            {
                try
                {


                    id_Codigo_aluno = Convert.ToInt32(txtcodAluno.Text);
                }
                catch
                {
                    MessageBox.Show("erro ao converter para numero", "digite somente numeros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    id_Codigo_aluno = 0;
                    txtcodAluno.Text = "0";
                    txtcodAluno.Focus();
                    btnCadastrar.Enabled = false;
                    btnDes.Enabled = false;
                
                }
            }
            else
            {
                id_Codigo_aluno = 0;
                txtcodAluno.Text = "0";
                txtcodAluno.Focus();
                btnCadastrar.Enabled = false;
                btnDes.Enabled = false;
                return;
                
            }

            if (id_Codigo_aluno == 0)
            {
                txtNome.Text = "";
                cbTurma.SelectedIndex = 0;
                data.Value = DateTime.Now.Date;
                cb.SelectedIndex = 0;
                txtnat.Text = "";
                txtuf.Text = "";
                txtAno.Text = "2019";
                txtclinicos.Text = "";
                txtremedio.Text = "";
                mask.Text = "";
                cbTurma.Enabled = true;
                btnDes.Enabled = false;
                btnCadastrar.Enabled = false;
                cbIntegral.SelectedIndex = 0;
            }

            else if (id_Codigo_aluno > 0)
            {
                
                    adapt.SelectComando(new SqlCommand("select * from tbl_Alunos where id_aluno = " + id_Codigo_aluno));
                    DataTable tabela = new DataTable();
                    adapt.Preencher(tabela);

                    

                    
                    if (tabela.Rows.Count > 0)
                    {
                        int idDaTurma = Convert.ToInt32(tabela.Rows[0][4].ToString());

                        adapt.SelectComando(new SqlCommand("select descricao from tbl_Turma where id_turma = " + idDaTurma));
                        DataTable Desc = new DataTable();
                        adapt.Preencher(Desc);

                        cbTurma.Text = Desc.Rows[0][0].ToString();

                        foreach (DataRow linha in tabela.Rows)
                        {
                            txtcodAluno.Text = linha[0].ToString();
                            id_Codigo_aluno = Convert.ToInt32(txtcodAluno.Text);
                            txtNome.Text = linha[1].ToString();
                            txtCod.Text = linha[2].ToString();
                            id_Codigo_Cliente = Convert.ToInt32(txtCod.Text);
                            txtAno.Text = linha[3].ToString();
                            
                            if (linha[5].ToString() != "")
                            {
                                data.Value = Convert.ToDateTime(linha[5].ToString());
                            }

                            if (linha[6].ToString() == "F")
                            {
                                cb.SelectedIndex = 2;
                            }
                            else if (linha[6].ToString() == "M")
                            {
                                cb.SelectedIndex = 1;
                            }
                            txtnat.Text = linha[7].ToString();
                            txtuf.Text = linha[8].ToString();
                            txtclinicos.Text = linha[9].ToString();
                            txtremedio.Text = linha[10].ToString();
                            mask.Text = linha[11].ToString();

                            if (linha[12].ToString() == "não")
                            {
                                cbIntegral.SelectedIndex = 1;
                            }
                            else if (linha[12].ToString() == "Sim")
                            {
                                cbIntegral.SelectedIndex = 2;
                            }
                            else
                            {
                                cbIntegral.SelectedIndex = 0;
                            }
                            
                        }

                        txtNome.Focus();
                        txtCod.Enabled = false;
                        btnCadastrar.Enabled = true;
                        btnDes.Enabled = true;
                        cbTurma.Enabled = false;

                    }
                    else
                    {
                        cbTurma.Enabled = true;
                        id_Codigo_aluno = 0;
                        txtcodAluno.Text = "0";
                        txtcodAluno.Focus();
                        txtCod.Text = "0";
                        id_Codigo_Cliente = 0;
                        txtCod.Enabled = true;
                        btnCadastrar.Enabled = false;
                        btnDes.Enabled = false;
                        MessageBox.Show("não há registros de aluno com este código ", "registro não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNome.Text = "";
                        cbIntegral.SelectedIndex = 0;
                        cbTurma.SelectedIndex = 0;
                        data.Value = DateTime.Now.Date;
                        cb.SelectedIndex = 0;
                        txtnat.Text = "";
                        txtuf.Text = "";
                        txtAno.Text = "2019";
                        txtclinicos.Text = "";
                        txtremedio.Text = "";
                        mask.Text = "";
                    }
                
            }
             
            

        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            

            if (id_Codigo_aluno > 0)
            {
                frmLogin logo = new frmLogin();
                logo.ShowDialog();
                if (logo.logou() == true)
                {
                    try
                    {
                        adapt.UpdateComando(new SqlCommand("update tbl_cliente set filhos = filhos - 1 where id_cliente = "+ id_Codigo_Cliente));
                        adapt.deleteComando(new SqlCommand("DELETE FROM [BDAtaFinal].[dbo].[tbl_Bimestre] WHERE id_aluno = " + id_Codigo_aluno));
                        

                        adapt.deleteComando(new SqlCommand("DELETE FROM [BDAtaFinal].[dbo].[tbl_Notas] WHERE id_aluno = " + id_Codigo_aluno));
                        

                        adapt.deleteComando(new SqlCommand("DELETE FROM [BDAtaFinal].[dbo].[tbl_Alunos] WHERE id_aluno = " + id_Codigo_aluno));
                        MessageBox.Show("Aluno deletado!!!");
                        txtNome.Text = "";
                        cbTurma.SelectedIndex = 0;
                        data.Value = DateTime.Now.Date;
                        cb.SelectedIndex = 0;
                        txtnat.Text = "";
                        txtuf.Text = "";
                        txtAno.Text = "2019";
                        txtclinicos.Text = "";
                        txtremedio.Text = "";
                        mask.Text = "";
                        cbTurma.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao deletar");
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
