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
            cargarCombox();
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

        private void dgvVerSalida_DoubleClick(object sender, EventArgs e)
        {
            txtBodega.Text = dgvVerSalida.CurrentRow.Cells["BODEGA"].Value.ToString();
            txtCantidad.Text = dgvVerSalida.CurrentRow.Cells["CANTIDAD"].Value.ToString();
            txtRefrigeradora.Text = dgvVerSalida.CurrentRow.Cells["ESTANTE_REFRI"].Value.ToString();
            txtUso.Text = dgvVerSalida.CurrentRow.Cells["USO"].Value.ToString();
            dtpFechaSalida.Value = Convert.ToDateTime(dgvVerSalida.CurrentRow.Cells["FECHA_SALIDA"].Value);
            dtpFechaVencimiento.Value = Convert.ToDateTime(dgvVerSalida.CurrentRow.Cells["FECHA_VENCIMIENTO"].Value);
            cmbProducto.SelectedValue = Convert.ToInt32(dgvVerSalida.CurrentRow.Cells["ID_PRODUCTO"].Value);
        }


        public void cargarCombox()
        {
            try
            {
                Modelos.Entidades.producto objProducto = new Modelos.Entidades.producto();
                DataTable dtProductos = objProducto.mostrarProductos();

                // 1. Asignamos los datos
                cmbProducto.DataSource = dtProductos;
                cmbProducto.DisplayMember = "nombre_producto"; // Lo que el usuario lee y busca
                cmbProducto.ValueMember = "id_producto";       // El ID que guardaremos en la BD

                // 2. Activamos la búsqueda y autocompletado en tiempo real
                cmbProducto.DropDownStyle = ComboBoxStyle.DropDown;
                cmbProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbProducto.AutoCompleteSource = AutoCompleteSource.ListItems;

                // 3. Dejamos el combo sin elemento seleccionado al inicio
                cmbProducto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al cargar los productos: " + ex.Message);
            }
        }

        private void btnAgregarSalida_Click(object sender, EventArgs e)
        {
            try {
                salida_bodega salida_Bodega = new salida_bodega
                {
                    Nombre_producto = Convert.ToInt32(cmbProducto.SelectedValue),
                    Cantidad = Convert.ToInt32(txtCantidad.Text),
                    Fecha_vencimiento = dtpFechaVencimiento.Value,
                    Fecha_salida = dtpFechaSalida.Value,
                    Bodega = txtBodega.Text,
                    Estante_refri = txtRefrigeradora.Text,
                    Uso = txtUso.Text,
                    Id_usuario = 1 // Aquí deberías obtener el ID del usuario actual
                };
                salida_Bodega.insertarSalida(salida_Bodega);
                verSalidas();
                MessageBox.Show("Agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error al agregar la salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtBodega.Clear();
            txtCantidad.Clear();
            txtRefrigeradora.Clear();
            txtUso.Clear();
            cmbProducto.SelectedValue = -1;
        }

        private void btnActualizarSalida_Click(object sender, EventArgs e)
        {
            try { 
                salida_bodega salida_Bodega = new salida_bodega
                {
                    Id_salida = Convert.ToInt32(dgvVerSalida.CurrentRow.Cells["ID_SALIDA"].Value),
                    Nombre_producto = Convert.ToInt32(cmbProducto.SelectedValue),
                    Cantidad = Convert.ToInt32(txtCantidad.Text),
                    Fecha_vencimiento = dtpFechaVencimiento.Value,
                    Fecha_salida = dtpFechaSalida.Value,
                    Bodega = txtBodega.Text,
                    Estante_refri = txtRefrigeradora.Text,
                    Uso = txtUso.Text,
                    Id_usuario = 1 // Aquí deberías obtener el ID del usuario actual
                };
                if (salida_Bodega.actualizarSalida(salida_Bodega))
                {
                    verSalidas();
                    MessageBox.Show("Salida actualizada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al actualizar la salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarSalida_Click(object sender, EventArgs e)
        {
            try { 
                 salida_bodega salida_Bodega = new salida_bodega();
                int id_salida = Convert.ToInt32(dgvVerSalida.CurrentRow.Cells["ID_SALIDA"].Value);
                if (salida_Bodega.eliminarSalida(id_salida))
                {
                    verSalidas();
                    MessageBox.Show("Salida eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error al eliminar la salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
