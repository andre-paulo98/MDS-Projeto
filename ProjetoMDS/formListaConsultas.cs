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
    public partial class formListaConsultas : Form
    {
        List<Consulta> listConsulta = new List<Consulta>();
        public formListaConsultas()
        {
            InitializeComponent();
            labelData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void formListaConsultas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
