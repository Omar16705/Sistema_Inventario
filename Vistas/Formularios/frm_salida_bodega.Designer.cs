namespace Vistas.Formularios
{
    partial class frm_salida_bodega
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
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtUso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtRefrigeradora = new System.Windows.Forms.TextBox();
            this.txtBodega = new System.Windows.Forms.TextBox();
            this.lblRefrigeradora = new System.Windows.Forms.Label();
            this.lblBodega = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFechaEntrada = new System.Windows.Forms.Label();
            this.btnActualizarSalida = new System.Windows.Forms.Button();
            this.btnEliminarSalida = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnAgregarSalida = new System.Windows.Forms.Button();
            this.lblIngresarDatosEntrada = new System.Windows.Forms.Label();
            this.dgvVerSalida = new System.Windows.Forms.DataGridView();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlDatos.Controls.Add(this.cmbProducto);
            this.pnlDatos.Controls.Add(this.txtUso);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Controls.Add(this.dtpFechaVencimiento);
            this.pnlDatos.Controls.Add(this.dtpFechaSalida);
            this.pnlDatos.Controls.Add(this.txtCantidad);
            this.pnlDatos.Controls.Add(this.txtRefrigeradora);
            this.pnlDatos.Controls.Add(this.txtBodega);
            this.pnlDatos.Controls.Add(this.lblRefrigeradora);
            this.pnlDatos.Controls.Add(this.lblBodega);
            this.pnlDatos.Controls.Add(this.lblVencimiento);
            this.pnlDatos.Controls.Add(this.lblNombreProducto);
            this.pnlDatos.Controls.Add(this.lblCantidad);
            this.pnlDatos.Controls.Add(this.lblFechaEntrada);
            this.pnlDatos.Controls.Add(this.btnActualizarSalida);
            this.pnlDatos.Controls.Add(this.btnEliminarSalida);
            this.pnlDatos.Controls.Add(this.btnLimpiarCampos);
            this.pnlDatos.Controls.Add(this.btnAgregarSalida);
            this.pnlDatos.Controls.Add(this.lblIngresarDatosEntrada);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(1030, 205);
            this.pnlDatos.TabIndex = 2;
            // 
            // txtUso
            // 
            this.txtUso.Location = new System.Drawing.Point(438, 121);
            this.txtUso.Multiline = true;
            this.txtUso.Name = "txtUso";
            this.txtUso.Size = new System.Drawing.Size(324, 73);
            this.txtUso.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(396, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Uso";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVencimiento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(504, 78);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(258, 22);
            this.dtpFechaVencimiento.TabIndex = 34;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSalida.Location = new System.Drawing.Point(473, 43);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(289, 22);
            this.dtpFechaSalida.TabIndex = 33;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(102, 82);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(245, 20);
            this.txtCantidad.TabIndex = 32;
            // 
            // txtRefrigeradora
            // 
            this.txtRefrigeradora.Location = new System.Drawing.Point(129, 113);
            this.txtRefrigeradora.Name = "txtRefrigeradora";
            this.txtRefrigeradora.Size = new System.Drawing.Size(218, 20);
            this.txtRefrigeradora.TabIndex = 30;
            // 
            // txtBodega
            // 
            this.txtBodega.Location = new System.Drawing.Point(102, 154);
            this.txtBodega.Name = "txtBodega";
            this.txtBodega.Size = new System.Drawing.Size(261, 20);
            this.txtBodega.TabIndex = 28;
            // 
            // lblRefrigeradora
            // 
            this.lblRefrigeradora.AutoSize = true;
            this.lblRefrigeradora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefrigeradora.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRefrigeradora.Location = new System.Drawing.Point(12, 113);
            this.lblRefrigeradora.Name = "lblRefrigeradora";
            this.lblRefrigeradora.Size = new System.Drawing.Size(111, 20);
            this.lblRefrigeradora.TabIndex = 27;
            this.lblRefrigeradora.Text = "Refrigeradora";
            // 
            // lblBodega
            // 
            this.lblBodega.AutoSize = true;
            this.lblBodega.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodega.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBodega.Location = new System.Drawing.Point(22, 154);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(68, 20);
            this.lblBodega.TabIndex = 26;
            this.lblBodega.Text = "Bodega";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblVencimiento.Location = new System.Drawing.Point(396, 82);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(102, 20);
            this.lblVencimiento.TabIndex = 25;
            this.lblVencimiento.Text = "Vencimiento";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombreProducto.Location = new System.Drawing.Point(12, 45);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(167, 20);
            this.lblNombreProducto.TabIndex = 24;
            this.lblNombreProducto.Text = "Nombre del Producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCantidad.Location = new System.Drawing.Point(12, 82);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(78, 20);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblFechaEntrada
            // 
            this.lblFechaEntrada.AutoSize = true;
            this.lblFechaEntrada.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFechaEntrada.Location = new System.Drawing.Point(396, 43);
            this.lblFechaEntrada.Name = "lblFechaEntrada";
            this.lblFechaEntrada.Size = new System.Drawing.Size(55, 20);
            this.lblFechaEntrada.TabIndex = 21;
            this.lblFechaEntrada.Text = "Fecha";
            // 
            // btnActualizarSalida
            // 
            this.btnActualizarSalida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarSalida.Location = new System.Drawing.Point(814, 126);
            this.btnActualizarSalida.Name = "btnActualizarSalida";
            this.btnActualizarSalida.Size = new System.Drawing.Size(96, 48);
            this.btnActualizarSalida.TabIndex = 20;
            this.btnActualizarSalida.Text = "Actualizar Salida";
            this.btnActualizarSalida.UseVisualStyleBackColor = true;
            this.btnActualizarSalida.Click += new System.EventHandler(this.btnActualizarSalida_Click);
            // 
            // btnEliminarSalida
            // 
            this.btnEliminarSalida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSalida.Location = new System.Drawing.Point(931, 47);
            this.btnEliminarSalida.Name = "btnEliminarSalida";
            this.btnEliminarSalida.Size = new System.Drawing.Size(96, 53);
            this.btnEliminarSalida.TabIndex = 19;
            this.btnEliminarSalida.Text = "Eliminar Salida";
            this.btnEliminarSalida.UseVisualStyleBackColor = true;
            this.btnEliminarSalida.Click += new System.EventHandler(this.btnEliminarSalida_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(931, 126);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(96, 48);
            this.btnLimpiarCampos.TabIndex = 18;
            this.btnLimpiarCampos.Text = "Limpiar Campos\r\n";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnAgregarSalida
            // 
            this.btnAgregarSalida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSalida.Location = new System.Drawing.Point(814, 47);
            this.btnAgregarSalida.Name = "btnAgregarSalida";
            this.btnAgregarSalida.Size = new System.Drawing.Size(92, 55);
            this.btnAgregarSalida.TabIndex = 15;
            this.btnAgregarSalida.Text = "Agregar Salida";
            this.btnAgregarSalida.UseVisualStyleBackColor = true;
            this.btnAgregarSalida.Click += new System.EventHandler(this.btnAgregarSalida_Click);
            // 
            // lblIngresarDatosEntrada
            // 
            this.lblIngresarDatosEntrada.AutoSize = true;
            this.lblIngresarDatosEntrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarDatosEntrada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblIngresarDatosEntrada.Location = new System.Drawing.Point(12, 9);
            this.lblIngresarDatosEntrada.Name = "lblIngresarDatosEntrada";
            this.lblIngresarDatosEntrada.Size = new System.Drawing.Size(149, 19);
            this.lblIngresarDatosEntrada.TabIndex = 0;
            this.lblIngresarDatosEntrada.Text = "Salida de Bodega";
            this.lblIngresarDatosEntrada.Click += new System.EventHandler(this.lblIngresarDatosEntrada_Click);
            // 
            // dgvVerSalida
            // 
            this.dgvVerSalida.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVerSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerSalida.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVerSalida.Location = new System.Drawing.Point(0, 205);
            this.dgvVerSalida.Name = "dgvVerSalida";
            this.dgvVerSalida.Size = new System.Drawing.Size(1030, 389);
            this.dgvVerSalida.TabIndex = 3;
            this.dgvVerSalida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerSalida_CellContentClick);
            this.dgvVerSalida.DoubleClick += new System.EventHandler(this.dgvVerSalida_DoubleClick);
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(186, 43);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(161, 21);
            this.cmbProducto.TabIndex = 37;
            // 
            // frm_salida_bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 516);
            this.Controls.Add(this.dgvVerSalida);
            this.Controls.Add(this.pnlDatos);
            this.Name = "frm_salida_bodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_salida_bodega";
            this.Load += new System.EventHandler(this.frm_salida_bodega_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerSalida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnAgregarSalida;
        private System.Windows.Forms.Label lblIngresarDatosEntrada;
        private System.Windows.Forms.DataGridView dgvVerSalida;
        private System.Windows.Forms.Button btnActualizarSalida;
        private System.Windows.Forms.Button btnEliminarSalida;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtRefrigeradora;
        private System.Windows.Forms.TextBox txtBodega;
        private System.Windows.Forms.Label lblRefrigeradora;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFechaEntrada;
        private System.Windows.Forms.TextBox txtUso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProducto;
    }
}