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
    public partial class frm_salida_bodega : Form
    {
        public frm_salida_bodega()
        {
            InitializeComponent();
        }

        private void lblIngresarDatosEntrada_Click(object sender, EventArgs e)
        {

        }

        private void dgvVerSalida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_salida_bodega_Load(object sender, EventArgs e)
        {
            verSalidas();
            ConfigurarDataGridView();
        }

        public void verSalidas() {
            dgvVerSalida.DataSource = salida_bodega.ObtenerDatos();
        }

        private void ConfigurarDataGridView()
        {
            // Ajustar tamaño
            dgvVerSalida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVerSalida.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Quitar bordes
            dgvVerSalida.BorderStyle = BorderStyle.None;

            // Estilo de encabezados
            dgvVerSalida.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVerSalida.EnableHeadersVisualStyles = false;
            dgvVerSalida.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255); // Azul moderno
            dgvVerSalida.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVerSalida.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            dgvVerSalida.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Filas alternadas
            dgvVerSalida.RowsDefaultCellStyle.BackColor = Color.White;
            dgvVerSalida.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Gris claro

            // Fuente y colores de celdas
            dgvVerSalida.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            dgvVerSalida.DefaultCellStyle.ForeColor = Color.Black;
            dgvVerSalida.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // Azul claro
            dgvVerSalida.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvVerSalida.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Quitar fila vacía
            dgvVerSalida.AllowUserToAddRows = false;

            // Deshabilitar edición (opcional)
            dgvVerSalida.ReadOnly = true;

            // Ajustar selección completa de fila
            dgvVerSalida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Quitar encabezado de filas
            dgvVerSalida.RowHeadersVisible = false;
        }

    }
}
