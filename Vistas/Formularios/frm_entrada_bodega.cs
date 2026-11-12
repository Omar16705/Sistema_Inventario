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
    public partial class frm_entrada_bodega : Form
    {
        public frm_entrada_bodega()
        {
            InitializeComponent();
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
            cargarCombox(); // <-- Agrega esta línea
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

        private void btnAgregarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                entrada_bodega entrada_Bodega = new entrada_bodega { 
                 Id_producto = Convert.ToInt32(cmbProducto.SelectedValue),
                 Cantidad = Convert.ToInt32(txtCant.Text),
                 Fecha_vencimiento = dtpVencimiento.Value,
                 Fecha_entrada = dtpFechaEntrada.Value,
                 Bodega = txtBodega.Text.Trim(),
                 Estante_refri = txtRefrigeradora.Text.Trim(),
                 Id_usuario = 1 // Aquí deberías asignar el ID del usuario actual, si lo tienes disponible
                };

                
                if (cmbProducto.SelectedValue == null || cmbProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un producto válido de la lista.");
                    return;
                }
                
                entrada_Bodega.insertarEntrada(entrada_Bodega);
                verEntrada();
                MessageBox.Show("Agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al obtener el producto seleccionado: " + ex.Message);
            }
        }



        public void cargarCombox()
        {
            try
            {
                Modelos.Entidades.Productos objProducto = new Modelos.Entidades.Productos();
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




    }
}
