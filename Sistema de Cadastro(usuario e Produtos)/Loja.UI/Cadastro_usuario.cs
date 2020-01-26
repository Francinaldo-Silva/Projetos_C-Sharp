using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.DTO;
using Loja.BLL;

namespace Loja.UI
{
    public partial class Cadastro_usuario : Form
    {
        string modo = "";
        public Cadastro_usuario()
        {
            InitializeComponent();
        }

        private void Cadastro_usuario_Load(object sender, EventArgs e)
        {

            //carregaGrid();
            
        }
      /* private void carregaGrid()
       {
            try
            {
                IList<usuario_DTO> listUsuario_DTO = new List<usuario_DTO>();
                listUsuario_DTO = new UsuarioBLL().cargaUsuario();
                dataGridView1.DataSource = listUsuario_DTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
            */
        

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar_campos();
            txtCadastro.Text = Convert.ToString(System.DateTime.Now);
            modo = "novo";
        }
        private void limpar_campos()
        {
            txtNome.Text = "";
            txtLogin.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtCadastro.Text = "";
            cboPerfil.Text = "";
            cboSituacao.Text = "";
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            /*modo = "altera";
            if (codUsuSelecionado < 0)
            {
                lblMensagem.Text = "Selecione um usuario antes de prosseguir";
                return;
            }
            modo = "altera";*/
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            /*if (codUsuSelecionado < 0)
            {
                lblMensagem.Text = "Selecione um usuario antes";
                return;
            }
            else
            {
                lblMensagem.Text = "";
                modo = "excluir";
                MessageBox.Show("Para excluir o usuario, clique em Confirmar");
            }*/

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (modo == "novo")
            {
                /*Tratamento de Erros, exibe msg*/
                try
                {

                    /*Objeto USU */
                    usuario_DTO USU = new usuario_DTO();
                    USU.nome = txtNome.Text;
                    USU.login = txtLogin.Text;
                    USU.email = txtEmail.Text;
                    USU.cadastro = System.DateTime.Now;
                    USU.senha = txtSenha.Text;
                    if (cboSituacao.Text == "Ativo")
                    {
                        USU.situacao = "A";
                    }
                    else
                    {
                        USU.situacao = "I";
                    }
                    switch (cboPerfil.Text)
                    {
                        case "Administrador":
                            USU.perfil = 1;
                            break;
                        case "Operador":
                            USU.perfil = 2;
                            break;
                        case "Gerencial":
                            USU.perfil = 3;
                            break;
                    }
                    /*Método insere usuário na classe UsuarioBLL*/
                    int x = new UsuarioBLL().insereUsuario(USU);

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado" + ex.Message);
                }
            }
            modo = "";

        }

       /* private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int sel = dataGridView1.CurrentRow.Index;
            

            txtNome.Text = Convert.ToString(dataGridView1["nome", sel].Value);
            txtLogin.Text = Convert.ToString(dataGridView1["login", sel].Value);
            txtEmail.Text = Convert.ToString(dataGridView1["email", sel].Value);
            txtSenha.Text = Convert.ToString(dataGridView1["senha", sel].Value);
            txtCadastro.Text = Convert.ToString(dataGridView1["cadastro", sel].Value);
            

            if (Convert.ToString(dataGridView1["situacao", sel].Value) == "A")
            {
                cboSituacao.Text = "Ativo";
            }
            else
            {
                cboSituacao.Text = "Inativo";
            }
            switch (Convert.ToString(dataGridView1["perfil", sel].Value))
            { Caso seja 1, será escolhido Administrados, caso seja 2, operador * e caso 3, Gerencial
                case "1":
                   
               cboPerfil.Text = "Administrador";
                    break;
                case "2": 
                    cboPerfil.Text = "Operador";
                    break;
                case "3": 
                    cboPerfil.Text = "Gerencial"; 
                    break;
            }*/
        //}
    }
    
}
