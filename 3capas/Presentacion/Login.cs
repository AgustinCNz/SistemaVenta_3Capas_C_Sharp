using PP3capas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
          SQLconexionNegocio co = new SQLconexionNegocio();
          int Resultado = co.conSQLIniciarSesion(txtUsuario.Text, txtClave.Text);

         Empleado em = co.ObtenerUsuario(txtUsuario.Text, txtClave.Text);
           
            if (Resultado == 1)
            {
               
                MessageBox.Show("Bienvenido");
                MenuUsuario menu = new MenuUsuario(em); // QUE PASE EL EMPLEADO
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
