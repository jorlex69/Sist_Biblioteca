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
        private string RolUsuario;
        validpass val = new validpass();
 
        private void buscuser()
        {

            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                try
                {
                    string consulta = "SELECT ID, Nombre, Correo,Rol FROM USUARIOS WHERE Activo = 1 AND ID = '" + textBox6.Text + "'";
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
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(comboBox1.Text))
            {
                if (string.Equals(textBox3.Text, textBox4.Text, StringComparison.OrdinalIgnoreCase))
                {
                  

                            try
                            {
                           
                                GestorUsuarios gestorUsuarios = new GestorUsuarios(connectionString);
                                gestorUsuarios.AgregarUsuario(textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), textBox3.Text);

                        cleantext();
                        loadgrid();
                    }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al agregar usuario: " + ex.Message);
                            }
                        
                      

                    
               
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("Campos vacíos");
            }
        }
        private void loadgrid()
        {

            string consulta = "select ID, Nombre, Correo, Rol from USUARIOS where Activo = 1";
            SqlDataAdapter adap = new SqlDataAdapter(consulta, connectionString);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void edituser()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox6.Text)&&!string.IsNullOrEmpty(comboBox1.Text) )
            {


                if (string.Equals(textBox3.Text, textBox4.Text, StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        cleantext();
                        loadgrid();
                        int id = int.Parse(textBox6.Text);
                        GestorUsuarios gestorUsuarios = new GestorUsuarios(connectionString);
                        gestorUsuarios.EditarUsuario(textBox1.Text,textBox2.Text, comboBox1.SelectedItem.ToString(), textBox3.Text,id);
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

                    int idUsuario = int.Parse(textBox6.Text);
           

                    GestorUsuarios gestorUsuarios = new GestorUsuarios(connectionString);
                    gestorUsuarios.OcultarUsuario(idUsuario);
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
                MessageBox.Show("Proporcione el ID del Ususario");
            }


        }
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

        public add_users(string rol)
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
                button3.Visible = false;
                button4.Visible = false;
 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            aduser();
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edituser();
     
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

        }

        private void button5_Click(object sender, EventArgs e)
        {

            buscuser();
            
         
        }
    }
}
