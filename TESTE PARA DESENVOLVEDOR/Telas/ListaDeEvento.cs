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

namespace TESTE_PARA_DESENVOLVEDOR.Telas
{
    public partial class ListaDeEventos : Form
    {
        public AgendaContext _context = new AgendaContext();
        public ListaDeEventos()
        {
            InitializeComponent();
        }

        private void ListaDeEventos_Enter(object sender, EventArgs e)
        {

        }

        private void ListaDeEventos_Load(object sender, EventArgs e)
        {
            int id = Singleton.UsuarioLogado.UserId;

            var grid = DataEventos.Rows;

            List<Evento> eventos = _context.Eventos.Where(w => w.UsuarioId == id).ToList();

            if (eventos != null && eventos.Count > 0)
            {
                for (int i = 0; i < eventos.Count; i++)
                {
                    grid.Add();
                    grid[i].Cells[0].Value = eventos[i].EventoId;
                    grid[i].Cells[1].Value = eventos[i].Nome;
                    grid[i].Cells[2].Value = eventos[i].Local;
                    grid[i].Cells[3].Value = eventos[i].HorarioComeco;
                    grid[i].Cells[4].Value = eventos[i].HorarioFim;
                    //5 
                    //6 Sao Edit e Delete
                }
            }
        }

        private void DataEventos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Editar e excluir
            if (e.ColumnIndex == 5)
            {
                var decisaoTomada = MessageBox.Show("Edição do evento atual", "Deseja alterar o evento atual?", MessageBoxButtons.YesNo);

                if (decisaoTomada == DialogResult.Yes)
                {
                    //Abre a modal de evento preenchida
                    Singleton.alteracaoDeEvento = true;
                    var rowSelecionada = DataEventos.Rows;
                    int valueId = Convert.ToInt32(rowSelecionada[e.RowIndex].Cells[0].Value);
                    Singleton.idDoEventoAlterado = valueId;
                    NovoEvento novoEvento = new NovoEvento();
                    novoEvento.ShowDialog();
                }
                else
                {
                    Singleton.alteracaoDeEvento = false ;
                    //Nada acontece ainda
                }
            }
            else if (e.ColumnIndex == 6)
            {

            }
        }
    }
}
