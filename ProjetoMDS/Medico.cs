using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMDS {
    public class Medico : User {
        public string especialidade { get; set; }

        public DateTime entrada { get; set; }

        public DateTime saida { get; set; }

        public int nSegSocial { get; set; }
    }
}
