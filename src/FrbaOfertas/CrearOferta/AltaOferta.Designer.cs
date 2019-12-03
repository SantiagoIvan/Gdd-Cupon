namespace FrbaOfertas.CrearOferta
{
    partial class AltaOferta
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
            this.components = new System.ComponentModel.Container();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblLimiteCompra = new System.Windows.Forms.Label();
            this.lblprecioAntiguo = new System.Windows.Forms.Label();
            this.lblPrecioNuevo = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblPublicacion = new System.Windows.Forms.Label();
            this.groupBoxFechas = new System.Windows.Forms.GroupBox();
            this.calendarioPublicacion = new System.Windows.Forms.DateTimePicker();
            this.calendarioVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtLimiteCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioAntiguo = new System.Windows.Forms.TextBox();
            this.txtPrecioNuevo = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.validator = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(698, 406);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(12, 26);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "Stock";
            // 
            // lblLimiteCompra
            // 
            this.lblLimiteCompra.AutoSize = true;
            this.lblLimiteCompra.Location = new System.Drawing.Point(12, 82);
            this.lblLimiteCompra.Name = "lblLimiteCompra";
            this.lblLimiteCompra.Size = new System.Drawing.Size(88, 13);
            this.lblLimiteCompra.TabIndex = 2;
            this.lblLimiteCompra.Text = "Limite de Compra";
            // 
            // lblprecioAntiguo
            // 
            this.lblprecioAntiguo.AutoSize = true;
            this.lblprecioAntiguo.Location = new System.Drawing.Point(12, 138);
            this.lblprecioAntiguo.Name = "lblprecioAntiguo";
            this.lblprecioAntiguo.Size = new System.Drawing.Size(76, 13);
            this.lblprecioAntiguo.TabIndex = 3;
            this.lblprecioAntiguo.Text = "Precio Antiguo";
            // 
            // lblPrecioNuevo
            // 
            this.lblPrecioNuevo.AutoSize = true;
            this.lblPrecioNuevo.Location = new System.Drawing.Point(12, 200);
            this.lblPrecioNuevo.Name = "lblPrecioNuevo";
            this.lblPrecioNuevo.Size = new System.Drawing.Size(72, 13);
            this.lblPrecioNuevo.TabIndex = 4;
            this.lblPrecioNuevo.Text = "Precio Nuevo";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(12, 275);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(77, 13);
            this.lblProveedor.TabIndex = 5;
            this.lblProveedor.Text = "Proveedor Cuit";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(341, 23);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(21, 91);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(65, 13);
            this.lblVencimiento.TabIndex = 7;
            this.lblVencimiento.Text = "Vencimiento";
            // 
            // lblPublicacion
            // 
            this.lblPublicacion.AutoSize = true;
            this.lblPublicacion.Location = new System.Drawing.Point(24, 19);
            this.lblPublicacion.Name = "lblPublicacion";
            this.lblPublicacion.Size = new System.Drawing.Size(62, 13);
            this.lblPublicacion.TabIndex = 8;
            this.lblPublicacion.Text = "Publicación";
            // 
            // groupBoxFechas
            // 
            this.groupBoxFechas.Controls.Add(this.calendarioPublicacion);
            this.groupBoxFechas.Controls.Add(this.calendarioVencimiento);
            this.groupBoxFechas.Controls.Add(this.lblVencimiento);
            this.groupBoxFechas.Controls.Add(this.lblPublicacion);
            this.groupBoxFechas.Location = new System.Drawing.Point(344, 171);
            this.groupBoxFechas.Name = "groupBoxFechas";
            this.groupBoxFechas.Size = new System.Drawing.Size(386, 124);
            this.groupBoxFechas.TabIndex = 9;
            this.groupBoxFechas.TabStop = false;
            this.groupBoxFechas.Text = "Fechas";
            // 
            // calendarioPublicacion
            // 
            this.calendarioPublicacion.Location = new System.Drawing.Point(111, 19);
            this.calendarioPublicacion.Name = "calendarioPublicacion";
            this.calendarioPublicacion.Size = new System.Drawing.Size(259, 20);
            this.calendarioPublicacion.TabIndex = 8;
            // 
            // calendarioVencimiento
            // 
            this.calendarioVencimiento.Location = new System.Drawing.Point(111, 91);
            this.calendarioVencimiento.Name = "calendarioVencimiento";
            this.calendarioVencimiento.Size = new System.Drawing.Size(259, 20);
            this.calendarioVencimiento.TabIndex = 9;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(122, 23);
            this.txtStock.MaxLength = 5;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(175, 20);
            this.txtStock.TabIndex = 2;
            this.txtStock.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // txtLimiteCompra
            // 
            this.txtLimiteCompra.Location = new System.Drawing.Point(122, 82);
            this.txtLimiteCompra.MaxLength = 5;
            this.txtLimiteCompra.Name = "txtLimiteCompra";
            this.txtLimiteCompra.Size = new System.Drawing.Size(175, 20);
            this.txtLimiteCompra.TabIndex = 3;
            this.txtLimiteCompra.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // txtPrecioAntiguo
            // 
            this.txtPrecioAntiguo.Location = new System.Drawing.Point(122, 138);
            this.txtPrecioAntiguo.MaxLength = 18;
            this.txtPrecioAntiguo.Name = "txtPrecioAntiguo";
            this.txtPrecioAntiguo.Size = new System.Drawing.Size(175, 20);
            this.txtPrecioAntiguo.TabIndex = 4;
            this.txtPrecioAntiguo.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // txtPrecioNuevo
            // 
            this.txtPrecioNuevo.Location = new System.Drawing.Point(122, 207);
            this.txtPrecioNuevo.MaxLength = 18;
            this.txtPrecioNuevo.Name = "txtPrecioNuevo";
            this.txtPrecioNuevo.Size = new System.Drawing.Size(175, 20);
            this.txtPrecioNuevo.TabIndex = 5;
            this.txtPrecioNuevo.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // txtCuit
            // 
            this.txtCuit.Enabled = false;
            this.txtCuit.Location = new System.Drawing.Point(122, 272);
            this.txtCuit.MaxLength = 20;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(175, 20);
            this.txtCuit.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(424, 20);
            this.txtDescripcion.MaxLength = 255;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcion.Size = new System.Drawing.Size(302, 110);
            this.txtDescripcion.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCancelar.Location = new System.Drawing.Point(41, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 40);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnPublicar.Location = new System.Drawing.Point(410, 322);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(83, 41);
            this.btnPublicar.TabIndex = 12;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // validator
            // 
            this.validator.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnBuscar.Location = new System.Drawing.Point(189, 322);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 41);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar proveedor";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnLimpiar.Location = new System.Drawing.Point(631, 322);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 40);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(303, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(303, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(303, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(303, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(732, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "*";
            // 
            // AltaOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 374);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtPrecioNuevo);
            this.Controls.Add(this.txtPrecioAntiguo);
            this.Controls.Add(this.txtLimiteCompra);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.groupBoxFechas);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblPrecioNuevo);
            this.Controls.Add(this.lblprecioAntiguo);
            this.Controls.Add(this.lblLimiteCompra);
            this.Controls.Add(this.lblStock);
            this.Name = "AltaOferta";
            this.Text = "Publicar una Oferta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AltaOferta_FormClosed);
            this.Controls.SetChildIndex(this.lblStock, 0);
            this.Controls.SetChildIndex(this.lblLimiteCompra, 0);
            this.Controls.SetChildIndex(this.lblprecioAntiguo, 0);
            this.Controls.SetChildIndex(this.lblPrecioNuevo, 0);
            this.Controls.SetChildIndex(this.lblProveedor, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.groupBoxFechas, 0);
            this.Controls.SetChildIndex(this.txtStock, 0);
            this.Controls.SetChildIndex(this.txtLimiteCompra, 0);
            this.Controls.SetChildIndex(this.txtPrecioAntiguo, 0);
            this.Controls.SetChildIndex(this.txtPrecioNuevo, 0);
            this.Controls.SetChildIndex(this.txtCuit, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnPublicar, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.groupBoxFechas.ResumeLayout(false);
            this.groupBoxFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblLimiteCompra;
        private System.Windows.Forms.Label lblprecioAntiguo;
        private System.Windows.Forms.Label lblPrecioNuevo;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblPublicacion;
        private System.Windows.Forms.GroupBox groupBoxFechas;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtLimiteCompra;
        private System.Windows.Forms.TextBox txtPrecioAntiguo;
        private System.Windows.Forms.TextBox txtPrecioNuevo;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.ErrorProvider validator;
        private System.Windows.Forms.DateTimePicker calendarioPublicacion;
        private System.Windows.Forms.DateTimePicker calendarioVencimiento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}