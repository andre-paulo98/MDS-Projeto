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
        DataBase db = new DataBase();
        List<Users> listUser = new List<Users>();
        public formUtilizadores()
        {
            InitializeComponent();
            refreshList();
        }

        private void btAdicionarNovo_Click(object sender, EventArgs e)
        {
            formAddUtilizador addUser = new formAddUtilizador(this);
            addUser.FormClosing += new FormClosingEventHandler(formUtilizadores_FormClosing);
            addUser.Show();
        }
        private void refreshList()
        {
            lbUser.Items.Clear();

            listUser = db.getUsers();

            foreach (Users user in listUser)
            {
                lbUser.Items.Add(user);
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (lbUser.SelectedIndex != -1)
            {
                Users userRemover = (Users)lbUser.SelectedItem;
                db.removeUser(userRemover.username);
                refreshList();
            }
        }

        private void formUtilizadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshList();
        }
    }
}
