using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Tenta converter o valor de entrada para um número inteiro
            if (int.TryParse(txtSegundo.Text, out int totalSegundos))
            {
                // Chama o método para converter o total de segundos em horas, minutos e segundos
                var (horas, minutos, segundos) = Utilitarios.ConverterSegundos(totalSegundos);

                // Exibe o resultado nos TextBoxes correspondentes
                txtHoras.Text = horas.ToString();
                txtMinutos.Text = minutos.ToString();
                textBox1.Text = segundos.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido de segundos.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHoras.Text = "";
            txtMinutos.Text = "";
            txtSegundo.Text = "";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
