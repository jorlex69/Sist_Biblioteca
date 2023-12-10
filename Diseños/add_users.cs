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

namespace Sist_Biblioteca.Diseños
{
    public partial class add_users : Form
    {
        string connectionString = ("Data Source=DESKTOP-IA2ONFD\\SQLEXPRESS;Initial Catalog=BIBLIOTECA;TrustServerCertificate=true;Integrated Security=True");

      
        private void buscuser()
        {

            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                try
                {
                    string consulta = "SELECT ID, Nombre, Correo FROM USUARIOS WHERE Activo = 1 AND ID = '" + textBox6.Text + "'";
                    SqlDataAdapter adap = new SqlDataAdapter(consulta, connectionString);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron usuarios con el ID proporcionado.");
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
        private void aduser()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text))
            {


                if (string.Equals(textBox3.Text, textBox4.Text, StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        GestorUsuarios gestorUsuarios = new GestorUsuarios(connectionString);
                        gestorUsuarios.AgregarUsuario(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("Campos vacios");
            }
        }
        private void loadgrid()
        {

            string consulta = "select ID, Nombre, Correo from USUARIOS where Activo = 1";
            SqlDataAdapter adap = new SqlDataAdapter(consulta, connectionString);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void edituser()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox6.Text))
            {


                if (string.Equals(textBox3.Text, textBox4.Text, StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        int id = int.Parse(textBox6.Text);
                        GestorUsuarios gestorUsuarios = new GestorUsuarios(connectionString);
                        gestorUsuarios.EditarUsuario(textBox1.Text, textBox2.Text, textBox3.Text, id);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("error" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("contraseñas incorrectas");
                }
            }
            else
            {
                MessageBox.Show("Campos vacios");
            }


        }

        private void deluser()
        {


            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                try
                {
                    int id = int.Parse(textBox6.Text);
                    GestorUsuarios gestorUsuarios = new GestorUsuarios(connectionString);
                    gestorUsuarios.OcultarUsuario(id);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("error" + ex.Message);
                }
            }


            else
            {
                MessageBox.Show("Campos vacios");
            }


        }
        public add_users()
        {
            InitializeComponent();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            aduser();
            loadgrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edituser();
            loadgrid();
        }


        private void add_users_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox6.Text = dataGridView1.SelectedCells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deluser();
            loadgrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            buscuser();
            
         
        }
    }
}
