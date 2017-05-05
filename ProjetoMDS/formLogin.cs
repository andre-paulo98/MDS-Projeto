using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text;

namespace ProjetoMDS {
    public partial class formLogin : Form {
        public formLogin() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string connetionString = null;
            MySqlConnection cnn;
            formMenu formMenu = new formMenu();
            connetionString = "server=localhost;database=mds-projeto;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            try {
                cnn.Open();                
                MySqlCommand query = cnn.CreateCommand();
                query.CommandText = "SELECT id FROM users WHERE username = @username AND password = @password LIMIT 1";
                query.Parameters.AddWithValue("@username", tbNome.Text);
                query.Parameters.AddWithValue("@password", hashpassword(tbPassword.Text));
                MySqlDataReader reader = query.ExecuteReader();
                string id = "";
                while(reader.Read()) {
                    id = reader.GetString(0);
                }
                if(id == "") {
                    MessageBox.Show("Erro. Credenciais inválidas.");
                } else {
                    formMenu.Show();
                    Hide();
                }
                cnn.Close();
            } catch(Exception ex) {
                MessageBox.Show("Erro na conexão ao servidor MySQL \n"+ex);
            }
        }

        // http://stackoverflow.com/a/14709940/6195472
        public string hashpassword(string password) {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach(byte theByte in crypto) {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
