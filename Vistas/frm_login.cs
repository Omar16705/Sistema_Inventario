using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Formularios;

namespace Vistas
{
    public partial class frm_login : Form
    {

        public static frm_login InstanciaLogin;

        public frm_login()
        {
            InitializeComponent();
            InstanciaLogin = this;
            this.AcceptButton = btnIngresar ;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Por favor ingrese sus credenciales de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                txtClave.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese su nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Por favor ingrese su contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return;
            }



            try
            {
                // Crear instancia de usuario
                Usuario usuarioLogin = new Usuario
                {
                    Nombre_usuario = txtNombre.Text,
                    Contraseña = txtClave.Text
                   // Contraseña en texto plano para verificación
                };

                // Intentar login
                bool accesoValido = usuarioLogin.Ingresar();

                if (accesoValido)
                {
                    // Login exitoso

                    MessageBox.Show("Bienvenido al Sistema: " + usuarioLogin.Nombre_usuario, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); // Oculta el login
                    frm_dashboard_inventario frm_Dashboard_ = new frm_dashboard_inventario();
                    frm_Dashboard_.Show();
                }
                else
                {
                    // Login fallido
                    MessageBox.Show("Usuario o contraseña incorrectos",
                                   "Error de inicio de sesión",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);

                    // Limpiar campo de contraseña
                    txtNombre.Text = "";
                    txtNombre.Focus();
                    txtClave.Text = "";
                    txtClave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }



        }
    }
}
