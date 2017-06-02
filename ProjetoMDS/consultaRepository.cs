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

        public bool verificarHorario(Medico medico)
        {
            bool flag = false;



            return flag;
        }
    }
}
