namespace ToDo_List.UserControls
{
    partial class UC_Home
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
            components = new System.ComponentModel.Container();
            txtTitulo = new TextBox();
            label1 = new Label();
            btnCriarT = new Button();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtDescricao = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnListar = new Button();
            dgvTarefas = new DataGridView();
            txtStatus = new TextBox();
            label5 = new Label();
            dtpDataPrazo = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).BeginInit();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(22, 64);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(167, 23);
            txtTitulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 46);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // btnCriarT
            // 
            btnCriarT.Location = new Point(446, 171);
            btnCriarT.Name = "btnCriarT";
            btnCriarT.Size = new Size(86, 31);
            btnCriarT.TabIndex = 2;
            btnCriarT.Text = "Criar";
            btnCriarT.UseVisualStyleBackColor = true;
            btnCriarT.Click += btnCriarT_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(206, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 3;
            label2.Text = "Criando Tarefas";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(227, 64);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(305, 89);
            txtDescricao.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 46);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 6;
            label3.Text = "Descrição:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 138);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Prazo:";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(334, 233);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 30);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(446, 233);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 30);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(22, 233);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(86, 30);
            btnListar.TabIndex = 11;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvTarefas
            // 
            dgvTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarefas.Location = new Point(3, 277);
            dgvTarefas.Name = "dgvTarefas";
            dgvTarefas.Size = new Size(557, 167);
            dgvTarefas.TabIndex = 12;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(22, 112);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(135, 23);
            txtStatus.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 94);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 14;
            label5.Text = "Status:";
            // 
            // dtpDataPrazo
            // 
            dtpDataPrazo.Location = new Point(22, 156);
            dtpDataPrazo.Name = "dtpDataPrazo";
            dtpDataPrazo.Size = new Size(148, 23);
            dtpDataPrazo.TabIndex = 15;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtpDataPrazo);
            Controls.Add(label5);
            Controls.Add(txtStatus);
            Controls.Add(dgvTarefas);
            Controls.Add(btnListar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(btnCriarT);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Name = "UC_Home";
            Size = new Size(563, 447);
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label label1;
        private Button btnCriarT;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtDescricao;
        private Label label3;
        private Label label4;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnListar;
        private DataGridView dgvTarefas;
        private TextBox txtStatus;
        private Label label5;
        private DateTimePicker dtpDataPrazo;
    }
}
