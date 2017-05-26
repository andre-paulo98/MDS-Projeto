using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text;
using System.Collections.Generic;

namespace ProjetoMDS {
    public partial class formLogin : Form
    {
        DataBase db = new DataBase();
        List<Users> listUser;
        public formLogin()
        {
            InitializeComponent();
            tbNome.Text = "teste";
            tbPassword.Text = "teste";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            formMenu formMenu = new formMenu();
            if (db.Login(tbNome.Text, db.HashPassword(tbPassword.Text)) >= 0)
            {
                formMenu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Erro. Credenciais inválidas.");
            }
        }
    }
}
