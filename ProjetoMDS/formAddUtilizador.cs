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
        DataBase db = new DataBase();
        public formAddUtilizador(formUtilizadores user)
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNome.TextLength == 0 || tbPassword.TextLength == 0)
            {
                MessageBox.Show("Introduza todos os campos obrigatórios", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                db.AddUser(tbNome.Text, db.HashPassword(tbPassword.Text), cbTipo.SelectedIndex);
                Close();
            }
                
            
        }
    }
}
