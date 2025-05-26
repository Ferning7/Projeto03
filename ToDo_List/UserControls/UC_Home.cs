using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_List.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Tarefas t = new Tarefas();
            t.ListarTarefas(dgvTarefas);
        }

        private void btnCriarT_Click(object sender, EventArgs e)
        {
            try
            {
                Tarefas t = new Tarefas();
                if (!txtTitulo.Text.Equals("") && !txtDescricao.Text.Equals(""))
                {
                    t.Titulo = txtTitulo.Text;
                    t.Descricao = txtDescricao.Text;
                    t.StatusTarefa = txtStatus.Text;
                    t.DataPrazo = dtpDataPrazo.Value;
                    t.CadastrarTarefa();
                    MessageBox.Show("Tarefa criada");
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tarefas t = new Tarefas();
            if (!txtTitulo.Text.Equals(""))
            {
                DialogResult esc = MessageBox.Show("Apagar tarefa?", "msg", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (esc == DialogResult.Yes)
                {
                    t.Titulo = txtTitulo.Text;
                    t.ApagarTarefa();
                }
                else
                {
                    MessageBox.Show("Informe o titulo para apagar");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Tarefas t = new Tarefas();

            t.Titulo = txtTitulo.Text;

            t.EditarTarefa();
        }
    }
}
