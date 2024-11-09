
namespace TrabalhoForms
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            conversorToolStripMenuItem = new ToolStripMenuItem();
            listagemToolStripMenuItem = new ToolStripMenuItem();
            conversorToolStripMenuItem2 = new ToolStripMenuItem();
            divisivelPor3ToolStripMenuItem = new ToolStripMenuItem();
            mostrarIdadeToolStripMenuItem = new ToolStripMenuItem();
            valoresDeNumerosParesToolStripMenuItem = new ToolStripMenuItem();
            conversorDeTemperaturaToolStripMenuItem = new ToolStripMenuItem();
            conversorToolStripMenuItem1 = new ToolStripMenuItem();
            parte2ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { conversorToolStripMenuItem, listagemToolStripMenuItem, parte2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // conversorToolStripMenuItem
            // 
            conversorToolStripMenuItem.Name = "conversorToolStripMenuItem";
            conversorToolStripMenuItem.Size = new Size(14, 24);
            // 
            // listagemToolStripMenuItem
            // 
            listagemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conversorToolStripMenuItem2, divisivelPor3ToolStripMenuItem, mostrarIdadeToolStripMenuItem, valoresDeNumerosParesToolStripMenuItem, conversorDeTemperaturaToolStripMenuItem });
            listagemToolStripMenuItem.Name = "listagemToolStripMenuItem";
            listagemToolStripMenuItem.Size = new Size(68, 24);
            listagemToolStripMenuItem.Text = "Parte 1";
            // 
            // conversorToolStripMenuItem2
            // 
            conversorToolStripMenuItem2.Name = "conversorToolStripMenuItem2";
            conversorToolStripMenuItem2.Size = new Size(267, 26);
            conversorToolStripMenuItem2.Text = "Conversor";
            conversorToolStripMenuItem2.Click += conversorToolStripMenuItem2_Click;
            // 
            // divisivelPor3ToolStripMenuItem
            // 
            divisivelPor3ToolStripMenuItem.Name = "divisivelPor3ToolStripMenuItem";
            divisivelPor3ToolStripMenuItem.Size = new Size(267, 26);
            divisivelPor3ToolStripMenuItem.Text = "Divisivel por 3";
            divisivelPor3ToolStripMenuItem.Click += divisivelPor3ToolStripMenuItem_Click;
            // 
            // mostrarIdadeToolStripMenuItem
            // 
            mostrarIdadeToolStripMenuItem.Name = "mostrarIdadeToolStripMenuItem";
            mostrarIdadeToolStripMenuItem.Size = new Size(267, 26);
            mostrarIdadeToolStripMenuItem.Text = "Mostrar Idade";
            mostrarIdadeToolStripMenuItem.Click += mostrarIdadeToolStripMenuItem_Click;
            // 
            // valoresDeNumerosParesToolStripMenuItem
            // 
            valoresDeNumerosParesToolStripMenuItem.Name = "valoresDeNumerosParesToolStripMenuItem";
            valoresDeNumerosParesToolStripMenuItem.Size = new Size(267, 26);
            valoresDeNumerosParesToolStripMenuItem.Text = "Valores de Numeros Pares";
            valoresDeNumerosParesToolStripMenuItem.Click += valoresDeNumerosParesToolStripMenuItem_Click;
            // 
            // conversorDeTemperaturaToolStripMenuItem
            // 
            conversorDeTemperaturaToolStripMenuItem.Name = "conversorDeTemperaturaToolStripMenuItem";
            conversorDeTemperaturaToolStripMenuItem.Size = new Size(267, 26);
            conversorDeTemperaturaToolStripMenuItem.Text = "Conversor de Temperatura";
            conversorDeTemperaturaToolStripMenuItem.Click += conversorDeTemperaturaToolStripMenuItem_Click;
            // 
            // conversorToolStripMenuItem1
            // 
            conversorToolStripMenuItem1.Name = "conversorToolStripMenuItem1";
            conversorToolStripMenuItem1.Size = new Size(224, 26);
            conversorToolStripMenuItem1.Text = "Conversor";
            conversorToolStripMenuItem1.Click += conversorToolStripMenuItem1_Click;
            // 
            // parte2ToolStripMenuItem
            // 
            parte2ToolStripMenuItem.Name = "parte2ToolStripMenuItem";
            parte2ToolStripMenuItem.Size = new Size(68, 24);
            parte2ToolStripMenuItem.Text = "Parte 2";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void conversorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem conversorToolStripMenuItem;
        private ToolStripMenuItem conversorToolStripMenuItem1;
        private ToolStripMenuItem listagemToolStripMenuItem;
        private ToolStripMenuItem conversorToolStripMenuItem2;
        private ToolStripMenuItem divisivelPor3ToolStripMenuItem;
        private ToolStripMenuItem mostrarIdadeToolStripMenuItem;
        private ToolStripMenuItem valoresDeNumerosParesToolStripMenuItem;
        private ToolStripMenuItem conversorDeTemperaturaToolStripMenuItem;
        private ToolStripMenuItem parte2ToolStripMenuItem;
    }
}
