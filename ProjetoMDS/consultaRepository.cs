using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDS
{
    class consultaRepository
    {
        MySqlConnection con;
        public consultaRepository()
        {
            string CString =
               "server=localhost;" +
               "database=mds-projeto;" +
               "uid=root;" +
               "pwd=;";
            con = new MySqlConnection(CString);
        }

        public void addConsulta(Consulta consulta)
        {
            con.Open();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "INSERT INTO consultas (id_medico,id_paciente,data,hora) VALUES (@id_medico,@id_paciente,@data,@hora)";
            query.Parameters.AddWithValue("@id_medico", consulta.medico.id);
            query.Parameters.AddWithValue("@id_paciente", consulta.paciente.id);
            query.Parameters.AddWithValue("@data", consulta.data);
            query.Parameters.AddWithValue("@hora", consulta.hora);
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

        public List<Consulta> listaConsulta(Medico medicoReferencia)
        {
            List<Consulta> lista = new List<Consulta>();
            Consulta consulta;
            Medico medico;
            Paciente paciente;
            User User;
            con.Open();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "SELECT * FROM consultas "+
                                "JOIN paciente ON paciente.id = consultas.id_paciente "+
                                "JOIN medico ON medico.id = consultas.id_medico "+
                                "JOIN users on users.id=paciente.id_user "+
                                "WHERE id_medico = @id_medico";

            query.Parameters.AddWithValue("@id_medico", medicoReferencia.id);
            try
            {
                MySqlDataReader reader = query.ExecuteReader();
                
                while (reader.Read())
                {
                    consulta = new Consulta();
                    medico = new Medico();
                    paciente= new Paciente();
                    User = new User();

                    consulta.id = reader.GetInt32("id");
                    //buscar medico
                    medico.id = reader.GetInt32("id_medico");
                    medico.especialidade = reader.GetString("especialidade");
                    medico.entrada = reader.GetDateTime("entrada");
                    medico.saida = reader.GetDateTime("saida");
                    medico.nSegSocial = reader.GetInt32("segSocial");

                    paciente.id = reader.GetInt32("id");
                    paciente.Nome = reader.GetString("nome");
                    paciente.Data_Nascimento = reader.GetDateTime("saida");
                    paciente.Cod_Postas = reader.GetString("cod_postal");
                    paciente.Nacionalidade = reader.GetString("nacionalidade");
                    paciente.Nif = reader.GetInt32("nif");
                    paciente.N_cc = reader.GetInt32("cc");
                    paciente.N_sns = reader.GetInt32("sns");
                    paciente.Avatar = reader.GetString("avatar");
                    //buscar paciente
                    User.id = reader.GetInt32("id");
                    User.username = reader.GetString("username");
                    User.password = reader.GetString("password");
                    User.permissao = reader.GetInt32("permissao");

                    consulta.hora = reader.GetDateTime("hora");
                    consulta.data = reader.GetDateTime("data");

                    consulta.medico = medico;
                    consulta.paciente = paciente;
                    consulta.paciente.User = User;

                    lista.Add(consulta);
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

        public List<Consulta> listaConsultaByName(String NomePaciente, Medico medicoReferencia)
        {
            List<Consulta> lista = new List<Consulta>();
            Consulta consulta;
            Medico medico;
            Paciente paciente;
            User User;


            con.Open();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "SELECT * FROM consultas " +
                                "JOIN paciente ON paciente.id = consultas.id_paciente " +
                                "JOIN medico ON medico.id = consultas.id_medico " +
                                "JOIN users on users.id=paciente.id_user "+
                                "WHERE paciente.nome like @nome "+
                                "AND id_medico = @id_medico";

            query.Parameters.AddWithValue("@nome", "%"+NomePaciente+"%");
            query.Parameters.AddWithValue("@id_medico", medicoReferencia);
            try
            {
                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    consulta = new Consulta();
                    medico = new Medico();
                    paciente = new Paciente();
                    User = new User();

                    consulta.id = reader.GetInt32("id");
                    //buscar medico
                    medico.id = reader.GetInt32("id_medico");
                    medico.especialidade = reader.GetString("especialidade");
                    medico.entrada = reader.GetDateTime("entrada");
                    medico.saida = reader.GetDateTime("saida");
                    medico.nSegSocial = reader.GetInt32("segSocial");

                    paciente.id = reader.GetInt32("id");
                    paciente.Nome = reader.GetString("nome");
                    paciente.Data_Nascimento = reader.GetDateTime("saida");
                    paciente.Cod_Postas = reader.GetString("cod_postal");
                    paciente.Nacionalidade = reader.GetString("nacionalidade");
                    paciente.Nif = reader.GetInt32("nif");
                    paciente.N_cc = reader.GetInt32("cc");
                    paciente.N_sns = reader.GetInt32("sns");
                    paciente.Avatar = reader.GetString("avatar");
                    //buscar paciente
                    User.id = reader.GetInt32("id");
                    User.username = reader.GetString("username");
                    User.password = reader.GetString("password");
                    User.permissao = reader.GetInt32("permissao");

                    consulta.hora = reader.GetDateTime("hora");
                    consulta.data = reader.GetDateTime("data");

                    consulta.medico = medico;
                    consulta.paciente = paciente;
                    consulta.paciente.User = User;

                    lista.Add(consulta);
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
