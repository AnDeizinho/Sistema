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

namespace LancaoNotaForm
{
    
    public partial class frmMenu : Form
    {
        SqlConnection conexao = new SqlConnection(DadosStaticos.strCon);
        DataTable tbl =new DataTable();
        DataTable tblTurma = new DataTable();
        Listar MinhasListas = new Listar();
        int indice = 1;
        
        Professor prof = new Professor();
        
        public frmMenu()
        {
            Form1 login = new Form1();
            login.ShowDialog();
            prof = login.retornaProfessor() as Professor;

            
            InitializeComponent();
            txtano.Text = DateTime.Now.Year.ToString();
            cbbimestre.SelectedIndex = 0;

            if (prof.getTipo() == null)
            {
                return;
            }

        }
        private void listar(string tipo)
        {
            if (tipo == null)
            {
                return;
            }
            if (tipo.Contains("adm") == true)
            {
                try
                {
                    dt.DataSource = MinhasListas.ListaAdm( conexao, tbl, txtano.Text);
                }
                catch (Exception Erro)
                {
                    MessageBox.Show(Erro.ToString());
                }
            }
            else if (tipo.Contains("prof") == true)
            {
                try
                {
                    dt.DataSource = MinhasListas.ListaProf( prof, conexao, tbl, txtano.Text);
                    Ting.ReadOnly = true;
                    Tfalt.ReadOnly = true;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.ToString());
                }
            }
            else if (tipo.Contains("ingles") == true)
            {
                try
                {
                    dt.DataSource = MinhasListas.ListaAdm(conexao, tbl,txtano.Text);
                    Tport.ReadOnly = true;
                    Tmat.ReadOnly = true;
                    Thist.ReadOnly = true;
                    Tgeog.ReadOnly = true;
                    Tcie.ReadOnly = true;
                    Tart.ReadOnly = true;
                    Trel.ReadOnly = true;
                    Tfis.ReadOnly = true;
                    Tfalt.ReadOnly = true;

                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.ToString());
                }
            }
            

        }
        private void listaOcbTurmaProf()
        {
            try
            {
                if (prof.getTipo().Contains("prof") == true)
                {
                    SqlDataAdapter adp = new SqlDataAdapter(@"SELECT [id_turma]
      
      ,[descricao]
      ,tbl_niveis.Nivel
  FROM [tbl_turma] 
  join tblAno on tblAno.id_Ano = tbl_turma.id_ano
  join tbl_Niveis on tbl_Niveis.id_Nivel = tblano.id_nivel
  where tblAno.id_nivel = 2 and id_professor = " + prof.getId(), conexao);
                    adp.Fill(tblTurma);
                    for (int index = 0; index < tblTurma.Rows.Count; index++)
                    {
                        cbTurmas.Items.Add(tblTurma.Rows[index][1].ToString());
                    }
                }
                else
                {
                    SqlDataAdapter adp = new SqlDataAdapter(@"SELECT [id_turma]
      
      ,[descricao]
      ,tbl_niveis.Nivel
  FROM [tbl_turma] 
  join tblAno on tblAno.id_Ano = tbl_turma.id_ano
  join tbl_Niveis on tbl_Niveis.id_Nivel = tblano.id_nivel
  where tblAno.id_nivel = 2 ", conexao);
                    adp.Fill(tblTurma);
                    for (int index = 0; index < tblTurma.Rows.Count; index++)
                    {
                        cbTurmas.Items.Add(tblTurma.Rows[index][1].ToString());
                    }
                }
                cbTurmas.SelectedIndex = 0;
            }
            catch
            {

            }

        }
        private void frmMenu_Load(object sender, EventArgs e)
        {

            listaOcbTurmaProf();

            lblProf.Text = prof.getTipo() + " : " + prof.getNome();
            listar(prof.getTipo());
            button1.Enabled = false;
        }

        
        

        
       
        private void dt_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                carreganosText(e.RowIndex);
            indice = e.RowIndex;
            
            
                
        }
        private void carreganosText(int indicedo)
        {
            lblAluno.Text = "Aluno(a) : " + dt.Rows[indicedo].Cells["Nome"].Value.ToString();
            Tport.Text = dt.Rows[indicedo].Cells["port"].Value.ToString();
            Tmat.Text = dt.Rows[indicedo].Cells["mat"].Value.ToString();
            Thist.Text = dt.Rows[indicedo].Cells["hist"].Value.ToString();
            Tgeog.Text = dt.Rows[indicedo].Cells["geog"].Value.ToString();
            Tcie.Text = dt.Rows[indicedo].Cells["ciencia"].Value.ToString();
            Tart.Text = dt.Rows[indicedo].Cells["arte"].Value.ToString();
            Trel.Text = dt.Rows[indicedo].Cells["religiao"].Value.ToString();
            Ting.Text = dt.Rows[indicedo].Cells["ingles"].Value.ToString();
            Tfis.Text = dt.Rows[indicedo].Cells["fisica"].Value.ToString();
            Tfalt.Text = dt.Rows[indicedo].Cells["faltas"].Value.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {


            indice++;
            if (indice == dt.Rows.Count)
            {
                indice--;
                return;
            }
            indice--;
            carreganosText(indice + 1);
            dt.Rows[indice].Selected = false;
            dt.Rows[++indice].Selected = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


            indice--;
            if (indice == -1)
            {
                indice++;
                return;
            }
            indice++;
            carreganosText(indice - 1);
            dt.Rows[indice].Selected = false;
            dt.Rows[--indice].Selected = true;
            
        }

        private void cbbimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
                if (cbbimestre.SelectedIndex > 0)
                {   //select bimestre
                    if (cbTurmas.SelectedIndex > 0)
                    {   //select bimestre + turma
                        if (txtAluno.Text != "")
                        {
                            //select bimestre + turma + aluno
                            dt.DataSource = MinhasListas.ListaComParametros(conexao,tbl,prof.getId(),cbbimestre.SelectedIndex,prof.getTipo(),(int)tblTurma.Rows[cbTurmas.SelectedIndex -1][0],txtAluno.Text);
                            return;
                        }
                        dt.DataSource = MinhasListas.ListaComParametros(conexao, tbl, prof.getId(), cbbimestre.SelectedIndex, prof.getTipo(), (int)tblTurma.Rows[cbTurmas.SelectedIndex - 1][0], txtano.Text);
                        return;
                    }
                    if (txtAluno.Text != "")
                    {
                        //select bimestre + aluno
                        dt.DataSource = MinhasListas.ListaComParametros(conexao, tbl, prof.getId(), cbbimestre.SelectedIndex, prof.getTipo(),txtAluno.Text);
                        return;
                    }
                    dt.DataSource = MinhasListas.ListaComParametros(conexao, tbl, prof.getId(), cbbimestre.SelectedIndex, prof.getTipo(), txtano.Text);
                }
            }catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void cbTurmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
                if (cbTurmas.SelectedIndex > 0)
                {   //select turma
                    if (cbbimestre.SelectedIndex > 0)
                    {
                        //select turma + bemestre
                        if (txtAluno.Text != "")
                        {
                            //select turma + bimestre + aluno
                            dt.DataSource = MinhasListas.ListaComParametros(conexao, tbl, prof.getId(), cbbimestre.SelectedIndex, prof.getTipo(), (int)tblTurma.Rows[cbTurmas.SelectedIndex - 1][0], txtAluno.Text);
                            
                            return;
                        }
                        dt.DataSource = MinhasListas.ListaComParametros(conexao, tbl, prof.getId(), cbbimestre.SelectedIndex, prof.getTipo(), (int)tblTurma.Rows[cbTurmas.SelectedIndex - 1][0], txtano.Text);
                        return;
                    }

                    if (txtAluno.Text != "")
                    {
                        //select turma + aluno
                        //dt.DataSource = MinhasListas.ListaComParametros(conexao, tbl, prof.getId(), cbbimestre.SelectedIndex, prof.getTipo(), (int)tblTurma.Rows[cbTurmas.SelectedIndex - 1][0], txtAluno.Text);
                        dt.DataSource = MinhasListas.ListaComParametros(conexao, tbl,prof.getId(),prof.getTipo(),(int)tblTurma.Rows[cbTurmas.SelectedIndex -1][0],txtAluno.Text);
                        return;
                    }

                    dt.DataSource = MinhasListas.ListaComParametros(conexao, tbl, prof.getId(), prof.getTipo(), (int)tblTurma.Rows[cbTurmas.SelectedIndex - 1][0], txtano.Text);
                }
            }catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
            
            }
        }

        private void txtAluno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //select aluno
                if (txtAluno.Text != "")
                {
                    //select aluno + turma
                    if (cbTurmas.SelectedIndex > 0)
                    {
                        // select aluno + turma + bimestre
                        if (cbbimestre.SelectedIndex > 0)
                        {
                            dt.DataSource = MinhasListas.ListaComParametros(conexao, tbl, prof.getId(), cbbimestre.SelectedIndex, prof.getTipo(), (int)tblTurma.Rows[cbTurmas.SelectedIndex - 1][0], txtAluno.Text);

                            return;
                        }
                        dt.DataSource = MinhasListas.ListaComParametros(conexao, tbl, prof.getId(), prof.getTipo(), (int)tblTurma.Rows[cbTurmas.SelectedIndex - 1][0], txtAluno.Text);
                        return;
                    }
                    //select aluno + bimestre
                    if (cbbimestre.SelectedIndex > 0)
                    {
                        dt.DataSource = MinhasListas.ListaComParametros(conexao, tbl, prof.getId(), cbbimestre.SelectedIndex, prof.getTipo(), txtAluno.Text);
                        return;
                        
                    }
                    dt.DataSource = MinhasListas.ListaComParametros(conexao, tbl, prof.getId(), prof.getTipo(), txtAluno.Text, txtano.Text);

                }
                    
                        
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }
        private void valida(TextBox tex)
        {
            try
            {
                double valor = Convert.ToDouble(tex.Text);
                if (valor <= 10 && valor >= 0)
                {
                    if (valor >= 0 && valor < 6)
                    {
                        tex.BackColor = Color.LightCoral;
                        tex.ForeColor = Color.Red;

                    }
                    else
                    {

                        tex.ForeColor = Color.Blue;
                        tex.BackColor = Color.White;
                    }
                }
                else
                {
                    tex.Text = "";
                }
            }
            catch
            {
                tex.Text = "";
            }
        }
        private void Tport_TextChanged(object sender, EventArgs e)
        {


            valida(Tport);
        
        }

        private void Tmat_TextChanged(object sender, EventArgs e)
        {
            valida(Tmat);
        }

        private void Thist_TextChanged(object sender, EventArgs e)
        {
            valida(Thist);
        }

        private void Tgeog_TextChanged(object sender, EventArgs e)
        {
            valida(Tgeog);
        }

        private void Tcie_TextChanged(object sender, EventArgs e)
        {
            valida(Tcie);
        }

        private void Tart_TextChanged(object sender, EventArgs e)
        {
            valida(Tart);
        }

        private void Trel_TextChanged(object sender, EventArgs e)
        {
            valida(Trel);
        }

        private void Ting_TextChanged(object sender, EventArgs e)
        {
            valida(Ting);
        }

        private void Tfis_TextChanged(object sender, EventArgs e)
        {
            valida(Tfis);
        }
        private void valida2(TextBox Tport)
        {
            try
            {
                double valor = Convert.ToDouble(Tport.Text);
                Tport.Text = valor.ToString("0.0");
                
                
                
            }
            catch
            {
                Tport.Text = "0,0";
            }
            
        }
        private void Tport_Validated(object sender, EventArgs e)
        {
            valida2(Tport);
            
        }

        private void Tmat_Validated(object sender, EventArgs e)
        {
            valida2(Tmat);
        }

        private void Thist_Validated(object sender, EventArgs e)
        {
            valida2(Thist);
        }

        private void Tgeog_Validated(object sender, EventArgs e)
        {
            valida2(Tgeog);
        }

        private void Tcie_Validated(object sender, EventArgs e)
        {
            valida2(Tcie);
        }

        private void Tart_Validated(object sender, EventArgs e)
        {
            valida2(Tart);
        }

        private void Trel_Validated(object sender, EventArgs e)
        {
            valida2(Trel);
        }

        private void Ting_Validated(object sender, EventArgs e)
        {
            valida2(Ting);
            button1.Enabled = true;


        }

        private void Tfis_Validated(object sender, EventArgs e)
        {
            valida2(Tfis);
            button1.Enabled = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox [] meusText = {Tport, Tmat, Thist, Tgeog, Tcie, Tart, Trel, Ting, Tfis, Tfalt};
            
            RegrasDeNegocio neg = new RegrasDeNegocio(Convert.ToInt32(dt.Rows[indice].Cells["id_bimestre"].Value.ToString()),Convert.ToInt32(dt.Rows[indice].Cells["id_aluno"].Value.ToString()),conexao,meusText);
            neg.AtualizaNotas();
            MessageBox.Show("Nota Lançada com sucesso");
            neg.AtualizaGrid(meusText, dt, indice);
            button1.Enabled = false;
            
        }

        private void Tfalt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(Tfalt.Text);
                button1.Enabled = true;
            }
            catch
            {
                Tfalt.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        
    }
}
