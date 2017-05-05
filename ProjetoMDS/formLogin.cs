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
            connetionString = "server=andrepaulo.me;database=mds-projeto;uid=mds;pwd=fBLeaLfdHicXSY0T;";
            cnn = new MySqlConnection(connetionString);
            try {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                
                MySqlCommand query = cnn.CreateCommand();
                query.CommandText = "SELECT id FROM users WHERE username = @username AND password = @password";
                query.Parameters.AddWithValue("@username", tbNome.Text);
                query.Parameters.AddWithValue("@password", tbPassword.Text);
                MySqlDataReader reader = query.ExecuteReader();
                string id = "";
                while(reader.Read()) {
                    id = reader.GetString(0);
                }
                tbNome.Text=id;
                cnn.Close();
            } catch(Exception ex) {
                MessageBox.Show("Can not open connection ! "+ex);
            }
        }
    }
}
