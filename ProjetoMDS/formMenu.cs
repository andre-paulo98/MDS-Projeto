using System;
using System.Windows.Forms;

namespace ProjetoMDS
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void formMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btUsers_Click(object sender, EventArgs e)
        {
            formUtilizadores formUtilizadores = new formUtilizadores();
            formUtilizadores.Show();
        }
    }
}
