using System;
using System.Windows.Forms;

namespace JogoGourmet.App.Forms
{
    public partial class FormCustomInputBox : Form
    {
        public string UserInput { get; private set; }
        public FormCustomInputBox()
        {
            InitializeComponent();
        }

        public DialogResult ShowInputBox(string message, string title)
        {
            lblCustomInput.Text = message;
            Text = title;
            return ShowDialog();
        }

        private void btn_OkComplete_Click(object sender, EventArgs e)
        {
            ReturnInput();
        }


        private void btn_CancelarComplete_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtBox_CustomInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                ReturnInput();
            }
        }
        private void ReturnInput()
        {
            UserInput = txtBox_CustomInput.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
