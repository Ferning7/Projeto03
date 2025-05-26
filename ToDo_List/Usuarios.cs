using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List
{
    public class Usuarios
    {
        private int id;
        private string nomeUs;
        private string email;
        private string senha;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NomeUs
        {
            get { return nomeUs; }
            set { nomeUs = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public bool CadastrarUsuario()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string sqlInsert = "INSERT INTO usuario (nomeUs, email, senha) VALUES (@nomeUs, @email, @senha)";

                    MySqlCommand comando = new MySqlCommand(sqlInsert, conexao);

                    comando.Parameters.AddWithValue("@nomeUs", NomeUs);
                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", Senha);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"faiou o cadastramento senhor usuario :: {ex.Message}");
                return false;

            }

        }

        public bool verifyLogin()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {

                    string consulta = "SELECT COUNT(*) FROM usuario WHERE email = @email and senha = @senha";
                    MySqlCommand comando = new MySqlCommand(consulta, conexao);


                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", Senha);

                    int resultado = Convert.ToInt32(comando.ExecuteScalar());

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Faiou a verificação de login man :: {ex.Message}");
                return false;
            }
        }


    }
}
