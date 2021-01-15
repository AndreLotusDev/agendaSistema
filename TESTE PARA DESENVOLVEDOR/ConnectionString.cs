using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_PARA_DESENVOLVEDOR
{
    static public class ConnectionString
    {
        static public string Location { get; } = "Data Source=2.tcp.ngrok.io,19816;Network Library=DBMSSOCN;Initial Catalog=AgendaCliente;User ID=agendaUserAdmin;Password=agendaUserAdmin;";
    }
}
