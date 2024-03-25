using JogoGourmet.App.Forms;
using JogoGourmet.App.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet.App
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            JogoGourmetInit jogoGourmet = new JogoGourmetInit();

            jogoGourmet.ComecoJogo();
        }
    }
}
