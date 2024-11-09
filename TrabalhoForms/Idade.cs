using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace frmPrincipal
{
    public partial class Idade : Form
    {
        public Idade()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DateTime dataNascimento = dtDataNascimento.Value;

            // Calcula a idade usando a classe Utilitario
            int idade = Utilitarios.MostrarIdade(dataNascimento);

            txtMostrarIdade.Text = idade.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMostrarIdade.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
