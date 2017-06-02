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
            if(med1.username != med2.username) return false;
            if(med1.password != med2.password) return false;
            if(med1.permissao != med2.permissao) return false;
            if(med1.especialidade != med2.especialidade) return false;
            if(med1.entrada != med2.entrada) return false;
            if(med1.saida != med2.saida) return false;
            if(med1.nSegSocial != med2.nSegSocial) return false;
            if(med1.cargo != med2.cargo) return false;
            if(med1.id != med2.id) return false;
            return true;
        }

        public void eliminaMedico(string username) {
            con.Open();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "DELETE FROM users WHERE username = @username";
            query.Parameters.AddWithValue("@username", username);
            try {
                query.ExecuteNonQuery();
            } catch(Exception ex) {
                MessageBox.Show("Erro na conexão ao servidor MySQL \n" + ex.Message);
            } finally {
                con.Close();
            }
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
