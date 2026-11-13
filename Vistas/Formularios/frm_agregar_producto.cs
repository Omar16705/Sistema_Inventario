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
    public partial class frm_agregar_producto : Form
    {
        public frm_agregar_producto()
        {
            InitializeComponent();
        }

        private void frm_agregar_producto_Load(object sender, EventArgs e)
        {
            mostrarProductos();
            ConfigurarDataGridView();
        }

        //private void ConfigurarDataGridView(DataGridView dgv)
        //{
        //    // 1. AJUSTE AUTOMÁTICO DE COLUMNAS AL TEXTO
        //    // AllCells hace que cada columna mida exactamente lo que mida el texto más largo (celda o título)
        //    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        //    dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Mejor rendimiento fijar altura de fila

        //    // 2. TAMAÑO Y ESPACIADO (Más cómodo y profesional)
        //    dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        //    dgv.ColumnHeadersHeight = 20;       // Altura del encabezado
        //    dgv.RowTemplate.Height = 20;         // Altura de cada fila
        //    dgv.AllowUserToResizeRows = false;  // Evita que el usuario deforme las filas

        //    // 3. FONDO Y BORDES
        //    dgv.BorderStyle = BorderStyle.None;
        //    dgv.BackgroundColor = Color.White;  // Quita el fondo gris por defecto cuando hay pocas filas
        //    dgv.GridColor = Color.FromArgb(230, 230, 230); // Líneas divisorias sutiles
        //    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Solo líneas horizontales

        //    // 4. ESTILO DE ENCABEZADOS
        //    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        //    dgv.EnableHeadersVisualStyles = false;
        //    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255); // Azul moderno
        //    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        //    dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Alineado a la izquierda luce más ordenado
        //    dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 6, 0);

        //    // 5. FILAS Y COLORES ALTERNADOS (Efecto cebra)
        //    dgv.RowsDefaultCellStyle.BackColor = Color.White;
        //    dgv.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9);
        //    dgv.RowsDefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
        //    dgv.RowsDefaultCellStyle.Padding = new Padding(6, 0, 6, 0);

        //    dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250); // Gris azulado tenue

        //    // 6. SELECCIÓN DE FILA
        //    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgv.MultiSelect = false; // Solo permite seleccionar una fila a la vez
        //    dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 229, 255); // Azul suave
        //    dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

        //    // 7. COMPORTAMIENTO Y PERMISOS
        //    dgv.AllowUserToAddRows = false;     // Sin fila vacía al final
        //    dgv.AllowUserToDeleteRows = false;
        //    dgv.ReadOnly = true;                // Solo lectura
        //    dgv.RowHeadersVisible = false;      // Quita la columna gris de la izquierda

        //    // 8. EVITAR PARPADEO (Flicker) al hacer scroll
        //    typeof(DataGridView).InvokeMember("DoubleBuffered",
        //        System.Reflection.BindingFlags.NonPublic |
        //        System.Reflection.BindingFlags.Instance |
        //        System.Reflection.BindingFlags.SetProperty,
        //        null, dgv, new object[] { true });
        //}

        private void ConfigurarDataGridView()
        {
            // Ajustar tamaño
            dgvVerProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVerProducto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Quitar bordes
            dgvVerProducto.BorderStyle = BorderStyle.None;

            // Estilo de encabezados
            dgvVerProducto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVerProducto.EnableHeadersVisualStyles = false;
            dgvVerProducto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255); // Azul moderno
            dgvVerProducto.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVerProducto.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            dgvVerProducto.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Filas alternadas
            dgvVerProducto.RowsDefaultCellStyle.BackColor = Color.White;
            dgvVerProducto.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Gris claro

            // Fuente y colores de celdas
            dgvVerProducto.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            dgvVerProducto.DefaultCellStyle.ForeColor = Color.Black;
            dgvVerProducto.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // Azul claro
            dgvVerProducto.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvVerProducto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Quitar fila vacía
            dgvVerProducto.AllowUserToAddRows = false;

            // Deshabilitar edición (opcional)
            dgvVerProducto.ReadOnly = true;

            // Ajustar selección completa de fila
            dgvVerProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Quitar encabezado de filas
            dgvVerProducto.RowHeadersVisible = false;
        }

        public void mostrarProductos()
        {
            try
            {
                producto productos = new producto();
                dgvVerProducto.DataSource = productos.mostrarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar productos: " + ex.Message);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                producto productos = new producto();
                productos.Nombre_producto = txtNombreProdcto.Text;
                productos.Descripcion_producto = txtDescripcion.Text;
                productos.Unidad_medida = txtUMedida.Text;
                productos.insertarProducto(productos);
                MessageBox.Show("Producto agregado correctamente.");
                mostrarProductos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreProdcto.Clear();
            txtDescripcion.Clear();
            txtUMedida.Clear();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                producto producto = new producto();
                if (dgvVerProducto.SelectedRows.Count > 0)
                {
                    int idProducto = Convert.ToInt32(dgvVerProducto.SelectedRows[0].Cells["id_producto"].Value);
                    producto.Id_producto = idProducto;
                    // Aquí deberías implementar un método para eliminar el producto de la base de datos
                    producto.eliminarProducto(idProducto);
                    MessageBox.Show("Producto eliminado correctamente.");
                    mostrarProductos();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);

            }
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            try { 
                producto producto = new producto() { 
                Nombre_producto = txtNombreProdcto.Text,
                Descripcion_producto = txtDescripcion.Text,
                Unidad_medida = txtUMedida.Text
                };
                producto.Id_producto = Convert.ToInt32(dgvVerProducto.CurrentRow.Cells["ID_PRODUCTO"].Value);
                if(producto.actualizarProducto(producto))
                {
                    MessageBox.Show("Producto actualizado correctamente.");
                    mostrarProductos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el producto.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message);
            }

        }

        private void dgvVerProducto_DoubleClick(object sender, EventArgs e)
        {
            txtNombreProdcto.Text = dgvVerProducto.CurrentRow.Cells["NOMBRE_PRODUCTO"].Value.ToString();
            txtDescripcion.Text = dgvVerProducto.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
            txtUMedida.Text = dgvVerProducto.CurrentRow.Cells["UNIDAD_MEDIDA"].Value.ToString();
        }
    }
}
