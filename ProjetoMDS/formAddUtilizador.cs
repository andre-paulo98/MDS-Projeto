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
    public partial class formAddUtilizador : Form
    {
        DataBase db;
        public formAddUtilizador(formUtilizadores user)
        {
            InitializeComponent();
            db= new DataBase();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNome.TextLength == 0 || tbPassword.TextLength == 0 || cbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Introduza todos os campos obrigatórios", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (db.verifyUser(tbNome.Text))
            {
                MessageBox.Show("Utilizador já existe", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Users novoUser = new Users();

                novoUser.username = tbNome.Text;
                novoUser.password = db.HashPassword(tbPassword.Text);
                novoUser.permissao = cbTipo.SelectedIndex;
                novoUser.cargo = cbTipo.SelectedItem.ToString();

                db.AddUser(novoUser.username, novoUser.password, novoUser.permissao, novoUser.cargo);
                Close();
            }
                
            } 
                
            
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e) {
            if(cbTipo.SelectedIndex == 0) { // medico
                groupBox2.Visible = true;
            } else {
                groupBox2.Visible = false;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
