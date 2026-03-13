namespace Q5_CadastroSimples
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
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtIdade = new TextBox();
            btnAdicionar = new Button();
            lstPessoas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(61, 23);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 26);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Idade:";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(247, 23);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(157, 65);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lstPessoas
            // 
            lstPessoas.FormattingEnabled = true;
            lstPessoas.ItemHeight = 15;
            lstPessoas.Location = new Point(12, 102);
            lstPessoas.Name = "lstPessoas";
            lstPessoas.Size = new Size(382, 199);
            lstPessoas.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 316);
            Controls.Add(lstPessoas);
            Controls.Add(btnAdicionar);
            Controls.Add(txtIdade);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sistema de Cadastro Simples";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtIdade;
        private Button btnAdicionar;
        private ListBox lstPessoas;
    }
}
