using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text;
using System.Collections.Generic;

namespace ProjetoMDS {
    public partial class formLogin : Form
    {
        UserRepository userRepo = new UserRepository();

        public formLogin()
        {
            InitializeComponent();
            tbNome.Text = "teste";
            tbPassword.Text = "teste";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            formMenu formMenu = new formMenu();
            if (userRepo.Login(tbNome.Text, Tools.HashPassword(tbPassword.Text)))
            {
                new formMenu().Show();
                Hide();
            }
        }
    }
}
