using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text;
using System.Collections.Generic;

namespace ProjetoMDS {
    public partial class formLogin : Form
    {
        UserRepository userRepo = new UserRepository();
        User user = new User();

        public formLogin()
        {
            InitializeComponent();
            tbNome.Text = "teste";
            tbPassword.Text = "teste";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (userRepo.Login(tbNome.Text, Tools.HashPassword(tbPassword.Text)))
            {
                user = userRepo.GetUserByUsename(tbNome.Text);
                if (user.permissao == 0)
                {
                    formListaConsultas listaConsultas = new formListaConsultas();
                    listaConsultas.Show();
                }
                else
                {
                    formMenu formMenu = new formMenu(user);
                    formMenu.Show();
                }
                
                Hide();
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
