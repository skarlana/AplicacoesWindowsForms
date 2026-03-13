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
            label2 = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            btnAdicionar = new Button();
            lboxPessoas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 0;
            label1.Text = "Digite o NOME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(281, 19);
            label2.Name = "label2";
            label2.Size = new Size(210, 17);
            label2.TabIndex = 1;
            label2.Text = "Digite a idade (somente números):";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(186, 23);
            txtNome.TabIndex = 2;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(281, 42);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(12, 89);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lboxPessoas
            // 
            lboxPessoas.FormattingEnabled = true;
            lboxPessoas.ItemHeight = 15;
            lboxPessoas.Location = new Point(92, 189);
            lboxPessoas.Name = "lboxPessoas";
            lboxPessoas.Size = new Size(316, 139);
            lboxPessoas.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(508, 376);
            Controls.Add(lboxPessoas);
            Controls.Add(btnAdicionar);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Button btnAdicionar;
        private ListBox lboxPessoas;
    }
}
