using System;

namespace JogoGourmet.App.Util
{
    public class ArvoreBinaria
    {
        public Node Raiz;

        public void Inserir(Node noPai, string value, bool escolhido)
        {
            Raiz = InserirNovoNo(noPai, value, escolhido);
        }

        public void MostrarArvore(Node noRaiz)
        {
            if (noRaiz != null)
            {
                Console.WriteLine(noRaiz.Value);
                MostrarArvore(noRaiz.NoFilhoEsquerdo);
                MostrarArvore(noRaiz.NoFilhoDireito);
            }
        }

        public bool EhVazio()
        {
            return Raiz == null;
        }

        private Node InserirNovoNo(Node noPai, string value, bool escolhido)
        {
            if (noPai == null)
            {
                noPai = new Node(value);
                return noPai;
            }
            else if (escolhido)
            {
                noPai.NoFilhoDireito = InserirNovoNo(noPai.NoFilhoDireito, value, escolhido);
            }
            else
            {
                noPai.NoFilhoEsquerdo = InserirNovoNo(noPai.NoFilhoEsquerdo, value, escolhido);
            }

            return noPai;
        }
    }
}
