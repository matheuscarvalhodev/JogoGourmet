using System;
using System.Windows.Forms;

namespace JogoGourmet.App.Forms
{
    public partial class FormCustomMessageBox : Form
    {
        public FormCustomMessageBox()
        {
            InitializeComponent();
        }

        public DialogResult ShowMessageBox(string message, string title)
        {
            lblMessage.Text = message;
            Text = title;
            return ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ReturnOk();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ReturnOk();
            }
        }
        private void ReturnOk()
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
