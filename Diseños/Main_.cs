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
    public partial class Main_ : Form
    {
        public Main_()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
         
            sure_ form1 = new sure_();
            form1.ShowDialog();
        }

        private void btnlib_Click(object sender, EventArgs e)
        {
            Libros libros = new Libros();
            libros.ShowDialog();
        }

        private void btnconf_Click(object sender, EventArgs e)
        {
           add_users usas = new add_users();
            usas.ShowDialog();
        }
    }
}
