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
    public partial class formListaPacientes : Form {
        User user;
        public formListaPacientes(User user) {
            this.user = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            new formAddPaciente(user).Show();
        }
    }
}
