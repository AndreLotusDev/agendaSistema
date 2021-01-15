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
    public partial class ListDeUsuariosAConvidar : Form
    {
        public AgendaContext _context = new AgendaContext();
        public ListDeUsuariosAConvidar()
        {
            InitializeComponent();
        }

        private void listDeUsuariosAConvidar_Load(object sender, EventArgs e)
        {
            List<Usuario> usuarios = _context.Usuarios.ToList();

            var linhas = dataGridUsuarios.Rows;

            if(usuarios != null && usuarios.Count > 0)
            {
                for(int i = 0; i < usuarios.Count; i++)
                {
                    linhas.Add();
                    linhas[i].Cells[0].Value = usuarios[i].UsuarioId;
                    linhas[i].Cells[1].Value = usuarios[i].NomeUsuario;
                }
            }
        }
    }
}
