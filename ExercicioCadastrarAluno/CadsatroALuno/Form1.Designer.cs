namespace CadsatroALuno
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtEmail = new TextBox();
            btnCadastrar = new Button();
            dgvAlunosCadastrar = new DataGridView();
            lbName = new Label();
            lbEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlunosCadastrar).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(62, 62);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(210, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(316, 62);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(207, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(62, 104);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(461, 77);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dgvAlunosCadastrar
            // 
            dgvAlunosCadastrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunosCadastrar.Location = new Point(62, 197);
            dgvAlunosCadastrar.Name = "dgvAlunosCadastrar";
            dgvAlunosCadastrar.Size = new Size(461, 322);
            dgvAlunosCadastrar.TabIndex = 3;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(62, 33);
            lbName.Name = "lbName";
            lbName.Size = new Size(40, 15);
            lbName.TabIndex = 4;
            lbName.Text = "Nome";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(316, 33);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(41, 15);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "E-mail";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 551);
            Controls.Add(lbEmail);
            Controls.Add(lbName);
            Controls.Add(dgvAlunosCadastrar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlunosCadastrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private Button btnCadastrar;
        private DataGridView dgvAlunosCadastrar;
        private Label lbName;
        private Label lbEmail;
    }
}
