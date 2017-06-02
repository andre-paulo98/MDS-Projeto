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
        public void addConsulta()
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

        public List<Consulta> listaConsulta()
        {
            List<Consulta> lista = new List<Consulta>();
            Consulta consulta;
            con.Open();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "SELECT * FROM consultas"+
                                "JOIN paciente ON paciente.id = consultas.id_paciente"+
                                "JOIN medico ON medico.id = consultas.id_medico";

            try
            {
                MySqlDataReader reader = query.ExecuteReader();
                
                while (reader.Read())
                {
                    consulta = new Consulta();
                    consulta.medico.id = reader.get("id_medico"):
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
