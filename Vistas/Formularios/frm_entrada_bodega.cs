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
    public partial class frm_entrada_bodega : Form
    {
        public frm_entrada_bodega()
        {
            InitializeComponent();
        }
        private void ConfigurarDataGridView()
        {
            // Ajustar tamaño
            dgvVerEntrada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVerEntrada.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Quitar bordes
            dgvVerEntrada.BorderStyle = BorderStyle.None;

            // Estilo de encabezados
            dgvVerEntrada.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVerEntrada.EnableHeadersVisualStyles = false;
            dgvVerEntrada.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255); // Azul moderno
            dgvVerEntrada.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVerEntrada.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            dgvVerEntrada.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Filas alternadas
            dgvVerEntrada.RowsDefaultCellStyle.BackColor = Color.White;
            dgvVerEntrada.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Gris claro

            // Fuente y colores de celdas
            dgvVerEntrada.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            dgvVerEntrada.DefaultCellStyle.ForeColor = Color.Black;
            dgvVerEntrada.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // Azul claro
            dgvVerEntrada.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvVerEntrada.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Quitar fila vacía
            dgvVerEntrada.AllowUserToAddRows = false;

            // Deshabilitar edición (opcional)
            dgvVerEntrada.ReadOnly = true;

            // Ajustar selección completa de fila
            dgvVerEntrada.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Quitar encabezado de filas
            dgvVerEntrada.RowHeadersVisible = false;
        }



        private void frm_entrada_bodega_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            verEntrada();
        }

        private void dgvVerEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvVerEntrada.DataSource = Modelos.Entidades.entrada_bodega.ObtenerDatos();
        }

        public void verEntrada()
        {
            dgvVerEntrada.DataSource = Modelos.Entidades.entrada_bodega.ObtenerDatos();
        }

        private void pnlDatos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
