namespace JogoGourmet.App.Forms
{
    partial class FormCustomInputBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomInputBox));
            this.txtBox_CustomInput = new System.Windows.Forms.TextBox();
            this.btn_CancelarComplete = new System.Windows.Forms.Button();
            this.btn_OkComplete = new System.Windows.Forms.Button();
            this.lblCustomInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_CustomInput
            // 
            this.txtBox_CustomInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_CustomInput.Location = new System.Drawing.Point(78, 91);
            this.txtBox_CustomInput.Name = "txtBox_CustomInput";
            this.txtBox_CustomInput.Size = new System.Drawing.Size(352, 26);
            this.txtBox_CustomInput.TabIndex = 2;
            this.txtBox_CustomInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_CustomInput_KeyPress);
            // 
            // btn_CancelarComplete
            // 
            this.btn_CancelarComplete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarComplete.Location = new System.Drawing.Point(281, 135);
            this.btn_CancelarComplete.MaximumSize = new System.Drawing.Size(90, 36);
            this.btn_CancelarComplete.MinimumSize = new System.Drawing.Size(90, 36);
            this.btn_CancelarComplete.Name = "btn_CancelarComplete";
            this.btn_CancelarComplete.Size = new System.Drawing.Size(90, 36);
            this.btn_CancelarComplete.TabIndex = 7;
            this.btn_CancelarComplete.Text = "Cancelar";
            this.btn_CancelarComplete.UseVisualStyleBackColor = true;
            this.btn_CancelarComplete.Click += new System.EventHandler(this.btn_CancelarComplete_Click);
            // 
            // btn_OkComplete
            // 
            this.btn_OkComplete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OkComplete.Location = new System.Drawing.Point(131, 135);
            this.btn_OkComplete.MaximumSize = new System.Drawing.Size(75, 36);
            this.btn_OkComplete.MinimumSize = new System.Drawing.Size(75, 36);
            this.btn_OkComplete.Name = "btn_OkComplete";
            this.btn_OkComplete.Size = new System.Drawing.Size(75, 36);
            this.btn_OkComplete.TabIndex = 6;
            this.btn_OkComplete.Text = "Ok";
            this.btn_OkComplete.UseVisualStyleBackColor = true;
            this.btn_OkComplete.Click += new System.EventHandler(this.btn_OkComplete_Click);
            // 
            // lblCustomInput
            // 
            this.lblCustomInput.AutoSize = true;
            this.lblCustomInput.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomInput.Location = new System.Drawing.Point(46, 38);
            this.lblCustomInput.MaximumSize = new System.Drawing.Size(415, 21);
            this.lblCustomInput.MinimumSize = new System.Drawing.Size(415, 21);
            this.lblCustomInput.Name = "lblCustomInput";
            this.lblCustomInput.Size = new System.Drawing.Size(415, 21);
            this.lblCustomInput.TabIndex = 8;
            this.lblCustomInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCustomInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 209);
            this.Controls.Add(this.lblCustomInput);
            this.Controls.Add(this.btn_CancelarComplete);
            this.Controls.Add(this.btn_OkComplete);
            this.Controls.Add(this.txtBox_CustomInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(525, 248);
            this.MinimumSize = new System.Drawing.Size(525, 248);
            this.Name = "FormCustomInputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCustomInputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_CustomInput;
        private System.Windows.Forms.Button btn_CancelarComplete;
        private System.Windows.Forms.Button btn_OkComplete;
        private System.Windows.Forms.Label lblCustomInput;
    }
}