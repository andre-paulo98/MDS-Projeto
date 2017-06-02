using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDS {
    class MedioRepository {
        MySqlConnection con;
        public MedioRepository() {
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
    }
}
