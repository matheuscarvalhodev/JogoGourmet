namespace JogoGourmet.App.Forms
{
    partial class FormCustomMessageErro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomMessageErro));
            this.lbl_Erro = new System.Windows.Forms.Label();
            this.btn_OkFimJogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Erro
            // 
            this.lbl_Erro.AutoSize = true;
            this.lbl_Erro.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Erro.Location = new System.Drawing.Point(35, 50);
            this.lbl_Erro.MaximumSize = new System.Drawing.Size(315, 22);
            this.lbl_Erro.MinimumSize = new System.Drawing.Size(315, 22);
            this.lbl_Erro.Name = "lbl_Erro";
            this.lbl_Erro.Size = new System.Drawing.Size(315, 22);
            this.lbl_Erro.TabIndex = 3;
            this.lbl_Erro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_OkFimJogo
            // 
            this.btn_OkFimJogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OkFimJogo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OkFimJogo.Location = new System.Drawing.Point(151, 115);
            this.btn_OkFimJogo.MaximumSize = new System.Drawing.Size(75, 36);
            this.btn_OkFimJogo.MinimumSize = new System.Drawing.Size(75, 36);
            this.btn_OkFimJogo.Name = "btn_OkFimJogo";
            this.btn_OkFimJogo.Size = new System.Drawing.Size(75, 36);
            this.btn_OkFimJogo.TabIndex = 4;
            this.btn_OkFimJogo.Text = "Ok";
            this.btn_OkFimJogo.UseVisualStyleBackColor = true;
            this.btn_OkFimJogo.Click += new System.EventHandler(this.btn_OkFimJogo_Click);
            // 
            // FormCustomMessageErro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 199);
            this.Controls.Add(this.btn_OkFimJogo);
            this.Controls.Add(this.lbl_Erro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(396, 238);
            this.MinimumSize = new System.Drawing.Size(396, 238);
            this.Name = "FormCustomMessageErro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Erro;
        private System.Windows.Forms.Button btn_OkFimJogo;
    }
}