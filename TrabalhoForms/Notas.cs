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
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtNota.Text);
            if (num == 10)
            {
                txtResultado.Text = "Excelente!";
            }
            else if (num >= 8 && num <= 9.9)
            {
                txtResultado.Text = "Muito Bom!";
            }
            else if (num >= 7 && num <= 7.9)
            {
                txtResultado.Text = "Bom!";
            }
            else if (num >= 0 && num <= 6.9)
            {
                txtResultado.Text = "Insatisfatório";
            }
            else
            {
                txtResultado.Text = "Nota Invalida!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNota.Text = "";
            txtResultado.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
