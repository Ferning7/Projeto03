namespace ToDo_List.UserControls
{
    partial class UC_Login
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            linkLabel1 = new LinkLabel();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            linkCadastro = new LinkLabel();
            label1 = new Label();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(190, 272);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(90, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueci a senha";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(223, 316);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(93, 37);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(190, 149);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 14;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(190, 215);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 13;
            label2.Text = "Senha:";
            // 
            // linkCadastro
            // 
            linkCadastro.AutoSize = true;
            linkCadastro.Location = new Point(240, 356);
            linkCadastro.Name = "linkCadastro";
            linkCadastro.Size = new Size(57, 15);
            linkCadastro.TabIndex = 12;
            linkCadastro.TabStop = true;
            linkCadastro.Text = "Cadastrar";
            linkCadastro.LinkClicked += linkCadastro_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 80);
            label1.Name = "label1";
            label1.Size = new Size(97, 37);
            label1.TabIndex = 11;
            label1.Text = "Log In";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(190, 246);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(155, 23);
            txtSenha.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(190, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 23);
            txtEmail.TabIndex = 9;
            // 
            // UC_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkCadastro);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Name = "UC_Login";
            Size = new Size(563, 447);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private LinkLabel linkCadastro;
        private Label label1;
        private TextBox txtSenha;
        private TextBox txtEmail;
    }
}
