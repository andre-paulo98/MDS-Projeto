using System;
using System.Windows.Forms;

namespace ProjetoMDS
{
    public partial class formMenu : Form
    {
        User user;
        public formMenu(User user)
        {
            this.user = user;
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

        private void btConsultas_Click(object sender, EventArgs e) {
            formListaPacientes formPacientes = new formListaPacientes(user);
            formPacientes.Show();
        }
    }
}
