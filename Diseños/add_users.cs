using EncriptandoTexto;
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

            if (!string.IsNullOrEmpty(textBox1.Text)&& !string.IsNullOrEmpty(textBox2.Text)&&!string.IsNullOrEmpty(textBox3.Text)&&!string.IsNullOrEmpty(textBox4.Text))
            {


                if (string.Equals(textBox3.Text, textBox4.Text, StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        string connectionString = ("Data Source=DESKTOP-IA2ONFD\\SQLEXPRESS;Initial Catalog=BIBLIOTECA;TrustServerCertificate=true;Integrated Security=True");
                        GestorUsuarios gestorUsuarios = new GestorUsuarios(connectionString);
                        gestorUsuarios.AgregarUsuario(textBox1.Text, textBox2.Text, textBox3.Text);
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



    }
}
