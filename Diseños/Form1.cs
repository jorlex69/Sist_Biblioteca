using EncriptandoTexto;
using Microsoft.Data.SqlClient;
using Sist_Biblioteca.Diseños;

namespace Sist_Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //hola


        private void iniciarse()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                try
                {
                    SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-IA2ONFD\\SQLEXPRESS;Initial Catalog=BIBLIOTECA;TrustServerCertificate=true;Integrated Security=True");
                    // string connectionString = ("Data Source=DESKTOP-IA2ONFD\\SQLEXPRESS;Initial Catalog=BIBLIOTECA;TrustServerCertificate=true;Integrated Security=True");

                    conexion.Open();
                    string consulta = "select * from USUARIOS where Correo ='" + textBox1.Text + "' and Password ='" + Encrypt.GetSHA256(textBox2.Text) + "'";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();

                    if (lector.HasRows == true)
                    {
                        this.Hide();
                        MessageBox.Show("Bienvenido");
                        Main_ form2 = new Main_();
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraeña erroneo");
                    }
                    conexion.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("!" + ex);

                }

            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            iniciarse();


        }
    }
}
