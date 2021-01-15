using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_PARA_DESENVOLVEDOR.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime HorarioComeco { get; set; }
        public DateTime HorarioFim { get; set; }
        public string Local { get; set; }
        public string EventoTipo { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public List<Participante> Participantes { get; set; }
    }
}
