namespace TPI_Cine_Frontend
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void altaTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAltaTicket().ShowDialog();
        }

        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAltaCliente().ShowDialog();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultarCliente().ShowDialog();
        }

        private void altaFuncionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAltaFuncion().ShowDialog();
        }

        private void consultaFuncionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultarFuncion().ShowDialog();
        }
    }
}