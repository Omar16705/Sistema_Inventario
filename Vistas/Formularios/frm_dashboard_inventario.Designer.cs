namespace Vistas.Formularios
{
    partial class frm_dashboard_inventario
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
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEntradaBodega = new System.Windows.Forms.Button();
            this.btnSalidaBodega = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlOpciones.Controls.Add(this.btnSalir);
            this.pnlOpciones.Controls.Add(this.btnSalidaBodega);
            this.pnlOpciones.Controls.Add(this.btnEntradaBodega);
            this.pnlOpciones.Controls.Add(this.panel1);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(199, 524);
            this.pnlOpciones.TabIndex = 0;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(199, 0);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(706, 524);
            this.pnlCentral.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 131);
            this.panel1.TabIndex = 0;
            // 
            // btnEntradaBodega
            // 
            this.btnEntradaBodega.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntradaBodega.FlatAppearance.BorderSize = 0;
            this.btnEntradaBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradaBodega.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradaBodega.ForeColor = System.Drawing.Color.Snow;
            this.btnEntradaBodega.Location = new System.Drawing.Point(0, 131);
            this.btnEntradaBodega.Name = "btnEntradaBodega";
            this.btnEntradaBodega.Size = new System.Drawing.Size(199, 71);
            this.btnEntradaBodega.TabIndex = 1;
            this.btnEntradaBodega.Text = "Entrada de Bodega";
            this.btnEntradaBodega.UseVisualStyleBackColor = true;
            // 
            // btnSalidaBodega
            // 
            this.btnSalidaBodega.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalidaBodega.FlatAppearance.BorderSize = 0;
            this.btnSalidaBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalidaBodega.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidaBodega.ForeColor = System.Drawing.Color.Snow;
            this.btnSalidaBodega.Location = new System.Drawing.Point(0, 202);
            this.btnSalidaBodega.Name = "btnSalidaBodega";
            this.btnSalidaBodega.Size = new System.Drawing.Size(199, 71);
            this.btnSalidaBodega.TabIndex = 2;
            this.btnSalidaBodega.Text = "Salida de Bodega";
            this.btnSalidaBodega.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Snow;
            this.btnSalir.Location = new System.Drawing.Point(0, 453);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(199, 71);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frm_dashboard_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 524);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlOpciones);
            this.Name = "frm_dashboard_inventario";
            this.Text = "dashboard_inventario";
            this.Load += new System.EventHandler(this.frm_dashboard_inventario_Load);
            this.pnlOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Button btnSalidaBodega;
        private System.Windows.Forms.Button btnEntradaBodega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
    }
}