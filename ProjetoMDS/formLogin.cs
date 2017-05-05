using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoMDS {
    public partial class formLogin : Form {
        public formLogin() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=testes;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            try {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            } catch(Exception ex) {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}
