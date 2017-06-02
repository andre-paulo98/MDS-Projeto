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
        UserRepository userRepo;
        public formAddUtilizador(formUtilizadores user)
        {
            InitializeComponent();
            userRepo = new UserRepository();
            cbTipo.SelectedIndex = 0;
            cbEspecialidade.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNome.TextLength == 0 || tbPassword.TextLength == 0 || cbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Introduza todos os campos obrigatórios", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (userRepo.GetUserByUsename(tbNome.Text).id != 0)
            {
                MessageBox.Show("Utilizador já existe", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Medico novoUser = new Medico();

                novoUser.username = tbNome.Text;
                novoUser.password = Tools.HashPassword(tbPassword.Text);
                novoUser.permissao = cbTipo.SelectedIndex;
                if(cbTipo.SelectedIndex != 0) {
                    userRepo.Add(novoUser);
                } else {
                    novoUser.especialidade = cbEspecialidade.SelectedItem.ToString();
                    novoUser.entrada = dtHoraEntrada.Value;
                    novoUser.saida = dtHoraSaida.Value;
                    novoUser.nSegSocial = Int32.Parse(nSegSocial.Text);
                    new MedioRepository().Add(novoUser);
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

        
    }
}
