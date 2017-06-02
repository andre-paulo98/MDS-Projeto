using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDS {
    public class UserRepository {

        MySqlConnection con;
        public UserRepository()
        {
            string CString =
                "server=localhost;" +
                "database=mds-projeto;" +
                "uid=root;" +
                "pwd=;";
            con = new MySqlConnection(CString);
        }

        // TODO: teste unitario
        public bool Login(string nome, string pw) {
            User user = GetUserByUsename(nome);
            bool flag = false;
            if (user.password == pw)
            {
                flag = true;
            }
            else
            {
                MessageBox.Show("Falha a efetuar Login!\nCredencias Invalidas!");
            }
            return flag;
        }

        public void Add(User user)
        {
            //0-medico 1-rececionista 2-admin
            con.Open();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "INSERT INTO users (username,password,permissao) VALUES (@username,@password,@permissao)";
            query.Parameters.AddWithValue("@username", user.username);
            query.Parameters.AddWithValue("@password", user.username);
            query.Parameters.AddWithValue("@permissao", user.permissao);
            try
            {
                query.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão ao servidor MySQL \n" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void Remove(User user)
        {
            con.Open();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "DELETE FROM users where username = @username";
            query.Parameters.AddWithValue("@username", user.username);
            try
            {
                query.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão ao servidor MySQL \n" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public User GetUserByUsename(string username)
        {
            User user = new User();
            con.Open();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "SELECT * FROM users WHERE username = @username";
            query.Parameters.AddWithValue("@username", username);
            try
            {
                MySqlDataReader reader = query.ExecuteReader();
                if (reader.Read())
                {
                    user.id = reader.GetInt32("id");
                    user.username = reader.GetString("username");
                    user.password = reader.GetString("password");
                    user.permissao = reader.GetInt32("permissao");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão ao servidor MySQL \n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return user;
        }

        public List<User> GetUsers()
        {
            List<User> lista = new List<User>();
            con.Open();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "SELECT * FROM users";
            try
            {
                MySqlDataReader reader = query.ExecuteReader();
                User user;
                while (reader.Read())
                {
                    user = new User();
                    user.id = reader.GetInt32("id");
                    user.username = reader.GetString("username");
                    user.password = reader.GetString("password");
                    user.permissao = reader.GetInt32("permissao");
                    lista.Add(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão ao servidor MySQL \n" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return lista;
        }
    }
}
