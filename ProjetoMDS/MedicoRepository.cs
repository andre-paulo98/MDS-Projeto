using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDS {
    public class MedicosRepository {
        MySqlConnection con;
        public MedicosRepository() {
            string CString =
                "server=localhost;" +
                "database=mds-projeto;" +
                "uid=root;" +
                "pwd=;";
            con = new MySqlConnection(CString);
        }

        public void Add(Medico medico) {
            //0-medico 1-rececionista 2-admin
            con.Open();
            try {
                MySqlCommand query = con.CreateCommand();
                UserRepository userRepo = new UserRepository();
                userRepo.Add(medico);
                medico.id = userRepo.GetUserByUsename(medico.username).id;
                query.CommandText = "INSERT INTO medico (id,especialidade,entrada,saida,segSocial) " +
                "VALUES (@id,@especialidade,@entrada,@saida,@segSocial)";
                query.Parameters.AddWithValue("@id", medico.id);
                query.Parameters.AddWithValue("@especialidade", medico.especialidade);
                query.Parameters.AddWithValue("@entrada", medico.entrada);
                query.Parameters.AddWithValue("@saida", medico.saida);
                query.Parameters.AddWithValue("@segSocial", medico.nSegSocial);
                query.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show("Erro na conexão ao servidor MySQL \n" + ex.Message);
            } finally {
                con.Close();
            }
        }

        public List<Medico> GetMedicoByEsp(string especialidade) {
            List<Medico> lista = new List<Medico>();

            con.Open();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "SELECT * FROM users " +
                                "JOIN medico on medico.id=users.id " +
                                "WHERE especialidade = @especialidade";

            query.Parameters.AddWithValue("@especialidade", especialidade);

            try {
                MySqlDataReader reader = query.ExecuteReader();
                Medico medico;
                while (reader.Read()) {
                    medico = new Medico();
                    medico.id = reader.GetInt32("id");
                    medico.username = reader.GetString("username");
                    medico.password = reader.GetString("password");
                    medico.permissao = reader.GetInt32("permissao");
                    medico.especialidade = reader.GetString("especialidade");
                    medico.entrada = reader.GetDateTime("entrada");
                    medico.saida = reader.GetDateTime("saida");
                    medico.permissao = reader.GetInt32("segSocial");
                    lista.Add(medico);
                }
            } catch (Exception ex) {
                MessageBox.Show("Erro na conexão ao servidor MySQL \n" + ex.Message);
            } finally {
                con.Close();
            }

            return lista;
        }
        
        public bool checkTwoMedics(Medico med1, Medico med2) {
            var prop = med1.GetType().GetProperties();
            foreach(var props in prop) {
                Console.WriteLine(props.Name);
                string Textmed1 = (string) med1[props.Name]; string Textmed2 = (string) med2[props.Name]; // TODO ACABAR ESTA PORCARIA QUE EU NÃO CONSIGO FAZER 
                if(Textmed1 != Textmed2) {
                    return false;
                }
            }
            return true;
        }
        public Medico getMedicoList(string username)
        {
            con.Open();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "SELECT * FROM users " +
                                "JOIN medico on medico.id=users.id " +
                                "WHERE username = @username";

            query.Parameters.AddWithValue("@username", username);
            Medico medico = new Medico();
            try
            {
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {

                    medico.id = reader.GetInt32("id");
                    medico.username = reader.GetString("username");
                    medico.password = reader.GetString("password");
                    medico.permissao = reader.GetInt32("permissao");
                    medico.especialidade = reader.GetString("especialidade");
                    medico.nSegSocial = reader.GetInt32("segSocial");
                    medico.entrada = DateTime.Parse(reader.GetString("entrada"));
                    medico.saida = DateTime.Parse(reader.GetString("saida"));

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
            return medico;
        }
    }
}
