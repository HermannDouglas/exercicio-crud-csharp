using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Windows.Forms;


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
            string nome = tbxNome.Text;
            string tipoUsuario = GetTipoUsuarioSelecionado();

            MySqlConnection con = new MySqlConnection(
            "server = localhost; " +
            "database = academico; " +
            "user id = root; " +
            "password = root;");

            MySqlCommand cmd = new MySqlCommand(
                "insert into usuario (nome, tipo) values ('" + nome +
                "','" + tipoUsuario + "')"
                , con);

            con.Open();
            cmd.ExecuteNonQuery();

            atualizar_ds();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value);
            string nome = tbxNome.Text;
            string tipoUsuario = GetTipoUsuarioSelecionado();

            MySqlConnection con = new MySqlConnection(
                "server = localhost; " +
                "database = academico; " +
                "user id = root; " +
                "password = root;");

            MySqlCommand cmd = new MySqlCommand(
                "update usuario set nome = '" + nome +
                "', tipo = '" + tipoUsuario +
                "' where id = '" + id + "' ",
                con);

            con.Open();
            cmd.ExecuteNonQuery();

            atualizar_ds();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value);

            MySqlConnection con = new MySqlConnection(
                "server = localhost; " +
                "database = academico; " +
                "user id = root; " +
                "password = root;");

            MySqlCommand cmd = new MySqlCommand(
                "delete from usuario where id = '" + id + "' ",
                con);

            con.Open();
            cmd.ExecuteNonQuery();

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


            MySqlCommand cmd = new MySqlCommand(" select * from usuario ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dgvDados.DataSource = ds;
            dgvDados.DataMember = ds.Tables[0].TableName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNome.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();

        }

        // Verificar radioButton de tipo de usuário
        public string GetTipoUsuarioSelecionado()
        {
            string tipoUsuario = "";

            if (rbtnAluno.Checked)
            {
                tipoUsuario = "Aluno";
            }
            else if (rbtnProfessor.Checked)
            {
                tipoUsuario = "Professor";
            }
            else if (rbtnServidor.Checked)
            {
                tipoUsuario = "Servidor";
            }
            return tipoUsuario;
        }
    }
}