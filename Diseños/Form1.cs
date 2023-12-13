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
                    conexion.Open();

                    string consulta = "SELECT Rol FROM USUARIOS WHERE Correo = @correo AND Password = @password";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@correo", textBox1.Text);
                    comando.Parameters.AddWithValue("@password", Encrypt.GetSHA256(textBox2.Text));

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.HasRows)
                    {
                        lector.Read();
                        string rol = lector["Rol"].ToString();
                        this.Hide();
                        MessageBox.Show("Bienvenido");

                        // Abre el siguiente formulario y pasa el rol como argumento al constructor del formulario
                        Main_ form2 = new Main_(rol);


                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrectos");
                    }

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Campos Vacíos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciarse();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
