﻿using System;
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

        private string RolUsuario;

        public Main_(string rol)
        {
            InitializeComponent();

            RolUsuario = rol;

            // Ejemplo de lógica condicional según el rol para la visibilidad de un botón
            if (RolUsuario.ToLower() == "administrador" || RolUsuario.ToLower() == "admin")

            {


            }
            else
            {

            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {

            sure_ form1 = new sure_();
            form1.ShowDialog();
        }

        private void btnlib_Click(object sender, EventArgs e)
        {
            Libros libros = new Libros(RolUsuario);
            libros.ShowDialog();
        }

        private void btnconf_Click(object sender, EventArgs e)
        {
            add_users usas = new add_users(RolUsuario);
            usas.ShowDialog();
        }

        private void btnestu_Click(object sender, EventArgs e)
        {
            frmestu frmestu = new frmestu(RolUsuario);
            frmestu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmpresta frmpresta = new frmpresta(RolUsuario);
            frmpresta.ShowDialog();
        }

        private void btntrab_Click(object sender, EventArgs e)
        {
            frmtrabj frmtrabj = new frmtrabj(RolUsuario);
            frmtrabj.ShowDialog();
        }
    }
}
