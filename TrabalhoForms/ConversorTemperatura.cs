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
    public partial class ConversorTemperatura : Form
    {
        public ConversorTemperatura()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double k, f;
            if (btnFahrenheit.Checked == true)
            {
                f = double.Parse(txtCelsius.Text);
                k = (f * 9 / 5) + 32;
                txtResultado2.Text = Convert.ToString(k);

            }
            else if (btnkenvin.Checked == true)
            {
                k = double.Parse(txtCelsius.Text);
                f = k + 273;
                txtResultado1.Text = Convert.ToString(f);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = "";
            txtResultado1.Text = "";
            txtResultado2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
