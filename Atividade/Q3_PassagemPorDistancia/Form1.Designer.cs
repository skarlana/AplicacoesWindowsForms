namespace Q3_PassagemPorDistancia
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
            txtDistancia = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 33);
            label1.Name = "label1";
            label1.Size = new Size(282, 17);
            label1.TabIndex = 0;
            label1.Text = "Digite a distância em km que deseja percorrer:";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(155, 64);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(100, 23);
            txtDistancia.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(166, 105);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(91, 159);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 17);
            lblResultado.TabIndex = 3;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(166, 243);
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
            BackColor = Color.Thistle;
            ClientSize = new Size(418, 278);
            Controls.Add(btnLimpar);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtDistancia);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Preço da Passagem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDistancia;
        private Button btnCalcular;
        private Label lblResultado;
        private Button btnLimpar;
    }
}
