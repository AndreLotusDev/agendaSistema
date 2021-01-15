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
    public partial class NovoEvento : Form
    {
        public AgendaContext _context = new AgendaContext();
        public NovoEvento()
        {
            InitializeComponent();
        }

        private void BtnConvidados_Click(object sender, EventArgs e)
        {
            ListaConvidados listaConvidados = new ListaConvidados();

            listaConvidados.ShowDialog();
        }

        #region BUTTON SALVAR
        private void BtnSalvarEvento_Click(object sender, EventArgs e)
        {
            if(Singleton.alteracaoDeEvento == false)
            {
                //Checa as validacoes antes
                if (Singleton.ListaConvidado.Convidados.Count == 0)
                {
                    MessageBox.Show("Preencha a lista de convidados");
                }
                else if (DataFim.Value <= DateTime.Now)
                {
                    MessageBox.Show("A data de saida tem q ser maior que a data de hoje");
                }
                else if (DataComeco.Value <= DateTime.Now)
                {
                    MessageBox.Show("A data de comeco tem q ser maior que a data de hoje");
                }
                else if (DataComeco.Value >= DataFim.Value)
                {
                    MessageBox.Show("A data estao com horarios incompativeis");
                }
                else if (TxtEventoLocal.Text.Trim() == "")
                {
                    MessageBox.Show("Preencha o local !");
                }
                else if (TxtEventoNome.Text.Trim() == "")
                {
                    MessageBox.Show("Preencha o nome do evento!");
                }
                else if (TxtDescricao.Text.Trim() == "")
                {
                    MessageBox.Show("Preencha a descricao");
                }
                else
                {
                    bool permiteSalvarNoBanco = true;
                    //Faz uma validacao pra ver se vc ja tem um evento em tal horario
                    //Se o horario de um evento ja marcado bater, vai retornar o item de uma lista
                    List<Evento> comparacaoDeEventoPorHorario = _context.Eventos.ToList();

                    foreach (var item in comparacaoDeEventoPorHorario)
                    {
                        if (item.HorarioComeco > DataComeco.Value && item.HorarioComeco > DataFim.Value)
                        {

                        }
                        else if (item.HorarioFim < DataComeco.Value && item.HorarioFim < DataFim.Value)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Em sua agenda de eventos, dentro do horario estipulado já existe um evento nesse horario");
                            permiteSalvarNoBanco = false;
                            break;
                        }
                    }

                    if (permiteSalvarNoBanco)
                    {
                        string tipoEvento;
                        if (RBtnExclusivo.Checked)
                        {
                            tipoEvento = "Exclusivo";
                        }
                        else
                        {
                            tipoEvento = "Compartilhado";
                        }

                        var _evento = new Evento()
                        {
                            EventoId = 0,
                            Descricao = TxtDescricao.Text,
                            EventoTipo = tipoEvento,
                            Local = TxtEventoLocal.Text.Trim(),
                            Nome = TxtEventoNome.Text.Trim(),
                            UsuarioId = Singleton.UsuarioLogado.UserId,
                            HorarioComeco = DataComeco.Value,
                            HorarioFim = DataFim.Value,
                        };

                        try
                        {
                            _context.Update(_evento);
                            _context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            Utilidades.MensagemErro(ex.Message);
                        }

                        List<Participante> participantes = new List<Participante>();
                        foreach (var participante in Singleton.ListaConvidado.Convidados)
                        {
                            participantes.Add(new Participante
                            {
                                ParticipanteId = 0,
                                EventoId = _evento.EventoId,
                                NomeParticipante = participante
                            });
                        }

                        try
                        {
                            _context.UpdateRange(participantes);
                            _context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            Utilidades.MensagemErro(ex.Message);
                        }
                        //Implementar com mais de um usuario, com a lista de amizade
                        EventoUsuario eventoUsuario = new EventoUsuario()
                        {
                            EventoId = _evento.EventoId,
                            UsuarioId = Singleton.UsuarioLogado.UserId,
                        };

                        var dialogResult = MessageBox.Show("Operacao realizada com sucesso!", "Deseja cadastrar mais um evento?", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            TxtDescricao.Text = "";
                            TxtEventoLocal.Text = "";
                            TxtEventoNome.Text = "";

                            Singleton.ListaConvidado.Convidados.Clear();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }       
            else
            {
                //OPERACAO PARA ALTERAR
            }
        }
        #endregion

        private void BtnSalvarEvento_Enter(object sender, EventArgs e)
        {

        }

        private void NovoEvento_Load(object sender, EventArgs e)
        {
            if(Singleton.alteracaoDeEvento)
            {
                Evento evento = _context.Eventos.Where(w => w.EventoId == Singleton.idDoEventoAlterado).FirstOrDefault();

                Singleton.ListaConvidado.Convidados.Clear();
                if(Singleton.ListaConvidado.Convidados != null)
                {
                    List<Participante> participantes = _context.Participantes.Where(w => w.EventoId == Singleton.idDoEventoAlterado).ToList();
                    List<string> convidados = new List<string>();
                    foreach (var item in participantes)
                    {
                        convidados.Add(item.NomeParticipante);
                    }
                    Singleton.ListaConvidado.Convidados.AddRange(convidados);
                }

                TxtDescricao.Text = evento.Descricao;
                TxtEventoLocal.Text = evento.Local;
                TxtEventoNome.Text = evento.Nome;
                
                if(evento.EventoTipo == "Compartilhado")
                {
                    RBtnCompartilhado.Checked = true;
                }
                else
                {
                    RBtnExclusivo.Checked = true;
                }
            }
        }

        private void btnOutrosUsuarios_Click(object sender, EventArgs e)
        {
            ListDeUsuariosAConvidar listDeUsuariosAConvidar = new ListDeUsuariosAConvidar();
            listDeUsuariosAConvidar.ShowDialog();
        }
    }
}
