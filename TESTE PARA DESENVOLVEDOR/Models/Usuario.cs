using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_PARA_DESENVOLVEDOR.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string NomeUsuario { get; set; }

        public string SenhaUsuario { get; set; }

        public List<Evento> Eventos { get; set; }
    }
}
