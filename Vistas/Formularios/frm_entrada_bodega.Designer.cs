namespace Vistas.Formularios
{
    partial class frm_entrada_bodega
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVerEntrada = new System.Windows.Forms.DataGridView();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnEliminarEntrada = new System.Windows.Forms.Button();
            this.btnActualizarEntrada = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnAgregarEntrada = new System.Windows.Forms.Button();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.txtRefrigeradora = new System.Windows.Forms.TextBox();
            this.txtBodega = new System.Windows.Forms.TextBox();
            this.lblRefrigeradora = new System.Windows.Forms.Label();
            this.lblBodega = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblUMedida = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFechaEntrada = new System.Windows.Forms.Label();
            this.lblIngresarDatosEntrada = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerEntrada)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerEntrada
            // 
            this.dgvVerEntrada.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVerEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVerEntrada.Location = new System.Drawing.Point(0, 205);
            this.dgvVerEntrada.Name = "dgvVerEntrada";
            this.dgvVerEntrada.Size = new System.Drawing.Size(1030, 399);
            this.dgvVerEntrada.TabIndex = 0;
            this.dgvVerEntrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerEntrada_CellContentClick);
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlDatos.Controls.Add(this.cmbProducto);
            this.pnlDatos.Controls.Add(this.dtpVencimiento);
            this.pnlDatos.Controls.Add(this.dtpFechaEntrada);
            this.pnlDatos.Controls.Add(this.btnEliminarEntrada);
            this.pnlDatos.Controls.Add(this.btnActualizarEntrada);
            this.pnlDatos.Controls.Add(this.btnLimpiarCampos);
            this.pnlDatos.Controls.Add(this.btnAgregarEntrada);
            this.pnlDatos.Controls.Add(this.txtCant);
            this.pnlDatos.Controls.Add(this.txtUnidadMedida);
            this.pnlDatos.Controls.Add(this.txtRefrigeradora);
            this.pnlDatos.Controls.Add(this.txtBodega);
            this.pnlDatos.Controls.Add(this.lblRefrigeradora);
            this.pnlDatos.Controls.Add(this.lblBodega);
            this.pnlDatos.Controls.Add(this.lblVencimiento);
            this.pnlDatos.Controls.Add(this.lblNombreProducto);
            this.pnlDatos.Controls.Add(this.lblUMedida);
            this.pnlDatos.Controls.Add(this.lblCantidad);
            this.pnlDatos.Controls.Add(this.lblFechaEntrada);
            this.pnlDatos.Controls.Add(this.lblIngresarDatosEntrada);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(1030, 205);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDatos_Paint);
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimiento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimiento.Location = new System.Drawing.Point(163, 129);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(259, 22);
            this.dtpVencimiento.TabIndex = 20;
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrada.Location = new System.Drawing.Point(163, 60);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(259, 22);
            this.dtpFechaEntrada.TabIndex = 19;
            // 
            // btnEliminarEntrada
            // 
            this.btnEliminarEntrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEntrada.Location = new System.Drawing.Point(926, 47);
            this.btnEliminarEntrada.Name = "btnEliminarEntrada";
            this.btnEliminarEntrada.Size = new System.Drawing.Size(92, 52);
            this.btnEliminarEntrada.TabIndex = 18;
            this.btnEliminarEntrada.Text = "Eliminar Entrada";
            this.btnEliminarEntrada.UseVisualStyleBackColor = true;
            // 
            // btnActualizarEntrada
            // 
            this.btnActualizarEntrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEntrada.Location = new System.Drawing.Point(828, 116);
            this.btnActualizarEntrada.Name = "btnActualizarEntrada";
            this.btnActualizarEntrada.Size = new System.Drawing.Size(92, 52);
            this.btnActualizarEntrada.TabIndex = 17;
            this.btnActualizarEntrada.Text = "Actualizar Entrada";
            this.btnActualizarEntrada.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(926, 116);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(92, 52);
            this.btnLimpiarCampos.TabIndex = 16;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEntrada
            // 
            this.btnAgregarEntrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEntrada.Location = new System.Drawing.Point(828, 45);
            this.btnAgregarEntrada.Name = "btnAgregarEntrada";
            this.btnAgregarEntrada.Size = new System.Drawing.Size(92, 52);
            this.btnAgregarEntrada.TabIndex = 15;
            this.btnAgregarEntrada.Text = "Agregar Entrada";
            this.btnAgregarEntrada.UseVisualStyleBackColor = true;
            this.btnAgregarEntrada.Click += new System.EventHandler(this.btnAgregarEntrada_Click);
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(163, 96);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(259, 20);
            this.txtCant.TabIndex = 14;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(609, 62);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(188, 20);
            this.txtUnidadMedida.TabIndex = 13;
            // 
            // txtRefrigeradora
            // 
            this.txtRefrigeradora.Location = new System.Drawing.Point(609, 128);
            this.txtRefrigeradora.Name = "txtRefrigeradora";
            this.txtRefrigeradora.Size = new System.Drawing.Size(188, 20);
            this.txtRefrigeradora.TabIndex = 11;
            // 
            // txtBodega
            // 
            this.txtBodega.Location = new System.Drawing.Point(163, 167);
            this.txtBodega.Name = "txtBodega";
            this.txtBodega.Size = new System.Drawing.Size(259, 20);
            this.txtBodega.TabIndex = 9;
            // 
            // lblRefrigeradora
            // 
            this.lblRefrigeradora.AutoSize = true;
            this.lblRefrigeradora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefrigeradora.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRefrigeradora.Location = new System.Drawing.Point(440, 128);
            this.lblRefrigeradora.Name = "lblRefrigeradora";
            this.lblRefrigeradora.Size = new System.Drawing.Size(111, 20);
            this.lblRefrigeradora.TabIndex = 7;
            this.lblRefrigeradora.Text = "Refrigeradora";
            // 
            // lblBodega
            // 
            this.lblBodega.AutoSize = true;
            this.lblBodega.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodega.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBodega.Location = new System.Drawing.Point(22, 165);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(68, 20);
            this.lblBodega.TabIndex = 6;
            this.lblBodega.Text = "Bodega";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblVencimiento.Location = new System.Drawing.Point(22, 131);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(102, 20);
            this.lblVencimiento.TabIndex = 5;
            this.lblVencimiento.Text = "Vencimiento";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombreProducto.Location = new System.Drawing.Point(440, 97);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(167, 20);
            this.lblNombreProducto.TabIndex = 4;
            this.lblNombreProducto.Text = "Nombre del Producto";
            // 
            // lblUMedida
            // 
            this.lblUMedida.AutoSize = true;
            this.lblUMedida.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUMedida.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUMedida.Location = new System.Drawing.Point(440, 60);
            this.lblUMedida.Name = "lblUMedida";
            this.lblUMedida.Size = new System.Drawing.Size(148, 20);
            this.lblUMedida.TabIndex = 3;
            this.lblUMedida.Text = "Unidad de Medida";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCantidad.Location = new System.Drawing.Point(22, 97);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(78, 20);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblFechaEntrada
            // 
            this.lblFechaEntrada.AutoSize = true;
            this.lblFechaEntrada.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFechaEntrada.Location = new System.Drawing.Point(22, 62);
            this.lblFechaEntrada.Name = "lblFechaEntrada";
            this.lblFechaEntrada.Size = new System.Drawing.Size(144, 20);
            this.lblFechaEntrada.TabIndex = 1;
            this.lblFechaEntrada.Text = "Fecha de Entrada:";
            // 
            // lblIngresarDatosEntrada
            // 
            this.lblIngresarDatosEntrada.AutoSize = true;
            this.lblIngresarDatosEntrada.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarDatosEntrada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblIngresarDatosEntrada.Location = new System.Drawing.Point(22, 20);
            this.lblIngresarDatosEntrada.Name = "lblIngresarDatosEntrada";
            this.lblIngresarDatosEntrada.Size = new System.Drawing.Size(191, 23);
            this.lblIngresarDatosEntrada.TabIndex = 0;
            this.lblIngresarDatosEntrada.Text = "Entrada de Bodega";
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(609, 94);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(188, 25);
            this.cmbProducto.TabIndex = 21;
            // 
            // frm_entrada_bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 516);
            this.Controls.Add(this.dgvVerEntrada);
            this.Controls.Add(this.pnlDatos);
            this.Name = "frm_entrada_bodega";
            this.Text = "frm_entrada_bodega";
            this.Load += new System.EventHandler(this.frm_entrada_bodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerEntrada)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerEntrada;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblUMedida;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFechaEntrada;
        private System.Windows.Forms.Label lblIngresarDatosEntrada;
        private System.Windows.Forms.TextBox txtBodega;
        private System.Windows.Forms.Label lblRefrigeradora;
        private System.Windows.Forms.Button btnAgregarEntrada;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.TextBox txtRefrigeradora;
        private System.Windows.Forms.Button btnEliminarEntrada;
        private System.Windows.Forms.Button btnActualizarEntrada;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.ComboBox cmbProducto;
    }
}