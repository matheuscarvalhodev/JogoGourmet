using System;
using System.Windows.Forms;

namespace JogoGourmet.App.Forms
{
    public partial class FormCustomMessageErro : Form
    {
        public FormCustomMessageErro(string message)
        {
            InitializeComponent();
            lbl_Erro.Text = message;
        }

        public DialogResult ShowMessageErroBox()
        {
            return ShowDialog();
        }

        private void btn_OkFimJogo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
