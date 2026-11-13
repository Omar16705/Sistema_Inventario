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
    public partial class frm_buscar_datos : Form
    {
        public frm_buscar_datos()
        {
            InitializeComponent();
        }
        private readonly entrada_salida _datos = new entrada_salida();
        private void frm_buscar_datos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            DarFormatoColumnas();
            CargarDatos();
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

        private void DarFormatoColumnas()
        {
            if (dgvBuscar.Columns.Count == 0) return;
            // Ocultar IDs que el usuario no necesita ver
            if (dgvBuscar.Columns.Contains("IdMovimiento")) dgvBuscar.Columns["IdMovimiento"].Visible = false;
            if (dgvBuscar.Columns.Contains("IdEntrada")) dgvBuscar.Columns["IdEntrada"].Visible = false;
            if (dgvBuscar.Columns.Contains("IdSalida")) dgvBuscar.Columns["IdSalida"].Visible = false;
            if (dgvBuscar.Columns.Contains("IdProducto")) dgvBuscar.Columns["IdProducto"].Visible = false;
            // Encabezados amigables
            dgvBuscar.Columns["CodigoMovimiento"].HeaderText = "Código";
            dgvBuscar.Columns["TipoMovimiento"].HeaderText = "Tipo";
            dgvBuscar.Columns["FechaMovimiento"].HeaderText = "Fecha Registro";
            dgvBuscar.Columns["NombreProducto"].HeaderText = "Producto";
            dgvBuscar.Columns["UnidadMedida"].HeaderText = "Unidad";
            dgvBuscar.Columns["Cantidad"].HeaderText = "Cant.";
            dgvBuscar.Columns["FechaVencimiento"].HeaderText = "Vencimiento";
            dgvBuscar.Columns["Bodega"].HeaderText = "Bodega";
            dgvBuscar.Columns["EstanteRefri"].HeaderText = "Estante / Refri";
            dgvBuscar.Columns["Uso"].HeaderText = "Uso / Destino";
            // Formato visual de fechas
                dgvBuscar.Columns["FechaMovimiento"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvBuscar.Columns["FechaVencimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void CargarDatos(string filtro = "")
        {
            try
            {
                List<EntidadMovimientoBodega> movimientos = _datos.ListarMovimientos(filtro);

                // Asignar lista a la propiedad DataSource del DataGridView
                dgvBuscar.DataSource = null;
                dgvBuscar.DataSource = movimientos;
                DarFormatoColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar movimientos: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos(txtBuscar.Text.Trim());
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnBuscar.PerformClick();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarDatos();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
