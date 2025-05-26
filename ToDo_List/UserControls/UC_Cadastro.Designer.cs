namespace ToDo_List.UserControls
{
    partial class UC_Cadastro
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
            btnCadastrar = new Button();
            lblEmail = new Label();
            lblSenha = new Label();
            linkCadastro = new LinkLabel();
            label1 = new Label();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            lblNomeUser = new Label();
            txtNomeUser = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(218, 344);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(93, 37);
            btnCadastrar.TabIndex = 14;
            btnCadastrar.Text = "Criar conta";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15F);
            lblEmail.Location = new Point(186, 188);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 28);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 15F);
            lblSenha.Location = new Point(186, 254);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(69, 28);
            lblSenha.TabIndex = 12;
            lblSenha.Text = "Senha:";
            // 
            // linkCadastro
            // 
            linkCadastro.AutoSize = true;
            linkCadastro.Location = new Point(295, 382);
            linkCadastro.Name = "linkCadastro";
            linkCadastro.Size = new Size(37, 15);
            linkCadastro.TabIndex = 11;
            linkCadastro.TabStop = true;
            linkCadastro.Text = "Login";
            linkCadastro.LinkClicked += linkCadastro_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 57);
            label1.Name = "label1";
            label1.Size = new Size(132, 37);
            label1.TabIndex = 10;
            label1.Text = "Cadastro";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(186, 285);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(155, 23);
            txtSenha.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(186, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 23);
            txtEmail.TabIndex = 8;
            // 
            // lblNomeUser
            // 
            lblNomeUser.AutoSize = true;
            lblNomeUser.Font = new Font("Segoe UI", 15F);
            lblNomeUser.Location = new Point(186, 117);
            lblNomeUser.Name = "lblNomeUser";
            lblNomeUser.Size = new Size(70, 28);
            lblNomeUser.TabIndex = 16;
            lblNomeUser.Text = "Nome:";
            // 
            // txtNomeUser
            // 
            txtNomeUser.Location = new Point(186, 148);
            txtNomeUser.Name = "txtNomeUser";
            txtNomeUser.Size = new Size(155, 23);
            txtNomeUser.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 382);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 17;
            label2.Text = "Já possuo conta:";
            // 
            // UC_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(lblNomeUser);
            Controls.Add(txtNomeUser);
            Controls.Add(btnCadastrar);
            Controls.Add(lblEmail);
            Controls.Add(lblSenha);
            Controls.Add(linkCadastro);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Name = "UC_Cadastro";
            Size = new Size(563, 447);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label lblEmail;
        private Label lblSenha;
        private LinkLabel linkCadastro;
        private Label label1;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Label lblNomeUser;
        private TextBox txtNomeUser;
        private Label label2;
    }
}
