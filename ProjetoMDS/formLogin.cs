using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text;
using System.Collections.Generic;

namespace ProjetoMDS {
    public partial class formLogin : Form
    {
        UserRepository userRepo = new UserRepository();
        MedicosRepository mediRepo = new MedicosRepository();
        User user = new User();
        Medico medicoLogado = new Medico();

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
                    medicoLogado = mediRepo.getMedicoList(tbNome.Text);
                    formListaConsultas listaConsultas = new formListaConsultas(medicoLogado);
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

        private void button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
