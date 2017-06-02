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
    public partial class formAgendarConsulta : Form
    {
        Medico medico = new Medico();
        MedicosRepository medioRepos = new MedicosRepository();
        consultaRepository consultaRepos = new consultaRepository();
        Consulta novaConsulta;
        List<Medico> medicoList = new List<Medico>();
        Paciente paciente;

        public formAgendarConsulta(Paciente paciente)//passar o paciente por parametro
        {
            InitializeComponent();
            this.paciente = paciente;

        }

        public void refreshListBox()
        {
            listBox1.Items.Clear();
            medicoList= medioRepos.GetMedicoByEsp(cbEsp.SelectedItem.ToString());
            foreach (Medico medico in medicoList)
            {
                listBox1.Items.Add(medico);
            }
        }

        private void button1_Click(object sender, EventArgs e)//adicionar a consulta
        {
            if (listBox1.SelectedIndex != -1)
            {


                novaConsulta = new Consulta();
                novaConsulta.data = dataPicker.Value;
                novaConsulta.hora = horaPicker.Value;
                novaConsulta.medico = (Medico)listBox1.SelectedItem;
                novaConsulta.paciente = paciente;

                consultaRepos.addConsulta(novaConsulta);
                Close();
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbEsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshListBox();
        }
    }
}
