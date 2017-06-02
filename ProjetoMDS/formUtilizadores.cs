using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDS
{
    public partial class formUtilizadores : Form
    {
        List<User> listUser = new List<User>();
        UserRepository userRepo;

        public formUtilizadores()
        {
            InitializeComponent();
            userRepo = new UserRepository();
            refreshList();
        }

        private void btAdicionarNovo_Click(object sender, EventArgs e)
        {
            formAddUtilizador addUser = new formAddUtilizador(this);
            addUser.FormClosing += new FormClosingEventHandler(formUtilizadores_FormClosing);
            addUser.ShowDialog(this);
        }
        private void refreshList()
        {
            lbUser.Items.Clear();

            listUser = userRepo.GetUsers();

            foreach (User user in listUser)
            {
                lbUser.Items.Add(user);
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (lbUser.SelectedIndex != -1)
            {
                User userRemover = (User)lbUser.SelectedItem;
                userRepo.Remove(userRemover);
                refreshList();
            }
        }

        private void formUtilizadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshList();
        }
    }
}
