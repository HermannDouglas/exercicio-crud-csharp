namespace AppCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            tbxNome = new TextBox();
            lblSelecionaUsuario = new Label();
            rbtnAluno = new RadioButton();
            rbtnProfessor = new RadioButton();
            rbtnServidor = new RadioButton();
            btnCadastrar = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            btnRecarregarDados = new Button();
            dgvDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(50, 50);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // tbxNome
            // 
            tbxNome.Location = new Point(99, 47);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(320, 23);
            tbxNome.TabIndex = 3;
            // 
            // lblSelecionaUsuario
            // 
            lblSelecionaUsuario.AutoSize = true;
            lblSelecionaUsuario.Location = new Point(50, 78);
            lblSelecionaUsuario.Name = "lblSelecionaUsuario";
            lblSelecionaUsuario.Size = new Size(152, 15);
            lblSelecionaUsuario.TabIndex = 4;
            lblSelecionaUsuario.Text = "Selecione o tipo de usuário:";
            // 
            // rbtnAluno
            // 
            rbtnAluno.AutoSize = true;
            rbtnAluno.Location = new Point(208, 76);
            rbtnAluno.Name = "rbtnAluno";
            rbtnAluno.Size = new Size(57, 19);
            rbtnAluno.TabIndex = 5;
            rbtnAluno.TabStop = true;
            rbtnAluno.Text = "Aluno";
            rbtnAluno.UseVisualStyleBackColor = true;
            // 
            // rbtnProfessor
            // 
            rbtnProfessor.AutoSize = true;
            rbtnProfessor.Location = new Point(271, 76);
            rbtnProfessor.Name = "rbtnProfessor";
            rbtnProfessor.Size = new Size(74, 19);
            rbtnProfessor.TabIndex = 6;
            rbtnProfessor.TabStop = true;
            rbtnProfessor.Text = "Professor";
            rbtnProfessor.UseVisualStyleBackColor = true;
            // 
            // rbtnServidor
            // 
            rbtnServidor.AutoSize = true;
            rbtnServidor.Location = new Point(351, 76);
            rbtnServidor.Name = "rbtnServidor";
            rbtnServidor.Size = new Size(68, 19);
            rbtnServidor.TabIndex = 7;
            rbtnServidor.TabStop = true;
            rbtnServidor.Text = "Servidor";
            rbtnServidor.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(53, 99);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(134, 99);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(215, 99);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 10;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnRecarregarDados
            // 
            btnRecarregarDados.Location = new Point(296, 99);
            btnRecarregarDados.Name = "btnRecarregarDados";
            btnRecarregarDados.Size = new Size(114, 23);
            btnRecarregarDados.TabIndex = 11;
            btnRecarregarDados.Text = "Recarregar dados";
            btnRecarregarDados.UseVisualStyleBackColor = true;
            btnRecarregarDados.Click += btnRecarregarDados_Click;
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToOrderColumns = true;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(27, 128);
            dgvDados.Name = "dgvDados";
            dgvDados.RowTemplate.Height = 25;
            dgvDados.Size = new Size(430, 297);
            dgvDados.TabIndex = 12;
            dgvDados.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 436);
            Controls.Add(dgvDados);
            Controls.Add(btnRecarregarDados);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCadastrar);
            Controls.Add(rbtnServidor);
            Controls.Add(rbtnProfessor);
            Controls.Add(rbtnAluno);
            Controls.Add(lblSelecionaUsuario);
            Controls.Add(tbxNome);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Sistema Acadêmico";
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNome;
        private Label lblSelecionaUsuario;
        private TextBox tbxNome;

        private RadioButton rbtnAluno;
        private RadioButton rbtnProfessor;
        private RadioButton rbtnServidor;

        private Button btnCadastrar;
        private Button btnAtualizar;
        private Button btnDeletar;
        private Button btnRecarregarDados;

        private DataGridView dgvDados;
    }
}