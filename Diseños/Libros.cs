using EncriptandoTexto;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Sist_Biblioteca.Diseños
{
    public partial class Libros : Form
    {
        string connectionString = ("Data Source=DESKTOP-IA2ONFD\\SQLEXPRESS;Initial Catalog=BIBLIOTECA;TrustServerCertificate=true;Integrated Security=True");
        private string RolUsuario;


        private void cleantext()
        {
            for (int i = 1; i <= 10; i++)
            {
                TextBox textBox = this.Controls.Find("textBox" + i, true).FirstOrDefault() as TextBox;

                if (textBox != null)
                {
                    textBox.Clear();

                }
            }
        }
        private void loadgrid()
        {

            string consulta = "SELECT IdLibro, Titulo, Autor, Editorial, Existencia FROM LIBROS WHERE Activo = 1";

            SqlDataAdapter adap = new SqlDataAdapter(consulta, connectionString);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;

         
        }
        private void addlibros()
        {
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text))
            {


                try
                {
                    int numero = int.Parse(textBox5.Text);
                    GestorLibros gestorLibros = new GestorLibros(connectionString);
                    gestorLibros.AgregarLibro(textBox2.Text, textBox3.Text, textBox4.Text, numero);
                    cleantext();
                    loadgrid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Campos vacios");
            }
        }

        private void editlibros()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text))
            {


                try
                {
                    int exis = int.Parse(textBox5.Text);
                    int id = int.Parse(textBox1.Text);
                    GestorLibros gestorLibros = new GestorLibros(connectionString);
                    gestorLibros.EditarLibros(textBox2.Text, textBox3.Text, textBox4.Text, exis, id);
                    cleantext();
                    loadgrid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Campos vacios");
            }
        }


        private void dellibro()
        {


            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    int id = int.Parse(textBox1.Text);
                    GestorLibros gestorLibros = new GestorLibros(connectionString);
                    gestorLibros.Ocultarlibro(id);
                    cleantext();
                    loadgrid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex.Message);
                }
            }


            else
            {
                MessageBox.Show("No ha seleccionado un ID");
            }


        }

        public Libros(string rol)
        {
            InitializeComponent();
            loadgrid();

            RolUsuario = rol;

            if (RolUsuario.ToLower() == "administrador" || RolUsuario.ToLower() == "admin")

            {
                // Hacer visible un botón específico para el administrador

            }
            else
            {
                // Ocultar el botón para otros roles
                button3.Visible = false;
                button4.Visible = false;

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            addlibros();
     

        }

        private void button3_Click(object sender, EventArgs e)
        {
            editlibros();
     
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dellibro();
     
        }
    }
}
