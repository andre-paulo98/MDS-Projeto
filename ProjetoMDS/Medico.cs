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

        public object this[string propertyName] {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
    }
}
