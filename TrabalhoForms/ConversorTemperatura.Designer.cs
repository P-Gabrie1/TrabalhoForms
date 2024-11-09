namespace frmPrincipal
{
    partial class ConversorTemperatura
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
            label1 = new Label();
            txtCelsius = new TextBox();
            radioButton1 = new RadioButton();
            btnkenvin = new RadioButton();
            groupBox1 = new GroupBox();
            txtResultado2 = new TextBox();
            txtResultado1 = new TextBox();
            btnFahrenheit = new RadioButton();
            btnConfirmar = new Button();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 99);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Insira a temperatura:";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(163, 92);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(125, 27);
            txtCelsius.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(389, 95);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnkenvin
            // 
            btnkenvin.AutoSize = true;
            btnkenvin.Location = new Point(11, 54);
            btnkenvin.Name = "btnkenvin";
            btnkenvin.Size = new Size(73, 24);
            btnkenvin.TabIndex = 3;
            btnkenvin.TabStop = true;
            btnkenvin.Text = "Kelvin:";
            btnkenvin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtResultado2);
            groupBox1.Controls.Add(txtResultado1);
            groupBox1.Controls.Add(btnFahrenheit);
            groupBox1.Controls.Add(btnkenvin);
            groupBox1.Location = new Point(378, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 200);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultado";
            // 
            // txtResultado2
            // 
            txtResultado2.Location = new Point(119, 118);
            txtResultado2.Name = "txtResultado2";
            txtResultado2.Size = new Size(125, 27);
            txtResultado2.TabIndex = 7;
            // 
            // txtResultado1
            // 
            txtResultado1.Location = new Point(90, 51);
            txtResultado1.Name = "txtResultado1";
            txtResultado1.Size = new Size(125, 27);
            txtResultado1.TabIndex = 6;
            // 
            // btnFahrenheit
            // 
            btnFahrenheit.AutoSize = true;
            btnFahrenheit.Location = new Point(11, 121);
            btnFahrenheit.Name = "btnFahrenheit";
            btnFahrenheit.Size = new Size(105, 24);
            btnFahrenheit.TabIndex = 5;
            btnFahrenheit.TabStop = true;
            btnFahrenheit.Text = " Fahrenheit:";
            btnFahrenheit.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(39, 151);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(181, 20);
            label2.Name = "label2";
            label2.Size = new Size(222, 23);
            label2.TabIndex = 9;
            label2.Text = "Conversor de Temperatura";
            // 
            // button1
            // 
            button1.Location = new Point(137, 151);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(237, 155);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ConversorTemperatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(btnConfirmar);
            Controls.Add(groupBox1);
            Controls.Add(radioButton1);
            Controls.Add(txtCelsius);
            Controls.Add(label1);
            Name = "ConversorTemperatura";
            Text = "ConversorTemperatura";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCelsius;
        private RadioButton radioButton1;
        private RadioButton btnkenvin;
        private GroupBox groupBox1;
        private TextBox txtResultado2;
        private TextBox txtResultado1;
        private RadioButton btnFahrenheit;
        private Button btnConfirmar;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}