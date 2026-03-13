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
            lboxTabuada = new ListBox();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(304, 17);
            label1.TabIndex = 0;
            label1.Text = "Digite um número para ver sua tabuada de 0 a 10:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 62);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(12, 110);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(100, 23);
            btnGerar.TabIndex = 2;
            btnGerar.Text = "Ver Tabuada";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // lboxTabuada
            // 
            lboxTabuada.FormattingEnabled = true;
            lboxTabuada.ItemHeight = 15;
            lboxTabuada.Location = new Point(339, 32);
            lboxTabuada.Name = "lboxTabuada";
            lboxTabuada.Size = new Size(149, 199);
            lboxTabuada.TabIndex = 3;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(377, 250);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(543, 285);
            Controls.Add(btnLimpar);
            Controls.Add(lboxTabuada);
            Controls.Add(btnGerar);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Mostrar Tabuada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnGerar;
        private ListBox lboxTabuada;
        private Button btnLimpar;
    }
}
