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
    public partial class sure_ : Form
    {
        public sure_()
        {
            InitializeComponent();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

            // Verifica si el formulario Main_ está abierto antes de intentar cerrarlo
            if (Application.OpenForms["Main_"] != null)
            {
                // Obtiene la instancia del formulario Main_ y lo cierra
                Form mainForm = Application.OpenForms["Main_"];
                mainForm.Close();
            }


            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
