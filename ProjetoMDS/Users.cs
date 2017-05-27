using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMDS
{
    class Users
    {
        public string username { get; set; }
        public string password { get; set; }
        public int permissao { get; set; }
        public string cargo { get; set; }
        public string especialidade { get; set; }
        public string horaEntrada { get; set; }
        public string horaSaida { get; set; }
        public int nSegSocial { get; set; }
        public override string ToString()
        {
            return username+ "\t\t" + cargo;
        }
    }
}
