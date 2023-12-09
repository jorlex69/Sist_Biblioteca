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
            Main_ main_= new Main_();
            main_.Close();
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
