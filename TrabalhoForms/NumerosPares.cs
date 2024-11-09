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
    public partial class NumerosPares : Form
    {
        public NumerosPares()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = Convert.ToInt32(txtPrimeiroValor.Text);
            int y = Convert.ToInt32(txtSegundoValor.Text);

            if (x > y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            // String para armazenar os números pares
            string numerosPares = "Números pares:\n";


            // Laço for para encontrar os números pares
            for (int i = x; i <= y; i++)
            {
                if (i % 2 == 0)
                {
                    numerosPares += i + "\n";
                }
            }
            MessageBox.Show(numerosPares);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeiroValor.Text = "";
            txtSegundoValor.Text = "";

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

