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
        public formAddPaciente() {
            InitializeComponent();
        }

        private void bt_guardar_Click(object sender, EventArgs e) {
            Paciente paciente = new Paciente();

            paciente.Nome = tb_nome.Text;
            paciente.Data_Nascimento = dp_data_nasc.Value;
            paciente.Morada = tb_morada.Text;
            paciente.Cod_Postas = nud_cod1 + " - " + nud_cod2;
            paciente.Nacionalidade = tb_nacionalidade.Text;
            paciente.Nif = int.Parse(""+nud_nif.Value);
            paciente.N_cc = int.Parse("" + nud_cc.Value);
            paciente.N_cc = int.Parse("" + nud_sns.Value);
        }
    }
}
