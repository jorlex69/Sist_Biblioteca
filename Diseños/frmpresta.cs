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
    public partial class frmpresta : Form
    {
        string connectionString = ("Data Source=DESKTOP-IA2ONFD\\SQLEXPRESS;Initial Catalog=BIBLIOTECA;TrustServerCertificate=true;Integrated Security=True");
 
        private void buscarPrestamos()
        {
            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                try
                {
                    string consulta = "SELECT IdPrestamo, Titulo_Libro, IdEmpleado, IdEstudiante, Nombre_Estudiante, Fech_Prestamo, Fecha_Devolución, Días, Estado FROM PRESTAMOS WHERE Activo = 1 AND IdPrestamo = '" + textBox5.Text + "'";
                    SqlDataAdapter adap = new SqlDataAdapter(consulta, connectionString);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron préstamos con el ID proporcionado.");
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
                MessageBox.Show("Campos vacíos");
            }
        }
        private void loadGrid()
        {
            string consulta = "SELECT IdPrestamo, Titulo_Libro, IdEmpleado, IdEstudiante, Nombre_Estudiante, Fech_Prestamo, Fecha_Devolución, Días, Estado FROM PRESTAMOS WHERE Activo = 1";
            SqlDataAdapter adap = new SqlDataAdapter(consulta, connectionString);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void agregarPrestamo()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text))
            {
                try
                {
                    int dias = 0;
                    TimeSpan diferencia = dateTimePicker2.Value - dateTimePicker1.Value;
                    dias = diferencia.Days;

                    GestorPrestamos gestorPrestamos = new GestorPrestamos(connectionString);
                    gestorPrestamos.AgregarPrestamo(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), textBox4.Text, dateTimePicker1.Value, dateTimePicker2.Value, dias, textBox9.Text);
                    loadGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Campos vacíos");
            }
        }
        private void editarPrestamo()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrEmpty(textBox5.Text))
            {
                try
                {
                    int dias = 0;
                   // Calculamos la diferencia de días entre las fechas
                   TimeSpan diferencia = dateTimePicker2.Value - dateTimePicker1.Value;
                    dias = diferencia.Days;

                    GestorPrestamos gestorPrestamos = new GestorPrestamos(connectionString);
                    gestorPrestamos.EditarPrestamo(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), textBox4.Text, dateTimePicker1.Value, dateTimePicker2.Value, dias, textBox9.Text, int.Parse(textBox5.Text));
                    loadGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Campos vacíos");
            }
        }
        private void eliminarPrestamo()
        {
            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                try
                {
                    int id = int.Parse(textBox5.Text);
                    GestorPrestamos gestorPrestamos = new GestorPrestamos(connectionString);
                    gestorPrestamos.OcultarPrestamo(id);

                    loadGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado un ID");
            }
        }

        public frmpresta()
        {
            InitializeComponent();
            loadGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[4].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.SelectedCells[5].Value;
            dateTimePicker2.Value = (DateTime)dataGridView1.SelectedCells[6].Value;
            textBox5.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox9.Text = dataGridView1.SelectedCells[8].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agregarPrestamo();
            loadGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            editarPrestamo();
            loadGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eliminarPrestamo();
            loadGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buscarPrestamos();
        }

    }
}
