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
    public partial class frm_buscar_datos : Form
    {
        public frm_buscar_datos()
        {
            InitializeComponent();
        }

        private void frm_buscar_datos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            // Ajustar tamaño
            dgvBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBuscar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Quitar bordes
            dgvBuscar.BorderStyle = BorderStyle.None;

            // Estilo de encabezados
            dgvBuscar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBuscar.EnableHeadersVisualStyles = false;
            dgvBuscar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255); // Azul moderno
            dgvBuscar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBuscar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            dgvBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Filas alternadas
            dgvBuscar.RowsDefaultCellStyle.BackColor = Color.White;
            dgvBuscar.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Gris claro

            // Fuente y colores de celdas
            dgvBuscar.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            dgvBuscar.DefaultCellStyle.ForeColor = Color.Black;
            dgvBuscar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // Azul claro
            dgvBuscar.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvBuscar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Quitar fila vacía
            dgvBuscar.AllowUserToAddRows = false;

            // Deshabilitar edición (opcional)
            dgvBuscar.ReadOnly = true;

            // Ajustar selección completa de fila
            dgvBuscar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Quitar encabezado de filas
            dgvBuscar.RowHeadersVisible = false;
        }

    }
}
