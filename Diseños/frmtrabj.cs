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
    public partial class frmtrabj : Form
    {
        string connectionString = ("Data Source=DESKTOP-IA2ONFD\\SQLEXPRESS;Initial Catalog=BIBLIOTECA;TrustServerCertificate=true;Integrated Security=True");
        string RolUsuario;

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
        private void buscEMP()
        {
            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                try
                {
                    string consulta = "SELECT IdEmpleado, Nombre, Ciudad, Teléfono, Turno FROM EMPLEADOS WHERE Activo = 1 AND IdEmpleado = '" + textBox6.Text + "'";
                    SqlDataAdapter adap = new SqlDataAdapter(consulta, connectionString);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron empleados con el ID proporcionado.");
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

        private void loadgrid()
        {
            string consulta = "SELECT IdEmpleado, Nombre, Ciudad, Teléfono, Turno FROM EMPLEADOS WHERE Activo = 1";
            SqlDataAdapter adap = new SqlDataAdapter(consulta, connectionString);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void addEmpleados()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text))
            {
                try
                {
                    GestorEmpleados gestorEmpleados = new GestorEmpleados(connectionString);
                    gestorEmpleados.AgregarEmpleado(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

                    loadgrid();
                    cleantext();
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

        private void editEmpleados()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox6.Text))
            {
                try
                {
                    int id = int.Parse(textBox6.Text);
                    GestorEmpleados gestorEmpleados = new GestorEmpleados(connectionString);
                    gestorEmpleados.EditarEmpleado(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, id);

                    loadgrid();
                    cleantext();
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

        private void delEmpleado()
        {
            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                try
                {
                    int id = int.Parse(textBox6.Text);
                    GestorEmpleados gestorEmpleados = new GestorEmpleados(connectionString);
                    gestorEmpleados.OcultarEmpleado(id);


                    loadgrid();
                    cleantext();
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

        public frmtrabj(string rol)
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
            addEmpleados();
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            editEmpleados();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delEmpleado();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buscEMP();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
