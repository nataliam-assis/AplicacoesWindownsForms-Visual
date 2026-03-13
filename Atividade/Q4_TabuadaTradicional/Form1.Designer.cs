namespace Q4_TabuadaTradicional
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
            txtNumero = new TextBox();
            btnGerar = new Button();
            lstTabuada = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 50);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(89, 47);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(89, 90);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(75, 23);
            btnGerar.TabIndex = 2;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // lstTabuada
            // 
            lstTabuada.FormattingEnabled = true;
            lstTabuada.ItemHeight = 15;
            lstTabuada.Location = new Point(69, 131);
            lstTabuada.Name = "lstTabuada";
            lstTabuada.Size = new Size(120, 94);
            lstTabuada.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 258);
            Controls.Add(lstTabuada);
            Controls.Add(btnGerar);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tabuada Tradicional";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnGerar;
        private ListBox lstTabuada;
    }
}
