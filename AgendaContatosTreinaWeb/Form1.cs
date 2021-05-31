using System;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Forms;

namespace AgendaContatosTreinaWeb
{

    public partial class frmAgendaContatos : Form
    {
        private OperacaoEnum acao;

        public frmAgendaContatos()
        {
            InitializeComponent();
        }

        private void frmAgendaContatos_Load(object sender, EventArgs e)
        {

        }

        private void frmAgendaContatos_Shown(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            CarregarListaContatos();
            AlterarEstadoCampos(false);
        }

        private void AlterarBotoesSalvarECancelar(bool estado)
        {
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;
        }

        private void AlterarBotoesIncluirAlterarExcluir(bool estado)
        {
            btnIncluir.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnExcluir.Enabled = estado;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarEstadoCampos(true);
            acao = OperacaoEnum.INCLUIR;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarEstadoCampos(true);
            acao = OperacaoEnum.ALTERAR;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            AlterarEstadoCampos(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato
                {
                    Nome = txbNome.Text,
                    Email = txbEmail.Text,
                    NumeroTelefone = txbNumeroTelefone.Text
                };

                List<Contato> contatosList = new List<Contato>();
                foreach (Contato contatoDaLista in lbxContatos.Items)
                {
                    contatosList.Add(contatoDaLista);
                }
                if (acao == OperacaoEnum.INCLUIR)
                {
                    if (txbNome.Text != "")
                        contatosList.Add(contato);
                    else
                        //goto ExceptionSave;
                        MessageBox.Show("Nada novo para salvar!");
                }
                else
                {
                    int indice = lbxContatos.SelectedIndex;
                    contatosList.RemoveAt(indice);
                    contatosList.Insert(indice, contato);
                }
                ManipuladorArquivos.EscreverArquivo(contatosList);
                CarregarListaContatos();
                AlterarBotoesSalvarECancelar(false);
                AlterarBotoesIncluirAlterarExcluir(true);
                LimparCampos();
                AlterarEstadoCampos(false);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar!");
            }
        //ExceptionSave:
        //    MessageBox.Show("Nada novo para salvar!");
        }

        private void CarregarListaContatos()
        {
            lbxContatos.Items.Clear();
            lbxContatos.Items.AddRange(ManipuladorArquivos.LerArquivo().ToArray());
            //lbxContatos.SelectedIndex;
        }

        private void LimparCampos()
        {
            txbNome.Text = "";
            txbEmail.Text = "";
            txbNumeroTelefone.Text = "";
        }

        private void AlterarEstadoCampos(bool estado)
        {
            txbNome.Enabled = estado;
            txbEmail.Enabled = estado;
            txbNumeroTelefone.Enabled = estado;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Contato contato = (Contato)lbxContatos.Items[lbxContatos.SelectedIndex];
                txbNome.Text = contato.Nome;
                txbEmail.Text = contato.Email;
                txbNumeroTelefone.Text = contato.NumeroTelefone;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione o obejto a ser alterado antes!");

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int indiceExcluido = lbxContatos.SelectedIndex;
                    lbxContatos.SelectedIndex = 0;
                    lbxContatos.Items.RemoveAt(indiceExcluido);
                    List<Contato> contatosList = new List<Contato>();
                    foreach (Contato contato in lbxContatos.Items)
                    {
                        contatosList.Add(contato);
                    }
                    ManipuladorArquivos.EscreverArquivo(contatosList);
                    CarregarListaContatos();
                    LimparCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não há ou não foram selecioandos itens para remover!");
                }

            }
        }
    }
}
