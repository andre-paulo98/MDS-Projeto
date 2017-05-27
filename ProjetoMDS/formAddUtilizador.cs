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
            if(cbTipo.SelectedIndex != 0) {
                if(tbNome.TextLength == 0 || tbPassword.TextLength == 0) {
                    MessageBox.Show("Introduza todos os campos obrigatórios", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    db.AddUser(tbNome.Text, db.HashPassword(tbPassword.Text), cbTipo.SelectedIndex);
                    Close();
                }
            } else { //medico
                if(tbNome.TextLength == 0 || tbPassword.TextLength == 0) {

                } else {
                    string nome = tbNome.Text;
                    string pw = db.HashPassword(tbPassword.Text);
                    int tipo = cbTipo.SelectedIndex;
                    string especialidade = cbEspecialidade.SelectedItem.ToString();
                    string horaEntrada = dtHoraEntrada.Value.ToShortTimeString();
                    string horaSaida = dtHoraSaida.Value.ToShortTimeString();
                    db.AddUser(nome, pw, tipo, especialidade, horaEntrada, horaSaida);
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
    }
}
