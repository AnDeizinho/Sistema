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
    public partial class frmCad_Cliente : frmFormulario
    {
        enum meses { JANEIRO =0, FEVEREIRO = 1, MARÇO, ABRIL, MAIO, JUNHO, JULHO, AGOSTO, SETEMBRO, OUTUBRO, NOVEMBRO, DEZEMBRO }
        double parcela = 0;
        meses apartir_de = meses.JANEIRO;
        int id_Cliente = 0;
        adp adapita = new adp("select * from tbl_cliente");
        DataTable tabela = new DataTable();

        public frmCad_Cliente()
        {
           
            InitializeComponent();
        }

        private void txtNomeMae_Leave(object sender, EventArgs e)
        {

            if (txtNomePai.Text == "" & txtNomeMae.Text == "")
            {
                txtNomePai.Focus();
                MessageBox.Show("nome do pai ou da mãe é obrigatório");
            }
        }
        private void cadMes(meses me, double valor, double parcela)
        {
            SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDAtaFinal);
            SqlCommand cmd = new SqlCommand();
            conexao.Open();
            
                cmd.Connection = conexao;
                cmd.CommandText = "insert into tbl_Mes ([Id_Cliente] ,[Meses], [ano],[Data],[Valor], cb, parcela_min) values (@id, @mes,@ano, @data,@valor, 0, @parce)";
                cmd.Parameters.AddWithValue("@id", id_Cliente);
                cmd.Parameters.AddWithValue("@mes", me.ToString());
                cmd.Parameters.AddWithValue("@ano", txtAno.Text);
                cmd.Parameters.AddWithValue("@data", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@parce", parcela);
                cmd.Parameters.AddWithValue("@Valor", Convert.ToDouble(valor.ToString("N")));
                cmd.ExecuteNonQuery();

                
            
            conexao.Close();
        }
        private void txtNomePai_Validated(object sender, EventArgs e)
        {
           
            if (id_Cliente == 0)
            {
                

                if (txtNomePai.Text != "")
                {
                    try
                    {
                        adapita.SelectComando(new SqlCommand("Select id_cliente from tbl_cliente where pai = '" + txtNomePai.Text + "'"));
                        DataTable tblVerivica = new DataTable();
                        adapita.Preencher(tblVerivica);
                        if (tblVerivica.Rows.Count > 0)
                        {
                            string mensagem = "já existe um Pai com este nome.\nCC = ";
                            foreach (DataRow lin in tblVerivica.Rows)
                            {
                                MessageBox.Show(mensagem + lin[0].ToString());

                            }
                            txtNomePai.Text = "";
                            txtCod.Focus();

                            return;
                        }
                        SqlCommand comando = new SqlCommand();
                        comando.Parameters.AddWithValue("@npai", txtNomePai.Text);
                        comando.CommandText = "insert into tbl_cliente (pai, filhos) values(@npai, 0)";

                        adapita.InsertComando(comando);

                        adapita.SelectComando(new SqlCommand("select id_cliente from tbl_cliente where pai = '" + txtNomePai.Text + "'"));

                        adapita.Preencher(tabela);
                        foreach (DataRow linha in tabela.Rows)
                        {
                            id_Cliente = Convert.ToInt32(linha[0].ToString());
                            
                        }
                        txtCod.Text = "" + id_Cliente;
                        
                        //cadMes("FEVEREIRO", 0);
                        //cadMes("MARÇO", 0);
                        //cadMes("ABRIL", 0);
                        //cadMes("MAIO", 0);
                        ///cadMes("JUNHO", 0);
                        //cadMes("JULHO", 0);
                        //cadMes("AGOSTO", 0);
                        //cadMes("SETEMBRO", 0);
                        //cadMes("OUTUBRO", 0);
                        //cadMes("NOVEMBRO", 0);
                        //cadMes("DEZEMBRO", 0);

                        btnAluno.Enabled = true;
                        btnConc.Enabled = true;
                    }
                    catch(Exception erro)
                    {
                        MessageBox.Show("falha ao cadastrar pai" + erro);
                    }
                }
            }
            else if (id_Cliente > 0)
            {

                SqlCommand comando = new SqlCommand();
                comando.Parameters.AddWithValue("@npai", txtNomePai.Text);
                comando.Parameters.AddWithValue("@id", id_Cliente);
                comando.CommandText = "update tbl_cliente set pai = @npai where id_cliente = @id";
                adapita.UpdateComando(comando);
                btnAluno.Enabled = true;
                btnConc.Enabled = true;
            }
        }

        private void txtNomeMae_Validated(object sender, EventArgs e)
        {
            if (id_Cliente == 0)
            {
                if (txtNomeMae.Text != "")
                {
                    adapita.SelectComando(new SqlCommand("Select id_cliente from tbl_cliente where mae = '" + txtNomeMae.Text + "'"));
                    DataTable tblVerivica = new DataTable();
                    adapita.Preencher(tblVerivica);
                    if (tblVerivica.Rows.Count > 0)
                    {
                        string mensagem = "já existe uma Mãe com este nome.\nCC = ";
                        foreach (DataRow lin in tblVerivica.Rows)
                        {
                            MessageBox.Show(mensagem + lin[0].ToString());

                        }
                        txtNomeMae.Text = "";
                        txtCod.Focus();
                        return;
                    }
                }
                if (txtNomePai.Text == "" & txtNomeMae.Text !="")
                {
                    try
                    {
                        SqlCommand comando = new SqlCommand();
                        comando.Parameters.AddWithValue("@nmae", txtNomeMae.Text);
                        comando.CommandText = "insert into tbl_cliente (mae) values(@nmae)";

                        adapita.InsertComando(comando);

                        adapita.SelectComando(new SqlCommand("select id_cliente from tbl_cliente where mae = '" + txtNomeMae.Text + "'"));

                        adapita.Preencher(tabela);
                        foreach (DataRow linha in tabela.Rows)
                        {
                            id_Cliente = Convert.ToInt32(linha[0].ToString());
                        }
                        txtCod.Text = "" + id_Cliente;

                        
                        btnAluno.Enabled = true;
                        btnConc.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("falha ao cadastrar mae");
                    }
                }
            }
            else if (id_Cliente > 0)
            {
                SqlCommand comando = new SqlCommand();
                comando.Parameters.AddWithValue("@nmae", txtNomeMae.Text);
                comando.Parameters.AddWithValue("@id", id_Cliente);
                comando.CommandText = "update tbl_cliente set mae = @nmae where id_cliente = @id";
                adapita.UpdateComando(comando);
                btnAluno.Enabled = true;
                btnConc.Enabled = true;
            }
        }

        private void frmCad_Cliente_Load(object sender, EventArgs e)
        {
            id_Cliente = Convert.ToInt32(txtCod.Text);
            txtParcela.Text = parcela.ToString("N");
            cbMesParcela.SelectedIndex = 1;
        }

        private void txtCod_Validated(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {
                try
                {
                    id_Cliente = Convert.ToInt32(txtCod.Text);
                }
                catch
                {
                    id_Cliente = 0;
                    txtCod.Text = "0";
                    txtCod.Focus();
                    MessageBox.Show("Digite somente números no Código", "Erro ao converter para inteiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtCod.Focus();
            }

            if (id_Cliente == 0)
            {
               
                    txtNomePai.Text = "";
                    txtNomeMae.Text = "";
                    txtCpfPai.Text = "";
                    txtCpfMae.Text = "";

                    txtFonePai.Text = "";
                    txtFoneMae.Text = "";
                    txtEndereco.Text = "";
                    txtNumero.Text = "";
                    txtBairro.Text = "";
                    txtComplemento.Text = "";
                    txtCidade.Text = "";
                    txtEstado.Text = "";
                    txtCep.Text = "";
                
            }

            if (id_Cliente > 0)
            {
                DataTable tbl = new DataTable();
                adapita.SelectComando(new SqlCommand("SELECT tbl_cliente.id_cliente, [Pai] , [mae], [cpf_pai], [cpf_mae], [fone_pai], [fone_mae], [endereco], [numero], [bairro], [complemento], [cidade], [estado], [cep], [filhos], tbl_Mes.meses, tbl_Mes.parcela_min FROM tbl_cliente inner join tbl_Mes on tbl_cliente.id_cliente = tbl_Mes.id_Cliente where tbl_Cliente.id_cliente = " + id_Cliente));
                adapita.Preencher(tbl);
                if (tbl.Rows.Count > 0)
                {
                    
                        txtNomePai.Text = tbl.Rows[0][1].ToString();
                        txtNomeMae.Text = tbl.Rows[0][2].ToString();
                        txtCpfPai.Text = tbl.Rows[0][3].ToString();
                        txtCpfMae.Text = tbl.Rows[0][4].ToString();

                        txtFonePai.Text = tbl.Rows[0][5].ToString();
                        txtFoneMae.Text = tbl.Rows[0][6].ToString();
                        txtEndereco.Text = tbl.Rows[0][7].ToString();
                        txtNumero.Text = tbl.Rows[0][8].ToString();
                        txtBairro.Text = tbl.Rows[0][9].ToString();
                        txtComplemento.Text = tbl.Rows[0][10].ToString();
                        txtCidade.Text = tbl.Rows[0][11].ToString();
                        txtEstado.Text = tbl.Rows[0][12].ToString();
                        txtCep.Text = tbl.Rows[0][13].ToString();
                        
                        if (tbl.Rows[0][16].ToString() != "")
                            parcela = Convert.ToDouble(tbl.Rows[0][16].ToString());
                        else
                            parcela = 0;
                        txtParcela.Text = parcela.ToString("C") ;
                        cbMesParcela.Text = tbl.Rows[0][15].ToString();
                    
                    btnAluno.Enabled = true;
                    btnConc.Enabled = true;
                    
                }
                else
                {
                    id_Cliente = 0;
                    txtCod.Text = "0";
                    txtCod.Focus();
                    MessageBox.Show("não há registros com este código", "registro não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnAluno.Enabled = false;
                    btnConc.Enabled = false;
                    txtNomePai.Text = "";
                    txtNomeMae.Text = "";
                    txtCpfPai.Text = "";
                    txtCpfMae.Text = "";

                    txtFonePai.Text = "";
                    txtFoneMae.Text = "";
                    txtEndereco.Text = "";
                    txtNumero.Text = "";
                    txtBairro.Text = "";
                    txtComplemento.Text = "";
                    txtCidade.Text = "";
                    txtEstado.Text = "";
                    txtCep.Text = "";
                }
            }
        }

        private void txtCpfPai_Validated(object sender, EventArgs e)
        {
            /*
            if (id_Cliente == 0)
            {
                SqlCommand comando = new SqlCommand();
                comando.Parameters.AddWithValue("@cpfpai", txtCpfPai.Text);
                comando.CommandText = "insert into tbl_cliente (cpf_pai) values(@cpfpai)";

                adapita.InsertComando(comando);
            }
            else if (id_Cliente > 0)
            {
                SqlCommand comando = new SqlCommand();
                comando.Parameters.AddWithValue("@cpfpai", txtCpfPai.Text);
                comando.Parameters.AddWithValue("@id", id_Cliente);
                comando.CommandText = "update tbl_cliente set cpf_pai = @cpfpai where id_cliente = @id";

                adapita.InsertComando(comando);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (parcela == 0)
            {
                MessageBox.Show("Digite O Valor Da parcela");
                return;
            }
            try
            {
                
                
                if (id_Cliente != 0)
                {
                    SqlCommand filhos = new SqlCommand("select nome from tbl_Alunos where id_cliente = " + id_Cliente);
                    DataTable tblFilhos = new DataTable();
                    adapita.SelectComando(filhos);
                    adapita.Preencher(tblFilhos);
                    int qtdFilhos = tblFilhos.Rows.Count;

                    SqlCommand comando = new SqlCommand();
                    comando.Parameters.AddWithValue("@cpf_pai", txtCpfPai.Text);
                    comando.Parameters.AddWithValue("@cpf_mae", txtCpfMae.Text);
                    comando.Parameters.AddWithValue("@fone_pai", txtFonePai.Text);
                    comando.Parameters.AddWithValue("@fone_mae", txtFoneMae.Text);
                    comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    comando.Parameters.AddWithValue("@numero", txtNumero.Text);
                    comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    comando.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                    comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                    comando.Parameters.AddWithValue("@estado", txtEstado.Text);
                    comando.Parameters.AddWithValue("@cep", txtCep.Text);
                    comando.Parameters.AddWithValue("@id", id_Cliente);
                    comando.Parameters.AddWithValue("@filhos", qtdFilhos);
                    comando.CommandText = "update tbl_cliente set cpf_pai = @cpf_pai, cpf_mae = @cpf_mae, fone_pai = @fone_pai, fone_mae = @fone_mae, endereco = @endereco, numero = @numero, bairro = @bairro, complemento = @complemento, cidade = @cidade, estado = @estado, cep = @cep, filhos = @filhos where id_cliente = @id";
                    adapita.UpdateComando(comando);

                    //==============================================================================
                    // verifica se as tabelas de mensalidade ja existem
                    SqlCommand SeExiste = new SqlCommand("select id_meses , id_cliente from tbl_Mes where id_cliente = " + id_Cliente);
                    DataTable tblMeses = new DataTable();
                    adapita.SelectComando(SeExiste);
                    adapita.Preencher(tblMeses);
                    if (tblMeses.Rows.Count == 0)
                    {
                        while (apartir_de <= meses.DEZEMBRO)
                        {

                            cadMes(apartir_de, 0, parcela);
                            apartir_de++;
                        }
                    }
                    else
                    {
                        meses mes = meses.JANEIRO;
                        SeExiste.Parameters.AddWithValue("@parcela", parcela);
                        SeExiste.Parameters.AddWithValue("@id", id_Cliente);
                        SeExiste.CommandText = "update tbl_Mes set parcela_min = @parcela where id_cliente = @id";
                        adapita.UpdateComando(SeExiste);
                        while (mes < apartir_de)
                        {
                            SqlCommand Existe = new SqlCommand();
                            Existe.Parameters.AddWithValue("@id", id_Cliente);
                            Existe.Parameters.AddWithValue("@mes", mes.ToString());
                            Existe.Parameters.AddWithValue("@ano", txtAno.Text);
                            Existe.CommandText = "delete from tbl_mes where id_cliente = @id and meses = @mes and ano=@ano";
                            adapita.deleteComando(Existe);
                            mes++;
                        }


                    }

                    
                    MessageBox.Show("cadastrado com sucesso \nagora adicione um aluno");
                }
            }
            catch
            {
                MessageBox.Show("Digite Corretamente");
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            
            
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            frmAluno aluno = new frmAluno();
            aluno.inserirCodigoCliente(id_Cliente);
            aluno.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPesquisaAlunos pesq = new frmPesquisaAlunos();
            pesq.ShowDialog();
        }

        private void textBox1_Validated_1(object sender, EventArgs e)
        {
            try
            {
                parcela = Convert.ToDouble(txtParcela.Text);
                txtParcela.Text = parcela.ToString("N");
            }
            catch
            {
                parcela = 0;
                txtParcela.Text = parcela.ToString("N");
            }
        }

        private void cbMesParcela_SelectedIndexChanged(object sender, EventArgs e)
        {
            apartir_de = meses.JANEIRO;
            apartir_de = apartir_de - 1 + cbMesParcela.SelectedIndex;
            
            
        }
    }
}
