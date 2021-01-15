using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTE_PARA_DESENVOLVEDOR.Context;
using TESTE_PARA_DESENVOLVEDOR.Models;

namespace TESTE_PARA_DESENVOLVEDOR
{
    public partial class TelaCadastro : Form
    {
        AgendaContext _context = new AgendaContext();
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void BtnVoltaLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            EntryPoint entryPoint = new EntryPoint();
            entryPoint.ShowDialog();

            this.Close();
        }

        private void MostraSenha_Click(object sender, EventArgs e)
        {
            if (MostraSenha.Checked == true)
            {
                TxtSenha.UseSystemPasswordChar = true;
            }
            else
            {
                TxtSenha.UseSystemPasswordChar = false;
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TXTNomeCadastro.Text == "")
            {
                MessageBox.Show("Digite um nome de usuario!");
            }
            else if (TxtSenha.Text == "")
            {
                MessageBox.Show("Digite uma senha!");
            }
            else 
            {
                bool permiteCadastro = true;
                List<Usuario> usuarios = new List<Usuario>();
                try
                {
                    usuarios = _context.Usuarios.ToList();
                }
                catch (Exception ex)
                {
                    Utilidades.MensagemErro(ex.Message);
                }
                foreach (Usuario usuario in usuarios)
                {
                    if (TXTNomeCadastro.Text == usuario.NomeUsuario)
                    {
                        permiteCadastro = false;
                        MessageBox.Show("Ja existe usuario cadastrado com o este nome!");
                    }
                }
                if (permiteCadastro)
                {
                    Usuario novoUsuario = new Usuario()
                    {
                        UsuarioId = 0,
                        NomeUsuario = TXTNomeCadastro.Text,
                        SenhaUsuario = TxtSenha.Text,
                    };

                    try
                    {
                        _context.UpdateRange(novoUsuario);
                        _context.SaveChanges();

                        MessageBox.Show("Cadastro realizado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Utilidades.MensagemErro(ex.Message);
                    }
                }
            }
        }
    }
}
