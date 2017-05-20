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
    public partial class formMenuMedico : Form {
        public formMenuMedico() {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            DateTime date = DateTime.Now;
            label_Hora.Text = "Data/Hora: " + date.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
