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
    public partial class UC_Cadastro : UserControl
    {
        public UC_Cadastro()
        {
            InitializeComponent();
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Login log = new UC_Login();
            this.Controls.Clear();
            this.Controls.Add(log);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios us = new Usuarios();

                if (!txtNomeUser.Text.Equals("") && !txtEmail.Text.Equals("") && !txtSenha.Text.Equals(""))
                {
                    us.NomeUs = txtNomeUser.Text;
                    us.Email = txtEmail.Text;
                    us.Senha = txtSenha.Text;

                    if (us.CadastrarUsuario())
                    {
                        MessageBox.Show("Cadastro realizado");
                        UC_Login log = new UC_Login();
                        this.Controls.Clear();
                        this.Controls.Add(log);

                    }
                    else
                    {
                        MessageBox.Show("Falha ao cadastrar");
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtNomeUser.Clear();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
