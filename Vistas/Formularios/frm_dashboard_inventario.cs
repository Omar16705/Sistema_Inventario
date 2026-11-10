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
    }
}
