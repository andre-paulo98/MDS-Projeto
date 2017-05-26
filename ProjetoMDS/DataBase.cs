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
        public void AddUser(String nome, String pw,int permissao,string cargo)
        {
            //0-medico 1-rececionista 2-admin
            MySqlConnection con = Conn();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "INSERT INTO users (username,password,permissao,cargo) VALUES (@username,@password,@permissao,@cargo)";
            query.Parameters.AddWithValue("@username", nome);
            query.Parameters.AddWithValue("@password", pw);
            query.Parameters.AddWithValue("@permissao", permissao);
            query.Parameters.AddWithValue("@cargo", cargo);
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
        public void removeUser(string nome)
        {
            MySqlConnection con = Conn();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "DELETE FROM users where username = @username";
            query.Parameters.AddWithValue("@username", nome);
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
        public List<Users> getUsers()
        {
            List<Users> listUsers = new List<Users>();

            MySqlConnection con = Conn();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "Select * from users";
            try
            {
                con.Open();
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Users user = new Users();
                    user.username = reader.GetString(1);
                    user.password = reader.GetString(2);
                    user.permissao = reader.GetInt32(3);
                    user.cargo = reader.GetString(4);
                    listUsers.Add(user);
                }
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão ao servidor MySQL \n" + ex);
            }
            finally
            {
                con.Close();
            }

            return listUsers;
        }
        public bool verifyUser(string Username)
        {
            bool flag = false;

            foreach (Users user in getUsers())
            {
                if (user.username == Username)
                    flag = true;
            }

            return flag; //return true se existir user
        }


       
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
        } //http://stackoverflow.com/a/14709940/6195472
    }
}
