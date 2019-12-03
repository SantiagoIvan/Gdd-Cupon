namespace FrbaOfertas.Facturar
{
    partial class ReporteDeFacturacion
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
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateFechaMinima = new System.Windows.Forms.DateTimePicker();
            this.dateFechaMaxima = new System.Windows.Forms.DateTimePicker();
            this.lblFechaMinima = new System.Windows.Forms.Label();
            this.lblFechaMaxima = new System.Windows.Forms.Label();
            this.dgOfertasAFacturar = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgOfertasAFacturar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(132, 21);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.ReadOnly = true;
            this.txtCuit.Size = new System.Drawing.Size(196, 20);
            this.txtCuit.TabIndex = 0;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(29, 24);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(76, 13);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "Cuit proveedor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(352, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dateFechaMinima
            // 
            this.dateFechaMinima.Location = new System.Drawing.Point(26, 44);
            this.dateFechaMinima.Name = "dateFechaMinima";
            this.dateFechaMinima.Size = new System.Drawing.Size(200, 20);
            this.dateFechaMinima.TabIndex = 2;
            // 
            // dateFechaMaxima
            // 
            this.dateFechaMaxima.Location = new System.Drawing.Point(320, 44);
            this.dateFechaMaxima.Name = "dateFechaMaxima";
            this.dateFechaMaxima.Size = new System.Drawing.Size(200, 20);
            this.dateFechaMaxima.TabIndex = 3;
            // 
            // lblFechaMinima
            // 
            this.lblFechaMinima.AutoSize = true;
            this.lblFechaMinima.Location = new System.Drawing.Point(23, 28);
            this.lblFechaMinima.Name = "lblFechaMinima";
            this.lblFechaMinima.Size = new System.Drawing.Size(73, 13);
            this.lblFechaMinima.TabIndex = 6;
            this.lblFechaMinima.Text = "Fecha Minima";
            // 
            // lblFechaMaxima
            // 
            this.lblFechaMaxima.AutoSize = true;
            this.lblFechaMaxima.Location = new System.Drawing.Point(319, 28);
            this.lblFechaMaxima.Name = "lblFechaMaxima";
            this.lblFechaMaxima.Size = new System.Drawing.Size(76, 13);
            this.lblFechaMaxima.TabIndex = 7;
            this.lblFechaMaxima.Text = "Fecha Maxima";
            // 
            // dgOfertasAFacturar
            // 
            this.dgOfertasAFacturar.AllowUserToAddRows = false;
            this.dgOfertasAFacturar.AllowUserToDeleteRows = false;
            this.dgOfertasAFacturar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOfertasAFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOfertasAFacturar.Location = new System.Drawing.Point(32, 171);
            this.dgOfertasAFacturar.MultiSelect = false;
            this.dgOfertasAFacturar.Name = "dgOfertasAFacturar";
            this.dgOfertasAFacturar.ReadOnly = true;
            this.dgOfertasAFacturar.Size = new System.Drawing.Size(559, 239);
            this.dgOfertasAFacturar.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(32, 429);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(516, 429);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(75, 23);
            this.btnFacturar.TabIndex = 4;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateFechaMinima);
            this.groupBox1.Controls.Add(this.dateFechaMaxima);
            this.groupBox1.Controls.Add(this.lblFechaMinima);
            this.groupBox1.Controls.Add(this.lblFechaMaxima);
            this.groupBox1.Location = new System.Drawing.Point(32, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 78);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intervalo de fechas";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(337, 148);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(69, 13);
            this.lblImporte.TabIndex = 13;
            this.lblImporte.Text = "Importe Total";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(452, 145);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nro. Factura";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(132, 145);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.ReadOnly = true;
            this.txtFactura.Size = new System.Drawing.Size(100, 20);
            this.txtFactura.TabIndex = 16;
            // 
            // ReporteDeFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 464);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgOfertasAFacturar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.txtCuit);
            this.Name = "ReporteDeFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Facturacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReporteDeFacturacion_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgOfertasAFacturar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dateFechaMinima;
        private System.Windows.Forms.DateTimePicker dateFechaMaxima;
        private System.Windows.Forms.Label lblFechaMinima;
        private System.Windows.Forms.Label lblFechaMaxima;
        private System.Windows.Forms.DataGridView dgOfertasAFacturar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFactura;
    }
}