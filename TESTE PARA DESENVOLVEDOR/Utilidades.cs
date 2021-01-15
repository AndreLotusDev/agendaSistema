using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTE_PARA_DESENVOLVEDOR
{
    static public class Utilidades
    {
        static public void MensagemErro(string mensagem)
        {
            MessageBox.Show("Error" + mensagem);
        }
    }
}
