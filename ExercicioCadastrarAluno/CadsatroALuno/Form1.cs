using CadastroAluno;
using MySql.Data.MySqlClient;
using System.Data;
namespace CadsatroALuno
{
    public partial class Form1 : Form
    {
        public Form1()


        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                string sqlInserir = "INSERT INTO alunos (nomeAluno, email) VALUES (@nomeAluno, @email)";
                MySqlCommand cmd = new MySqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@nomeAluno", txtNome.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Aluno cadastrado com sucesso");

                string sqlMostrar = "SELECT nomeAluno, email FROM alunos";
                MySqlDataAdapter adp = new MySqlDataAdapter(sqlMostrar, con);
                DataTable dt = new DataTable();

                adp.Fill(dt);
                dgvAlunosCadastrar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }   }

