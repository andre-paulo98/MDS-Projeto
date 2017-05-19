using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDS
{
    class DataBase
    {
        public MySqlConnection Conn()
        {
            string CString = "server=localhost;database=mds-projeto;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(CString);
            return con; 
        }
        public int Login(String nome, String pw)
        {
            MySqlConnection con = Conn();
            int id = -1;
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "SELECT id FROM users WHERE username = @username AND password = @password LIMIT 1";
            query.Parameters.AddWithValue("@username", nome);
            query.Parameters.AddWithValue("@password", pw);
            try
            {
                con.Open();
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão ao servidor MySQL \n" + ex);
            }
           
            return id;
        }
        public void AddUser(String nome, String pw,int tipo)
        {
            //0-medico 1-rececionista 2-admin
            MySqlConnection con = Conn();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "INSERT INTO users (username,password,permissao) VALUES (@username,@password,@tipo)";
            query.Parameters.AddWithValue("@username", nome);
            query.Parameters.AddWithValue("@password", pw);
            query.Parameters.AddWithValue("@tipo", tipo);
            try
            {
                con.Open();
                query.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão ao servidor MySQL \n" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        // http://stackoverflow.com/a/14709940/6195472
        public string HashPassword(string password)
        {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
