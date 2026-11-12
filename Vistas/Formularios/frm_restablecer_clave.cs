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

namespace Vistas.Formularios
{
    public partial class frm_restablecer_clave : Form
    {
        public frm_restablecer_clave()
        {
            InitializeComponent();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            try
            {
               String nombreUsuario = txtNombreUsuario.Text;
                string nuevaContraseña = txtClaveNueva.Text;
                if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(nuevaContraseña))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }
                usuario.Nombre_usuario = nombreUsuario;
                usuario.Contraseña = nuevaContraseña;
                bool resultado = usuario.actualizar_contraseña(nuevaContraseña,nombreUsuario);
                if (resultado)
                {
                    MessageBox.Show("Contraseña restablecida correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo restablecer la contraseña. Verifique el nombre de usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restablecer la contraseña: " + ex.Message);
            }
        }

        private void pcOjo_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmarClave.PasswordChar = '\0';
            // 2. Cambia la imagen al ojo abierto
            pcOjoOcultar.Image = Properties.Resources.ojoabierto;
        }

        private void pcOjo_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmarClave.PasswordChar = '*';
            // 2. Vuelve a la imagen del ojo cerrado
            pcOjoOcultar.Image = Properties.Resources.ojocerrado;
        }

        private void pcOjoOcultar_MouseDown(object sender, MouseEventArgs e)
        {
            txtClaveNueva.PasswordChar = '\0';
            // 2. Cambia la imagen al ojo abierto
            pcOjoOcultar.Image = Properties.Resources.ojoabierto;
        }

        private void pcOjoOcultar_MouseUp(object sender, MouseEventArgs e)
        {
            txtClaveNueva.PasswordChar = '*';
            // 2. Vuelve a la imagen del ojo cerrado
            pcOjoOcultar.Image = Properties.Resources.ojocerrado;
        }
    }
}
