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

namespace Sist_Biblioteca.Diseños
{
    public partial class frmestu : Form
    {

        string connectionString = ("Data Source=DESKTOP-IA2ONFD\\SQLEXPRESS;Initial Catalog=BIBLIOTECA;TrustServerCertificate=true;Integrated Security=True");

        private void buscESTU()
        {

            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                try
                {
                    string consulta = "SELECT IdEstudiante, Nombre, Ciudad ,Teléfono ,Carrera FROM ESTUDIANTES WHERE Activo = 1 AND IdEstudiante = '" + textBox6.Text + "'";
                    SqlDataAdapter adap = new SqlDataAdapter(consulta, connectionString);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron Estudiantes con el ID proporcionado.");
                        dataGridView1.DataSource = null; // Limpiar el DataGridView si no hay datos
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("campos vacios");
            }


        }
        private void loadgrid()
        {

            string consulta = "SELECT IdEstudiante, Nombre, Ciudad ,Teléfono ,Carrera FROM ESTUDIANTES WHERE Activo = 1";

            SqlDataAdapter adap = new SqlDataAdapter(consulta, connectionString);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void addEstudiantes()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text))
            {


                try
                {
                    //int numero = int.Parse(textBox6.Text);
                    GestorEstudiantes gestorEstudiantes = new GestorEstudiantes(connectionString);
                    gestorEstudiantes.AgregarEstudiante(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

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
        private void editEstudiantes()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox6.Text))
            {


                try
                {

                    int id = int.Parse(textBox6.Text);
                    GestorEstudiantes gestorEstudiantes = new GestorEstudiantes(connectionString);
                    gestorEstudiantes.EditarEstudiante(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, id);
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
        private void delEstudiante()
        {


            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                try
                {
                    int id = int.Parse(textBox6.Text);
                    GestorEstudiantes gestorestu = new GestorEstudiantes(connectionString);
                    gestorestu.OcultarEstudiante(id);
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
        public frmestu()
        {
            InitializeComponent();
            loadgrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedCells[0].Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            addEstudiantes();
            loadgrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            editEstudiantes();
            loadgrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delEstudiante();
            loadgrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buscESTU();
        }
    }
}
