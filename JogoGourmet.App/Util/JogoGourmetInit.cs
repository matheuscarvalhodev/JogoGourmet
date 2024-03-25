using JogoGourmet.App.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet.App.Util
{
    public class JogoGourmetInit
    {
        private readonly ArvoreBinaria arvore = new ArvoreBinaria();
        private bool flagLoop = true;

        public JogoGourmetInit()
        {
            PreencheListaInicial();
        }

        private void PreencheListaInicial()
        {
            arvore.Inserir(null, "Massa", true);
            arvore.Inserir(arvore.Raiz, "Lasanha", true);
            arvore.Inserir(arvore.Raiz, "Bolo de chocolate", false);
        }

        public void ComecoJogo()
        {
            FormJogoGourmet formJogoGourmet = new FormJogoGourmet("Pense em um prato que goste", false);
            DialogResult resposta = formJogoGourmet.ShowBox();
            if (resposta == DialogResult.OK)
            {
                while (flagLoop)
                {
                    AdivinharPrato(arvore.Raiz);
                }
            }
            else
            {
                flagLoop = false;
            }
        }

        private void AdivinharPrato(Node node)
        {
            FormCustomMessageBox customMessageBox = new FormCustomMessageBox();

            string question = "O prato que você pensou é " + node.Value + "?";
            DialogResult resposta = customMessageBox.ShowMessageBox(question, "Confirm");

            if (resposta == DialogResult.OK)
            {
                if (node.EhFolha())
                {
                    Acerto();
                }
                else
                {
                    AdivinharPrato(node.NoFilhoDireito);
                }
            }
            else
            {
                if (node.NoFilhoDireito == null)
                {
                    PerguntaNovoPrato(node);
                    ComecoJogo();
                }
                else
                {
                    AdivinharPrato(node.NoFilhoEsquerdo);
                }
            }
        }

        private void Acerto()
        {
            FormJogoGourmet acerto = new FormJogoGourmet("Acertei de novo!", true);
            DialogResult resposta = acerto.ShowBox();
            if (resposta == DialogResult.OK)
            {
                ComecoJogo();
            }
            else
            {
                ComecoJogo();
            }
        }

        private void PerguntaNovoPrato(Node node)
        {
            string prato = "";
            string tipoPrato = "";

            FormCustomInputBox inputBoxNovoPrato = new FormCustomInputBox();
            prato = Verifica(inputBoxNovoPrato, "Qual prato você pensou?", "Complete", "Insira um novo prato");
            FormCustomInputBox inputBoxNovoTipo = new FormCustomInputBox();
            tipoPrato = Verifica(inputBoxNovoTipo, prato + " é ______ mas " + node.Value + " não.", "Complete", "Insira um novo tipo de prato");

            AtualizaPrato(node, tipoPrato, prato);
        }

        private string Verifica(FormCustomInputBox form, string mensagem, string titulo, string mensagemErro)
        {
            string resultado = "";
            while (true)
            {
                DialogResult resposta = form.ShowInputBox(mensagem, titulo);

                if (resposta == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(form.UserInput))
                    {
                        resultado = form.UserInput;
                        break;
                    }
                    else
                    {
                        FormCustomMessageErro messageErro = new FormCustomMessageErro(mensagemErro);
                        messageErro.ShowMessageErroBox();
                    }
                }
                else
                {
                    FormCustomMessageErro messageErro = new FormCustomMessageErro(mensagemErro);
                    messageErro.ShowMessageErroBox();
                }
            }
            return resultado;
        }

        private void AtualizaPrato(Node node, string tipoPrato, string prato)
        {
            string respostaErrada = node.Value;
            node.Value = tipoPrato;
            node.NoFilhoEsquerdo = new Node(respostaErrada);
            node.NoFilhoDireito = new Node(prato);
        }

    }
}
