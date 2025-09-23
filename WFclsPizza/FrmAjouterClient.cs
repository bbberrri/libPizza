using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libPizza;
using Microsoft.Data.SqlClient;

namespace WFclsPizza
{
    public partial class FrmAjouterClient : Form
    {
        public FrmAjouterClient()
        {
            InitializeComponent();
        }
        private void button_Click_1(object sender, EventArgs e)
        {
            Gestion g = new Gestion();
            g.AjouterNouveauClient(txtAdresse.Text, txtCp.Text, txtNom.Text, txtPrenom.Text,
                                   txtTel.Text, txtVille.Text);
        }

        private void FrmAjouterClient_Load(object sender, EventArgs e)
        {

        }
    }
}
