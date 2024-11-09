namespace frmPrincipal
{
    partial class Notas
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
            btnCalcular = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            txtNota = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(37, 227);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // button2
            // 
            button2.Location = new Point(153, 227);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Limpar";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(265, 227);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 139);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 3;
            label1.Tag = ":";
            label1.Text = "Insira sua Nota:";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(153, 136);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(125, 27);
            txtNota.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(233, 77);
            label4.Name = "label4";
            label4.Size = new Size(179, 23);
            label4.TabIndex = 9;
            label4.Text = "Resultados das Notas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 184);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 10;
            label2.Text = "Resultado:";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(153, 177);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(125, 27);
            txtResultado.TabIndex = 11;
            // 
            // Notas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txtNota);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnCalcular);
            Name = "Notas";
            Text = "Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button button2;
        private Button button3;
        private Label label1;
        private TextBox txtNota;
        private Label label4;
        private Label label2;
        private TextBox txtResultado;
    }
}