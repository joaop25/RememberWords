namespace RemembersWords.Forms
{
    partial class SalvarWords
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
            label1 = new Label();
            txtWord = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Remember Word";
            // 
            // txtWord
            // 
            txtWord.Location = new Point(143, 35);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(242, 23);
            txtWord.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(143, 79);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(487, 63);
            txtDescription.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 82);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(272, 163);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(144, 33);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // SalvarWords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 208);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(txtWord);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SalvarWords";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalvarWords";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWord;
        private TextBox txtDescription;
        private Label label2;
        private Button btnSalvar;
    }
}