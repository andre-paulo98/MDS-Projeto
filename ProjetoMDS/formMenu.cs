using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoMDS
{
    public partial class formMenu : Form
    {
        User user;
        FormCollection formsOpen = Application.OpenForms;
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
            if (!formsOpen.OfType<formUtilizadores>().Any()) {
                new formUtilizadores().Show(this);
            }else {
                formsOpen.OfType<formUtilizadores>().First().Focus();
            }
        }

        private void btConsultas_Click(object sender, EventArgs e) {
            if (!formsOpen.OfType<formListaPacientes>().Any()) {
                new formListaPacientes(user).Show(this);
            } else {
                formsOpen.OfType<formListaPacientes>().First().Focus();
            }
        }
    }
}
