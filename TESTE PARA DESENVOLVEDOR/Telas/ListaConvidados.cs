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
    public partial class ListaConvidados : Form
    {
        public ListaConvidados()
        {
            InitializeComponent();
        }

        private void DgViewConvidados_Enter(object sender, EventArgs e)
        {
            if (Singleton.ListaConvidado.Convidados != null)
            {
                for (int i = 0; i < Singleton.ListaConvidado.Convidados.Count; i++)
                {
                    DgViewConvidados.Rows.Add();
                    DgViewConvidados.Rows[i].Cells[0].Value = Singleton.ListaConvidado.Convidados[i];
                }
            }
        }

        private void DgViewConvidados_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (DgViewConvidados.CurrentCell.Value != null)
                {
                    if (DgViewConvidados.CurrentCell.Value.ToString() != "")
                    {
                        DgViewConvidados.Rows.Add();
                    }
                }
            }
        }

        private void BtnSalvarConvidados_Click(object sender, EventArgs e)
        {
            bool permiteSalvar = false;
            Singleton.ListaConvidado.Convidados.Clear();
            var items = DgViewConvidados.Rows;
            
            for(int i = 0; i < items.Count; i++)
            {
                string valorDaCelulaAtual = Convert.ToString(items[i].Cells[0].Value);

                if(valorDaCelulaAtual.Trim() != "")
                {
                    Singleton.ListaConvidado.Convidados.Add(valorDaCelulaAtual);
                    permiteSalvar = true;
                }
            }

            if(permiteSalvar)
            {
                MessageBox.Show("Lista de convidados salva com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lista de convidados nao preenchida");
            }
        }
    }
}
