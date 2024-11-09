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
    public partial class Divisivel : Form
    {
        public Divisivel()
        {
            InitializeComponent();
        }

        private void Divisivel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumero.Text);
            bool Div = Utilitarios.Divisivel(num);
            txtResposta.Text = Div.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtResposta.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
