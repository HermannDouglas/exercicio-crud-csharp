namespace AppCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxId.Text);
            string nome = tbxNome.Text;
            string tipo = "Aluno";

            MySqlConnection con = new MySqlConnection(
            "server = localhost; " +
            "database = academico; " +
            "user id = root; " +
            "password = root;");

            MySqlCommand cmd = new MySqlCommand(
                "insert into pessoa values ('" + id +
                "','" + nome +
                "','" + tipo + "'); "
                , con);

            con.Open();
            cmd.ExecuteNonQuery();

            atualizar_ds();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxId.Text);
            string nome = tbxNome.Text;
            string tipo = "Aluno";

            MySqlConnection con = new MySqlConnection(
                "server = localhost; " +
                "database = academico; " +
                "user id = root; " +
                "password = root;");

            MySqlCommand cmd = new MySqlCommand(
                "update pessoa set nome = '" + nome +
                "', tipo = '" + tipo +
                "' where id = '" + id + "' ",
                con);

            con.Open();
            cmd.ExecuteNonQuery();

            atualizar_ds();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxId.Text);


            MySqlConnection con = new MySqlConnection(
                "server = localhost; " +
                "database = academico; " +
                "user id = root; " +
                "password = root;");

            MySqlCommand cmd = new MySqlCommand(
                "delete from pessoa where id = '" + id + 
                "' ",
                con);

            con.Open();
            cmd.ExecuteNonQuery();

            tbxId.Clear();
            tbxNome.Clear();

            atualizar_ds();

        }

        private void btnRecarregarDados_Click(object sender, EventArgs e)
        {
            atualizar_ds();
        }

        public void atualizar_ds()
        {
            MySqlConnection con = new MySqlConnection(
                "server = localhost; " +
                "database = academico; " +
                "user id = root; " +
                "password = root;");


            MySqlCommand cmd = new MySqlCommand(" select * from pessoa ", con);

            con.Open(); // abre a conex�o com o banco
            cmd.ExecuteNonQuery(); // executa cmd
            /*Pronto ap�s o cmd.ExecuteNonQuery(); selecionamos tudo o
            que tinha dentro do banco,
            agora os passos seguintes ir�o exibir as informa��es para
            que o usu�rio possa v�-las
            */
            MySqlDataAdapter da = new MySqlDataAdapter(); /* da, adapta o banco de dados ao nosso projeto */
            DataSet ds = new DataSet();
            da.SelectCommand = cmd; // adapta cmd ao projeto
            da.Fill(ds); // preenche todas as informa��es dentro do DataSet
            dgvDados.DataSource = ds; //Datagridview recebe ds j� preenchido
            dgvDados.DataMember = ds.Tables[0].TableName;
            /*Agora Datagridview exibe o banco de dados*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dgvDados.CurrentRow.Cells[0].Value.ToString();
            tbxNome.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();

        }

        // Verificar radioButton de tipo de usuário
        //public string verificaTipoUsuario()
        //{
        //    if(rbtnAluno.Checked)
        //    {
        //        return "Aluno";
        //    }else if (rbtnProfessor.Checked)
        //    {
        //        return "Professor";
        //    }else if (rbtnServidor.Checked)
        //    {
        //        return "Servidor";
        //    }
        //}
    }
}