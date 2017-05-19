using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDS
{
    public partial class formUtilizadores : Form
    {
        public formUtilizadores()
        {
            InitializeComponent();
        }

        private void btAdicionarNovo_Click(object sender, EventArgs e)
        {
            formAddUtilizador addUser = new formAddUtilizador(this);
            addUser.Show();
        }
    }
}
