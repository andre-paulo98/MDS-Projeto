using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMDS {
    public class Paciente {
        public int id { get; set; }
        public string Nome { get; set; }

        public DateTime Data_Nascimento { get; set; }

        public string Morada { get; set; }

        public string Cod_Postas { get; set; }

        public string Nacionalidade { get; set; }

        public int Nif { get; set; }

        public int N_cc { get; set; }

        public int N_sns { get; set; }
    }
}
