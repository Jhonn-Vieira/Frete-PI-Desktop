using Frete_PI_Desktop.Views;

namespace Frete_PI_Desktop
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroVeiculo frmCadastroVeiculo = new frmCadastroVeiculo();
            frmCadastroVeiculo.MdiParent = this;
            frmCadastroVeiculo.Show();
        }

        private void parâmetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroParam frmCadastroParam = new frmCadastroParam();
            frmCadastroParam.MdiParent = this;
            frmCadastroParam.Show();
        }
    }
}
