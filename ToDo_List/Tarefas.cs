using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List
{
    public class Tarefas
    {
        private int id;
        private string titulo;
        private string descricao;
        private string statusTarefa;
        private DateTime dataPrazo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public string StatusTarefa
        {
            get { return statusTarefa; }
            set { statusTarefa = value; }
        }
        public DateTime DataPrazo
        {
            get { return dataPrazo; }
            set { dataPrazo = value; }
        }

        public bool CadastrarTarefa()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string insert = "INSERT INTO tarefa (titulo, descricao, statusTarefa, dataPrazo) VALUES (@titulo, @descricao, @statusTarefa, @dataPrazo)";

                    MySqlCommand comando = new MySqlCommand(insert, conexao);

                    comando.Parameters.AddWithValue("@titulo", Titulo);
                    comando.Parameters.AddWithValue("@descricao", Descricao);
                    comando.Parameters.AddWithValue("@statusTarefa", StatusTarefa);
                    comando.Parameters.AddWithValue("@dataPrazo", DataPrazo);


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
                MessageBox.Show($"Erro ao cadastrar tarefa :: {ex.Message}");
                return false;
            }
        }

        public void ListarTarefas(DataGridView dgv)
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    DataTable dt = new DataTable();

                    string consulta = "SELECT titulo, descricao, statusTarefa, dataPrazo FROM tarefa";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(consulta, conexao);

                    dataAdapter.Fill(dt);


                    dgv.AllowUserToAddRows = false;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.AllowUserToDeleteRows = true;
                    dgv.DataSource = dt;
                    dgv.AutoResizeColumns();
                    dgv.ClearSelection();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool ApagarTarefa()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string delete = "DELETE FROM tarefa WHERE Usuario_id = @id && titulo = @titulo";

                    MySqlCommand comando = new MySqlCommand(delete, conexao);

                    comando.Parameters.AddWithValue("@titulo", Titulo);

                    int r = comando.ExecuteNonQuery();

                    if (r > 0)
                    {
                        MessageBox.Show("Tarefa apagada");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nao deu");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool EditarTarefa()
        {

            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string update = "UPDATE tarefa SET (titulo, descricao, statusTarefa, dataPrazo) TO (@titulo, @descricao, @statusPrazo, @dataPrazo WHERE id = @id and titulo = @titulo";

                    MySqlCommand comando = new MySqlCommand(update, conexao);

                    comando.Parameters.AddWithValue("@titulo", Titulo);

                    int r = comando.ExecuteNonQuery();

                    if (r > 0)
                    { 
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nao foi possivel editar");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão!");
                return false;
            }
        }
    }
}


