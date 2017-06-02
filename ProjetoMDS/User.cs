using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMDS
{
    public class User
    {
        public int id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public int permissao { get; set; }

        public string cargo {
            get {
                string cargo;
                switch (permissao) {
                    case 0:
                        cargo = "Medico";
                        break;
                    case 1:
                        cargo = "Rececionista";
                        break;
                    case 2:
                        cargo = "Administrador";
                        break;
                    default:
                        cargo = "User";
                        break;
                }
                return cargo;
            }
        }

        public override string ToString()
        {

            return username+ "\t\t" + cargo;
        }
    }
}
