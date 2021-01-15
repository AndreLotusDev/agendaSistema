using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_PARA_DESENVOLVEDOR.Models
{
    public class EventoUsuario
    {
        public int EventoUsuarioId { get; set; }
        public string UsuarioPermitiuEventoNaLista { get; set; }

        public int EventoId { get; set; }
        public Evento Evento { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
