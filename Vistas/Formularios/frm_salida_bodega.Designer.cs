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
            this.btnAgregarSalida = new System.Windows.Forms.Button();
            this.lblIngresarDatosEntrada = new System.Windows.Forms.Label();
            this.dgvVerSalida = new System.Windows.Forms.DataGridView();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnEliminarSalida = new System.Windows.Forms.Button();
            this.btnActualizarSalida = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlDatos.Controls.Add(this.textBox1);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Controls.Add(this.dateTimePicker2);
            this.pnlDatos.Controls.Add(this.dateTimePicker1);
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
            this.pnlDatos.Controls.Add(this.btnActualizarSalida);
            this.pnlDatos.Controls.Add(this.btnEliminarSalida);
            this.pnlDatos.Controls.Add(this.btnLimpiarCampos);
            this.pnlDatos.Controls.Add(this.btnAgregarSalida);
            this.pnlDatos.Controls.Add(this.lblIngresarDatosEntrada);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(860, 200);
            this.pnlDatos.TabIndex = 2;
            // 
            // btnAgregarSalida
            // 
            this.btnAgregarSalida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSalida.Location = new System.Drawing.Point(663, 34);
            this.btnAgregarSalida.Name = "btnAgregarSalida";
            this.btnAgregarSalida.Size = new System.Drawing.Size(92, 45);
            this.btnAgregarSalida.TabIndex = 15;
            this.btnAgregarSalida.Text = "Agregar Salida";
            this.btnAgregarSalida.UseVisualStyleBackColor = true;
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
            this.dgvVerSalida.Location = new System.Drawing.Point(0, 200);
            this.dgvVerSalida.Name = "dgvVerSalida";
            this.dgvVerSalida.Size = new System.Drawing.Size(860, 313);
            this.dgvVerSalida.TabIndex = 3;
            this.dgvVerSalida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerSalida_CellContentClick);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(761, 92);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(96, 47);
            this.btnLimpiarCampos.TabIndex = 18;
            this.btnLimpiarCampos.Text = "Limpiar Campos\r\n";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarSalida
            // 
            this.btnEliminarSalida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSalida.Location = new System.Drawing.Point(761, 34);
            this.btnEliminarSalida.Name = "btnEliminarSalida";
            this.btnEliminarSalida.Size = new System.Drawing.Size(96, 51);
            this.btnEliminarSalida.TabIndex = 19;
            this.btnEliminarSalida.Text = "Eliminar Salida";
            this.btnEliminarSalida.UseVisualStyleBackColor = true;
            // 
            // btnActualizarSalida
            // 
            this.btnActualizarSalida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarSalida.Location = new System.Drawing.Point(663, 91);
            this.btnActualizarSalida.Name = "btnActualizarSalida";
            this.btnActualizarSalida.Size = new System.Drawing.Size(96, 48);
            this.btnActualizarSalida.TabIndex = 20;
            this.btnActualizarSalida.Text = "Actualizar Salida";
            this.btnActualizarSalida.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(110, 113);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(245, 21);
            this.dateTimePicker2.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(102, 82);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(166, 20);
            this.textBox7.TabIndex = 32;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(515, 47);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(142, 20);
            this.textBox6.TabIndex = 31;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(527, 83);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 20);
            this.textBox5.TabIndex = 30;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(478, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 20);
            this.textBox4.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 20);
            this.textBox2.TabIndex = 28;
            // 
            // lblRefrigeradora
            // 
            this.lblRefrigeradora.AutoSize = true;
            this.lblRefrigeradora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefrigeradora.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRefrigeradora.Location = new System.Drawing.Point(354, 114);
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
            this.lblBodega.Location = new System.Drawing.Point(10, 147);
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
            this.lblVencimiento.Location = new System.Drawing.Point(9, 113);
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
            this.lblNombreProducto.Location = new System.Drawing.Point(354, 81);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(167, 20);
            this.lblNombreProducto.TabIndex = 24;
            this.lblNombreProducto.Text = "Nombre del Producto";
            // 
            // lblUMedida
            // 
            this.lblUMedida.AutoSize = true;
            this.lblUMedida.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUMedida.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUMedida.Location = new System.Drawing.Point(361, 47);
            this.lblUMedida.Name = "lblUMedida";
            this.lblUMedida.Size = new System.Drawing.Size(148, 20);
            this.lblUMedida.TabIndex = 23;
            this.lblUMedida.Text = "Unidad de Medida";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCantidad.Location = new System.Drawing.Point(9, 83);
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
            this.lblFechaEntrada.Location = new System.Drawing.Point(10, 47);
            this.lblFechaEntrada.Name = "lblFechaEntrada";
            this.lblFechaEntrada.Size = new System.Drawing.Size(55, 20);
            this.lblFechaEntrada.TabIndex = 21;
            this.lblFechaEntrada.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(354, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Uso";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(396, 147);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 47);
            this.textBox1.TabIndex = 36;
            // 
            // frm_salida_bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 524);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblRefrigeradora;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblUMedida;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFechaEntrada;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}