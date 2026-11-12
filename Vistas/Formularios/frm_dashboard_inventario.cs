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
    public partial class frm_dashboard_inventario : Form
    {
        public frm_dashboard_inventario()
        {
            InitializeComponent();
        }

        private void frm_dashboard_inventario_Load(object sender, EventArgs e)
        {

        }

        #region

        private Form activarForm = null;


        private void abrirFormulario(Form formPintar) {

            if (activarForm != null)
            {
                activarForm.Close();
            }
            //

            activarForm = formPintar;
            formPintar.TopLevel = false;
            formPintar.FormBorderStyle = FormBorderStyle.None;
            formPintar.Dock = DockStyle.Fill;

            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(formPintar);
            formPintar.BringToFront();
            formPintar.Show();

        }

        #endregion

        private void btnEntradaBodega_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_entrada_bodega());
        }

        private void btnSalidaBodega_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_salida_bodega());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcionSeleccionada = MessageBox.Show("¿Quieres salir?", "Cerrando Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcionSeleccionada == DialogResult.Yes)
            {
                this.Close(); // Cerramos el dashboard
                frm_login.InstanciaLogin.Show();// Mostramos el login original por q si xdddd

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_buscar_datos());
        }

        private void btnGenerarReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frm_generar_reportes());
        }
    }
}
