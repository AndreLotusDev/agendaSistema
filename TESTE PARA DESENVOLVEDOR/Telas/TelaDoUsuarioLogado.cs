using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTE_PARA_DESENVOLVEDOR.Telas
{
    public partial class TelaDoUsuarioLogado : Form
    {
        public TelaDoUsuarioLogado()
        {
            InitializeComponent();
        }

        private void TelaDoUsuarioLogado_Activated(object sender, EventArgs e)
        {
            LblNome.Text = Singleton.UsuarioLogado.UsuarioNome;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            EntryPoint entryPoint = new EntryPoint();
            entryPoint.ShowDialog();

            this.Close();
        }

        private void BtnCriarNovoEvento_Click(object sender, EventArgs e)
        {
            NovoEvento novoEvento = new NovoEvento();

            novoEvento.ShowDialog();
        }

        private void BtnVisualizarEvento_Click(object sender, EventArgs e)
        {
            ListaDeEventos listaDeEventos = new ListaDeEventos();
            listaDeEventos.ShowDialog();
        }
    }
}
