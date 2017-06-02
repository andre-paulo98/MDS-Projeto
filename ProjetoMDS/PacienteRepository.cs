using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMDS {
    class PacienteRepository {

        MySqlConnection con;
        public PacienteRepository() {
            tring CString =
                "server=localhost;" +
                "database=mds-projeto;" +
                "uid=root;" +
                "pwd=;";
            con = new MySqlConnection(CString);
        }
    }
}
