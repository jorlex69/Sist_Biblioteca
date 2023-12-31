﻿using Microsoft.Data.SqlClient;
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
    public partial class frmestu : Form
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
                    loadgrid();
                    cleantext();
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
                    loadgrid();
                    cleantext();

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
                    loadgrid();
                    cleantext();

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

        public frmestu(string rol)
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
            addEstudiantes();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            editEstudiantes();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delEstudiante();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            buscESTU();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nombre")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nombre ";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Ciudad")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Ciudad ";
                textBox2.ForeColor = Color.White;
            }

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Telefono")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;

            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Telefono ";
                textBox3.ForeColor = Color.White;
            }

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Carrera")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;

            }

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Carrera ";
                textBox4.ForeColor = Color.White;
            }

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "ID")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;

            }

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "ID ";
                textBox6.ForeColor = Color.White;
            }

        }
    }
}
