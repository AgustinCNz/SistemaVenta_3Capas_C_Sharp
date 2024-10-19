﻿using PP3capas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Presentacion
{
    public partial class MenuUsuario : Form
    {
        private Empleado empleadoIniciado;

        public MenuUsuario(Empleado e)
        {
            this.empleadoIniciado = e;
            InitializeComponent();
            label1.Text= "Bienvenido, " + e.Usuario;
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            CompraProducto comp = new CompraProducto(empleadoIniciado);
            comp.Show();
            this.Hide();
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            ABMempleados tabla = new ABMempleados(empleadoIniciado);
            tabla.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.empleadoIniciado = null;
            this.Hide();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            ABMProductos Productos = new ABMProductos(empleadoIniciado);
            Productos.Show();
            this.Hide();
        }
    }
}
