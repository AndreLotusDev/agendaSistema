using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_PARA_DESENVOLVEDOR.Models
{
    public class Participante
    {
        public int ParticipanteId { get; set; }
        public string NomeParticipante { get; set; }


        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }
}
