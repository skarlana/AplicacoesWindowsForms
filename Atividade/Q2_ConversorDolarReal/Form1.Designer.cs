namespace Q2_ConversorDolarReal
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
            txtCotacao = new TextBox();
            label2 = new Label();
            txtDolares = new TextBox();
            btnConverter = new Button();
            lblResultado = new Label();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(189, 17);
            label1.TabIndex = 0;
            label1.Text = "Digite a cotação do Dólar (R$):";
            // 
            // txtCotacao
            // 
            txtCotacao.Location = new Point(207, 34);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(100, 23);
            txtCotacao.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(235, 17);
            label2.TabIndex = 2;
            label2.Text = "Digite a quantidade em dólares (US$): ";
            // 
            // txtDolares
            // 
            txtDolares.Location = new Point(244, 78);
            txtDolares.Name = "txtDolares";
            txtDolares.Size = new Size(100, 23);
            txtDolares.TabIndex = 3;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(172, 148);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 4;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(111, 202);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 17);
            lblResultado.TabIndex = 5;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(172, 246);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(423, 281);
            Controls.Add(btnLimpar);
            Controls.Add(lblResultado);
            Controls.Add(btnConverter);
            Controls.Add(txtDolares);
            Controls.Add(label2);
            Controls.Add(txtCotacao);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversor de Dólar para Real";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCotacao;
        private Label label2;
        private TextBox txtDolares;
        private Button btnConverter;
        private Label lblResultado;
        private Button btnLimpar;
    }
}
