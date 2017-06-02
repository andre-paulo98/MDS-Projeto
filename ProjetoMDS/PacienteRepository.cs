using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDS {
    class PacienteRepository {

        MySqlConnection con;
        public PacienteRepository() {
            string CString =
                "server=localhost;" +
                "database=mds-projeto;" +
                "uid=root;" +
                "pwd=;";
            con = new MySqlConnection(CString);
        }

        public bool Add(Paciente paciente) {
            bool flag = VerifyPaciente(paciente);
            if (flag) {
                con.Open();
                try {
                    MySqlCommand query = con.CreateCommand();
                    query.CommandText = "INSERT INTO `paciente`(`nome`, `data_nasc`, `cod_postal`, `nacionalidade`, `nif`, `cc`, `sns`, `avatar`, `id_user`) "+
                        " VALUES (@nome,@data_nasc,@cod_postal,@nacionalidade,@nif,@cc,@sns,@avatar,@id_user)";
                    query.Parameters.AddWithValue("@nome", paciente.Nome);
                    query.Parameters.AddWithValue("@data_nasc", paciente.Data_Nascimento);
                    query.Parameters.AddWithValue("@cod_postal", paciente.Cod_Postas);
                    query.Parameters.AddWithValue("@nacionalidade", paciente.Nacionalidade);
                    query.Parameters.AddWithValue("@nif", paciente.Nif);
                    query.Parameters.AddWithValue("@cc", paciente.N_cc);
                    query.Parameters.AddWithValue("@sns", paciente.N_sns);
                    query.Parameters.AddWithValue("@avatar", paciente.Avatar);
                    query.Parameters.AddWithValue("@id_user", paciente.User.id);
                    query.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show("Erro na conexão ao servidor MySQL \n" + ex.Message);
                } finally {
                    con.Close();
                }
            }
            return flag;
        }

        public List<Paciente> GetListPacientes() {
            List<Paciente> lista = new List<Paciente>();

            con.Open();
            MySqlCommand query = con.CreateCommand();
            query.CommandText = "SELECT * FROM paciente ";

            try {
                MySqlDataReader reader = query.ExecuteReader();
                Paciente paciente;
                while (reader.Read()) {
                    paciente = new Paciente();
                    paciente.id = reader.GetInt32("id");
                    paciente.Nome = reader.GetString("nome");
                    paciente.Data_Nascimento = reader.GetDateTime("data_nasc");
                    paciente.Cod_Postas = reader.GetString("cod_postal");
                    paciente.Nacionalidade = reader.GetString("nacionalidade");
                    paciente.Nif = reader.GetInt32("nif");
                    paciente.N_cc = reader.GetInt32("cc");
                    paciente.N_sns = reader.GetInt32("sns");
                    paciente.Avatar = "not null";
                    lista.Add(paciente);
                }
            } catch (Exception ex) {
                MessageBox.Show("Erro na conexão ao servidor MySQL \n" + ex.Message);
            } finally {
                con.Close();
            }

            return lista;
        }

        private bool VerifyPaciente(Paciente pac) {
            bool flag = false;
            if (pac.Nome.Length <= 0) {
                MessageBox.Show("O nome do paciente não foi definido\n" +
                    "Defina o nome do paciente e tente novamente", "Dados invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (pac.Data_Nascimento >= DateTime.Now) {
                MessageBox.Show("A data de nascimetento não é valida!\n" +
                    "Introduza uma nova data de nascimento do paciente e tente novamente", "Dados invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (pac.Morada.Length <= 0) {
                MessageBox.Show("A morada do paciente não foi definida\n" +
                    "Defina a morada do paciente e tente novamente", "Dados invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (pac.Cod_Postas.Length <= 3) {
                MessageBox.Show("O codigo postal do paciente não foi definido corretamente\n" +
                   "Defina o codigo postal do paciente e tente novamente", "Dados invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (pac.Nacionalidade.Length <= 0) {
                MessageBox.Show("A navionalide do paciente não foi definido\n" +
                    "Defina a nacionalidade do paciente e tente novamente", "Dados invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if ((pac.Nif + "").Length < 9 || (pac.Nif + "").Length > 9) {
                MessageBox.Show("O NIF do paciente não é valido/n" +
                    "Defina novamente NIF do paciente e tente novamente", "Dados invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if ((pac.N_cc +"").Length <9 || (pac.N_cc + "").Length > 9) {
                MessageBox.Show("O numero do Cartão de Cidadão do paciente não é valido \n" +
                    "Defina novamente a numero do Cartão de Cidadão do paciente e tente novamente", "Dados invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if ((pac.N_sns + "").Length < 9 || (pac.N_sns + "").Length > 9) {
                MessageBox.Show("O numero do Serviço Nacional de Saude do paciente não é valido\n" +
                    "Defina novamente a numero do SNS do paciente e tente novamente", "Dados invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (pac.User.id == 0) {
                throw new ArgumentNullException("Utilizador não definido");
            } else {
                flag = true;
            }
            return flag;
        }
    }
}
