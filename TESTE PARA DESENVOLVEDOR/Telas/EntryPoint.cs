using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//SQL Server CE
using System.Data.SqlServerCe;
using TESTE_PARA_DESENVOLVEDOR.Context;
using TESTE_PARA_DESENVOLVEDOR.Models;
using TESTE_PARA_DESENVOLVEDOR.Telas;

namespace TESTE_PARA_DESENVOLVEDOR
{
    public partial class EntryPoint : Form
    {
        public AgendaContext _context = new AgendaContext();
        public EntryPoint()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool logado = false;

            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o usuario");
            }
            else if (TxtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Preencha a senha");
            }
            else
            {
                List<Usuario> usuarios = new List<Usuario>();
                try
                {
                    usuarios = _context.Usuarios.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                string usuarioTXT = TxtNome.Text.Trim();
                string senhaTXT = TxtSenha.Text.Trim();
                foreach (Usuario usuario in usuarios)
                {
                    if (usuarioTXT == usuario.NomeUsuario && senhaTXT == usuario.SenhaUsuario)
                    {
                        var resultadoMensagem = MessageBox.Show("Deseja entrar?", "Logado com sucesso!", MessageBoxButtons.YesNo);

                        if (resultadoMensagem == DialogResult.Yes)
                        {
                            this.Hide();
                            Singleton.UsuarioLogado.UserId = usuario.UsuarioId;
                            Singleton.UsuarioLogado.UsuarioNome = usuario.NomeUsuario;
                            //Fazer as alterações

                            TelaDoUsuarioLogado telaDoUsuarioLogado = new TelaDoUsuarioLogado();
                            telaDoUsuarioLogado.ShowDialog();

                            this.Close();
                        }
                        else
                        {
                            TxtNome.Text = "";
                            TxtSenha.Text = "";
                        }

                        logado = true;
                        break;
                    }
                }

                if (!logado)
                {
                    MessageBox.Show("Usuario e senha incorreto");
                }
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.ShowDialog();

            this.Close();
        }

        private void CheckSenhaLogin_Click(object sender, EventArgs e)
        {
            if (CheckSenhaLogin.Checked == true)
            {
                TxtSenha.UseSystemPasswordChar = true;
            }
            else
            {
                TxtSenha.UseSystemPasswordChar = false;
            }
        }
    }
}
