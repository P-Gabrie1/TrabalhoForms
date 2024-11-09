namespace frmPrincipal
{
    partial class Conversor
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
            btnConfirmar = new Button();
            lblSegundos = new Label();
            txtSegundo = new TextBox();
            txtHoras = new TextBox();
            lblResultado = new Label();
            lblMinutos = new Label();
            txtMinutos = new TextBox();
            textBox1 = new TextBox();
            lblSengu = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(65, 155);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblSegundos
            // 
            lblSegundos.AutoSize = true;
            lblSegundos.Location = new Point(65, 109);
            lblSegundos.Name = "lblSegundos";
            lblSegundos.Size = new Size(135, 20);
            lblSegundos.TabIndex = 1;
            lblSegundos.Text = "Insira os Segundos:";
            // 
            // txtSegundo
            // 
            txtSegundo.Location = new Point(217, 102);
            txtSegundo.Name = "txtSegundo";
            txtSegundo.Size = new Size(125, 27);
            txtSegundo.TabIndex = 2;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(77, 38);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(125, 27);
            txtHoras.TabIndex = 3;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(6, 45);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(51, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Horas:";
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Location = new Point(6, 109);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(65, 20);
            lblMinutos.TabIndex = 5;
            lblMinutos.Text = "Minutos:";
            // 
            // txtMinutos
            // 
            txtMinutos.Location = new Point(93, 156);
            txtMinutos.Name = "txtMinutos";
            txtMinutos.Size = new Size(125, 27);
            txtMinutos.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // lblSengu
            // 
            lblSengu.AutoSize = true;
            lblSengu.Location = new Point(6, 163);
            lblSengu.Name = "lblSengu";
            lblSengu.Size = new Size(81, 20);
            lblSengu.TabIndex = 8;
            lblSengu.Text = "Segundos: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblResultado);
            groupBox1.Controls.Add(txtMinutos);
            groupBox1.Controls.Add(lblSengu);
            groupBox1.Controls.Add(txtHoras);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblMinutos);
            groupBox1.Location = new Point(452, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 206);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resposta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 28);
            label1.Name = "label1";
            label1.Size = new Size(169, 23);
            label1.TabIndex = 10;
            label1.Text = "Conversor De Horas";
            // 
            // button1
            // 
            button1.Location = new Point(178, 155);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(291, 155);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Conversor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(txtSegundo);
            Controls.Add(lblSegundos);
            Controls.Add(btnConfirmar);
            Name = "Conversor";
            Text = "Conversor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private Label lblSegundos;
        private TextBox txtSegundo;
        private TextBox txtHoras;
        private Label lblResultado;
        private Label lblMinutos;
        private TextBox txtMinutos;
        private TextBox textBox1;
        private Label lblSengu;
        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}