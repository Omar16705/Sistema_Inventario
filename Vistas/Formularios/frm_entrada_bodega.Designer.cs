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
            this.btnAgregarEntrada = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblRefrigeradora = new System.Windows.Forms.Label();
            this.lblBodega = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblUMedida = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFechaEntrada = new System.Windows.Forms.Label();
            this.lblIngresarDatosEntrada = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizarEntrada = new System.Windows.Forms.Button();
            this.btnEliminarEntrada = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerEntrada)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerEntrada
            // 
            this.dgvVerEntrada.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVerEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVerEntrada.Location = new System.Drawing.Point(0, 194);
            this.dgvVerEntrada.Name = "dgvVerEntrada";
            this.dgvVerEntrada.Size = new System.Drawing.Size(872, 335);
            this.dgvVerEntrada.TabIndex = 0;
            this.dgvVerEntrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerEntrada_CellContentClick);
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlDatos.Controls.Add(this.dateTimePicker2);
            this.pnlDatos.Controls.Add(this.dateTimePicker1);
            this.pnlDatos.Controls.Add(this.btnEliminarEntrada);
            this.pnlDatos.Controls.Add(this.btnActualizarEntrada);
            this.pnlDatos.Controls.Add(this.btnLimpiarCampos);
            this.pnlDatos.Controls.Add(this.btnAgregarEntrada);
            this.pnlDatos.Controls.Add(this.textBox7);
            this.pnlDatos.Controls.Add(this.textBox6);
            this.pnlDatos.Controls.Add(this.textBox5);
            this.pnlDatos.Controls.Add(this.textBox4);
            this.pnlDatos.Controls.Add(this.textBox2);
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
            this.pnlDatos.Size = new System.Drawing.Size(872, 194);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDatos_Paint);
            // 
            // btnAgregarEntrada
            // 
            this.btnAgregarEntrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEntrada.Location = new System.Drawing.Point(676, 34);
            this.btnAgregarEntrada.Name = "btnAgregarEntrada";
            this.btnAgregarEntrada.Size = new System.Drawing.Size(92, 52);
            this.btnAgregarEntrada.TabIndex = 15;
            this.btnAgregarEntrada.Text = "Agregar Entrada";
            this.btnAgregarEntrada.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(105, 82);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(166, 20);
            this.textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(518, 47);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(142, 20);
            this.textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(530, 83);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(481, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 20);
            this.textBox2.TabIndex = 9;
            // 
            // lblRefrigeradora
            // 
            this.lblRefrigeradora.AutoSize = true;
            this.lblRefrigeradora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefrigeradora.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRefrigeradora.Location = new System.Drawing.Point(364, 115);
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
            this.lblBodega.Location = new System.Drawing.Point(13, 147);
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
            this.lblVencimiento.Location = new System.Drawing.Point(12, 113);
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
            this.lblNombreProducto.Location = new System.Drawing.Point(364, 82);
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
            this.lblUMedida.Location = new System.Drawing.Point(364, 47);
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
            this.lblCantidad.Location = new System.Drawing.Point(12, 83);
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
            this.lblFechaEntrada.Location = new System.Drawing.Point(13, 47);
            this.lblFechaEntrada.Name = "lblFechaEntrada";
            this.lblFechaEntrada.Size = new System.Drawing.Size(55, 20);
            this.lblFechaEntrada.TabIndex = 1;
            this.lblFechaEntrada.Text = "Fecha";
            // 
            // lblIngresarDatosEntrada
            // 
            this.lblIngresarDatosEntrada.AutoSize = true;
            this.lblIngresarDatosEntrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarDatosEntrada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblIngresarDatosEntrada.Location = new System.Drawing.Point(12, 9);
            this.lblIngresarDatosEntrada.Name = "lblIngresarDatosEntrada";
            this.lblIngresarDatosEntrada.Size = new System.Drawing.Size(160, 19);
            this.lblIngresarDatosEntrada.TabIndex = 0;
            this.lblIngresarDatosEntrada.Text = "Entrada de Bodega";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(774, 108);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(92, 52);
            this.btnLimpiarCampos.TabIndex = 16;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // btnActualizarEntrada
            // 
            this.btnActualizarEntrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEntrada.Location = new System.Drawing.Point(676, 106);
            this.btnActualizarEntrada.Name = "btnActualizarEntrada";
            this.btnActualizarEntrada.Size = new System.Drawing.Size(92, 52);
            this.btnActualizarEntrada.TabIndex = 17;
            this.btnActualizarEntrada.Text = "Actualizar Entrada";
            this.btnActualizarEntrada.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEntrada
            // 
            this.btnEliminarEntrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEntrada.Location = new System.Drawing.Point(774, 34);
            this.btnEliminarEntrada.Name = "btnEliminarEntrada";
            this.btnEliminarEntrada.Size = new System.Drawing.Size(92, 52);
            this.btnEliminarEntrada.TabIndex = 18;
            this.btnEliminarEntrada.Text = "Eliminar Entrada";
            this.btnEliminarEntrada.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(113, 113);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(245, 21);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // frm_entrada_bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 524);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblRefrigeradora;
        private System.Windows.Forms.Button btnAgregarEntrada;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnEliminarEntrada;
        private System.Windows.Forms.Button btnActualizarEntrada;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}