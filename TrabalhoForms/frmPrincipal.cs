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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void parOuImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParOuImpar objTela = new ParOuImpar();
            objTela.MdiParent = this;
            objTela.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void lblPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void indicativoIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculoImc objTela = new CalculoImc();
            objTela.MdiParent = this;
            objTela.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notas objTela = new Notas();
            objTela.MdiParent = this;
            objTela.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
