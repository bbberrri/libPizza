namespace WFclsPizza
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void commanderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCommander fc = new FrmCommander();
            fc.ShowDialog();
        }
        private void ajouterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjouterClient fac = new FrmAjouterClient();
            fac.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
