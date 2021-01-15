using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_PARA_DESENVOLVEDOR
{
    //Pseudo Singleton
    public static class Singleton
    {
        public class UsuarioLogado
        {
            public static int UserId { get; set; }
            public static string UsuarioNome { get; set; }
        }

        public class ListaConvidado
        {
            public static List<string> Convidados { get; set; } = new List<string>();
        }

        static public bool alteracaoDeEvento { get; set; } = false;
        static public int idDoEventoAlterado { get; set; }
    }
}
