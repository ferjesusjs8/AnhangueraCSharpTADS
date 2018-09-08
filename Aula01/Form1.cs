using Aula01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01
{
    public partial class Form1 : Form
    {
        private DAL_Usuario conecta = new DAL_Usuario(@"Data Source=.\TEW_SQLEXPRESS;Initial Catalog=Aula01;Integrated Security=TRUE");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            int insere;
            try
            {
                Usuario usuario = new Usuario();
                usuario.Nome = txtNome.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;

                insere = conecta.InsereUsuario(usuario);
            }
            catch (Exception ex)
            {
                insere = 0;
            }

            if (insere == 1)
            {
                txtNome.Text = "";
                txtEmail.Text = "";
                txtSenha.Text = "";
                lblMensagem.ForeColor = System.Drawing.SystemColors.HotTrack;
                lblMensagem.Text = "Cadastro realizado com sucesso.";
            }
            else
            {
                lblMensagem.ForeColor = System.Drawing.Color.Red;
                lblMensagem.Text = "Ocorreu algum problema.";
            }
        }

        private void btnCadastro_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Usuario> lista = conecta.ListaUsuario();

            listaUsuarios.DataSource = lista;
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            List<Usuario> lista = conecta.ListaUsuario();

            listaUsuarios.DataSource = lista;
        }
    }
}
