using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMDS
{
    class Consulta
    {
        public int id { get; set; }
        public Medico medico { get; set; }

        public Paciente paciente { get; set; }

        public DateTime data { get; set; }

        public DateTime hora { get; set; }

        public override string ToString()
        {
            return hora.ToString("HH:mm") + "\t\t" + paciente.Nome;
        }
    }
}
