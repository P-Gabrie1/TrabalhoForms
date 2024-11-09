using frmPrincipal;

namespace TrabalhoForms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void conversorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Conversor objTela = new Conversor();
            objTela.MdiParent = this;
            objTela.Show();
        }

        private void divisivelPor3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Divisivel objTela = new Divisivel();
            objTela.MdiParent = this;
            objTela.Show();
        }

        private void mostrarIdadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Idade objTela = new Idade();
            objTela.MdiParent = this;
            objTela.Show();
        }

        private void valoresDeNumerosParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumerosPares objTela = new NumerosPares();
            objTela.MdiParent = this;
            objTela.Show();
        }

        private void conversorDeTemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConversorTemperatura objTela = new ConversorTemperatura();
            objTela.MdiParent = this;
            objTela.Show();
        }
    }
}
