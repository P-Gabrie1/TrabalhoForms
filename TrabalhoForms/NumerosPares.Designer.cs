namespace frmPrincipal
{
    partial class NumerosPares
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtSegundoValor = new TextBox();
            txtPrimeiroValor = new TextBox();
            btnLimpar = new Button();
            btnSair = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(71, 259);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 134);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 2;
            label1.Text = "Primeiro Valor:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 193);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 3;
            label2.Text = "Segundo Valor:";
            // 
            // txtSegundoValor
            // 
            txtSegundoValor.Location = new Point(147, 186);
            txtSegundoValor.Name = "txtSegundoValor";
            txtSegundoValor.Size = new Size(125, 27);
            txtSegundoValor.TabIndex = 4;
            // 
            // txtPrimeiroValor
            // 
            txtPrimeiroValor.Location = new Point(144, 127);
            txtPrimeiroValor.Name = "txtPrimeiroValor";
            txtPrimeiroValor.Size = new Size(125, 27);
            txtPrimeiroValor.TabIndex = 5;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(202, 259);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(336, 259);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(219, 45);
            label3.Name = "label3";
            label3.Size = new Size(217, 23);
            label3.TabIndex = 8;
            label3.Text = "Tabela De Numeros Pares";
            // 
            // NumerosPares
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(txtPrimeiroValor);
            Controls.Add(txtSegundoValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "NumerosPares";
            Text = "NumerosPares";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtSegundoValor;
        private TextBox txtPrimeiroValor;
        private Button btnLimpar;
        private Button btnSair;
        private Label label3;
    }
}