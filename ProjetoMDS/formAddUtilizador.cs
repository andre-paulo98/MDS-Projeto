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
            cbTipo.SelectedIndex = 0;
            cbEspecialidade.SelectedIndex = 0;
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
                if(cbTipo.SelectedIndex != 0) {
                    db.AddUser(novoUser.username, novoUser.password, novoUser.permissao, novoUser.cargo);
                } else {
                    novoUser.especialidade = cbEspecialidade.SelectedItem.ToString();
                    novoUser.horaEntrada = dtHoraEntrada.Value.ToShortTimeString();
                    novoUser.horaSaida = dtHoraSaida.Value.ToShortTimeString();
                    novoUser.nSegSocial = Int32.Parse(nSegSocial.Text);
                    db.AddUser(novoUser.username, novoUser.password, novoUser.permissao, novoUser.cargo, novoUser.especialidade, novoUser.horaEntrada, novoUser.horaSaida, novoUser.nSegSocial);
                }

               
                Close();
            }
                
            
        }

        private void btCancelar_Click(object sender, EventArgs e) {
            Close();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e) {
            if(cbTipo.SelectedIndex == 0) { // medico
                groupBox1.Visible = true;
            } else {
                groupBox1.Visible = false;
            }
        }

        private void dtHoraEntrada_ValueChanged(object sender, EventArgs e) {
            if(dtHoraEntrada.Value >= dtHoraSaida.Value) {
                dtHoraSaida.Value = dtHoraEntrada.Value.AddMinutes(1);
            }
        }
        private void dtHoraSaida_ValueChanged(object sender, EventArgs e) {
            if(dtHoraSaida.Value <= dtHoraEntrada.Value) {
                dtHoraEntrada.Value = dtHoraSaida.Value.AddMinutes(-1);
            }
        }

        
    }
}
