using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDS {
    public partial class formListaPacientes : Form {
        PacienteRepository pacienteRepo;
        User user;
        public formListaPacientes(User user) {
            this.user = user;
            InitializeComponent();
            pacienteRepo = new PacienteRepository();
            RefreshLista();
        }

        private void button1_Click(object sender, EventArgs e) {
            formAddPaciente from =   new formAddPaciente(user);
            
            from.FormClosing += (object formSender, FormClosingEventArgs fromE) => {
                RefreshLista();
            };
            from.ShowDialog(this);
        }

        private void dgv_pacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Paciente paciente = pacienteRepo.GetListPacientes().ElementAt(dgv_pacientes.CurrentRow.Index);
            new formAgendarConsulta(paciente).ShowDialog(this);
        }

        private void RefreshLista() {
            dgv_pacientes.DataBindings.Clear();
            dgv_pacientes.DataSource = (from pac in pacienteRepo.GetListPacientes()
                                        select new { pac.Nome, pac.N_cc, pac.N_sns }).ToList();
        }
    }
}
