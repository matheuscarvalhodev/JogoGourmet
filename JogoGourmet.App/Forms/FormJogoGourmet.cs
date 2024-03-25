using JogoGourmet.App.Util;
using System;
using System.Windows.Forms;

namespace JogoGourmet.App.Forms
{
    public partial class FormJogoGourmet : Form
    {
        private bool closingFromOkButton = false;
        private bool ehAcerto = false;

        public FormJogoGourmet(string message, bool ehAcerto)
        {
            InitializeComponent();
            lbl_Texto.Text = message;
            this.FormClosing += FormJogoGourmet_FormClosing;
            this.FormClosed += FormJogoGourmet_FormClosed;
            this.ehAcerto = ehAcerto;
        }

        public DialogResult ShowBox()
        {
            return ShowDialog();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            closingFromOkButton = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FormJogoGourmet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !closingFromOkButton && ehAcerto == false)
            {
                Application.Exit();
            }
            if (ehAcerto)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void FormJogoGourmet_FormClosed(object sender, FormClosedEventArgs e)
        {
            closingFromOkButton = false;
        }
    }
}
