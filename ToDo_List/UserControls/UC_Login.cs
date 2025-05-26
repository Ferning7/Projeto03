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
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Cadastro cad = new UC_Cadastro();
            this.Controls.Clear();
            this.Controls.Add(cad);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios us = new Usuarios();

                if (!txtEmail.Text.Equals("") && !txtSenha.Text.Equals(""))
                {
                    us.Email = txtEmail.Text;
                    us.Senha = txtSenha.Text;

                    if (us.verifyLogin())
                    {

                        UC_Home h = new UC_Home();
                        this.Controls.Clear();
                        this.Controls.Add(h);
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha inválidos");
                    }

                }
                else
                {
                    MessageBox.Show("Preencha os campos!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
