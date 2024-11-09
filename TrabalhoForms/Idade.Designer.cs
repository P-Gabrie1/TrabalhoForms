namespace frmPrincipal
{
    partial class Idade
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
            dtDataNascimento = new DateTimePicker();
            lbData = new Label();
            txtMostrarIdade = new TextBox();
            lblIdade = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(190, 217);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // dtDataNascimento
            // 
            dtDataNascimento.Location = new Point(242, 135);
            dtDataNascimento.Name = "dtDataNascimento";
            dtDataNascimento.Size = new Size(250, 27);
            dtDataNascimento.TabIndex = 1;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Location = new Point(30, 140);
            lbData.Name = "lbData";
            lbData.Size = new Size(206, 20);
            lbData.TabIndex = 2;
            lbData.Text = "Insira sua Data denascimento:";
            // 
            // txtMostrarIdade
            // 
            txtMostrarIdade.Location = new Point(580, 135);
            txtMostrarIdade.Name = "txtMostrarIdade";
            txtMostrarIdade.Size = new Size(125, 27);
            txtMostrarIdade.TabIndex = 3;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(511, 140);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(50, 20);
            lblIdade.TabIndex = 4;
            lblIdade.Text = "Idade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 53);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 5;
            label1.Text = "Idade Do Usuario";
            // 
            // button1
            // 
            button1.Location = new Point(320, 217);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(439, 217);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Idade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lblIdade);
            Controls.Add(txtMostrarIdade);
            Controls.Add(lbData);
            Controls.Add(dtDataNascimento);
            Controls.Add(btnConfirmar);
            Name = "Idade";
            Text = "Idade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private DateTimePicker dtDataNascimento;
        private Label lbData;
        private TextBox txtMostrarIdade;
        private Label lblIdade;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}