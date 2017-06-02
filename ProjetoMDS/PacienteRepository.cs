using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDS {
    class PacienteRepository {

        MySqlConnection con;
        public PacienteRepository() {
            string CString =
                "server=localhost;" +
                "database=mds-projeto;" +
                "uid=root;" +
                "pwd=;";
            con = new MySqlConnection(CString);
        }

        public bool Add(Paciente paciente) {
            bool flag = VerifyPaciente(paciente);
            return flag;
        }

        private bool VerifyPaciente(Paciente pac) {
            bool flag = true;
            if (pac.Nome.Length > 0 ) {
                MessageBox.Show("te", "asdas");
            }
            return flag;
        }
    }
}
