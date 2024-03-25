using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet.App.Util
{
    public class Node
    {
        public string Value;
        public Node NoFilhoEsquerdo;
        public Node NoFilhoDireito;

        public Node(string data)
        {
            Value = data;
        }

        public bool EhFolha()
        {
            return NoFilhoEsquerdo == null && NoFilhoDireito == null;
        }

    }
}
