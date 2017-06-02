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
    public partial class formAddPaciente : Form {

        User user;
        PacienteRepository pacienteRepo = new PacienteRepository();
        public formAddPaciente(User user) {
            this.user = user;
            InitializeComponent();
        }

        private void bt_guardar_Click(object sender, EventArgs e) {
            Paciente paciente = new Paciente();

            paciente.Nome = tb_nome.Text;
            paciente.Data_Nascimento = dp_data_nasc.Value;
            paciente.Morada = tb_morada.Text;
            paciente.Cod_Postas = tb_codposta.Text;
            paciente.Nacionalidade = tb_nacionalidade.Text;
            if (tb_nif.Text.Length > 0)
                paciente.Nif = int.Parse(tb_nif.Text);
            if (tb_cc.Text.Length > 0)
                paciente.N_cc = int.Parse(tb_cc.Text);
            if(tb_sns.Text.Length > 0)
                paciente.N_sns = int.Parse(tb_sns.Text);
            paciente.Avatar = pb_avatar.ImageLocation;
            paciente.User = user;

            if (pacienteRepo.Add(paciente)) {
                this.Close();
            }
            
        }

        private void bt_cancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
