namespace FrbaOfertas.Listado
{
    partial class ListadoDeCupones
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cupon_id = new System.Windows.Forms.TextBox();
            this.oferta_id = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblFiltroEmail = new System.Windows.Forms.Label();
            this.lblFiltroCuponId = new System.Windows.Forms.Label();
            this.dgCupones = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cliente_comprador_dni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCupones)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "(Texto libre)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "(Texto exacto)";
            // 
            // cupon_id
            // 
            this.cupon_id.Location = new System.Drawing.Point(147, 16);
            this.cupon_id.MaxLength = 10;
            this.cupon_id.Name = "cupon_id";
            this.cupon_id.Size = new System.Drawing.Size(200, 20);
            this.cupon_id.TabIndex = 1;
            this.cupon_id.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // oferta_id
            // 
            this.oferta_id.Location = new System.Drawing.Point(147, 113);
            this.oferta_id.MaxLength = 20;
            this.oferta_id.Name = "oferta_id";
            this.oferta_id.Size = new System.Drawing.Size(200, 20);
            this.oferta_id.TabIndex = 2;
            this.oferta_id.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(256, 152);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(175, 23);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(52, 152);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(143, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(744, 152);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(165, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblFiltroEmail
            // 
            this.lblFiltroEmail.AutoSize = true;
            this.lblFiltroEmail.Location = new System.Drawing.Point(28, 116);
            this.lblFiltroEmail.Name = "lblFiltroEmail";
            this.lblFiltroEmail.Size = new System.Drawing.Size(50, 13);
            this.lblFiltroEmail.TabIndex = 28;
            this.lblFiltroEmail.Text = "Oferta_id";
            // 
            // lblFiltroCuponId
            // 
            this.lblFiltroCuponId.AutoSize = true;
            this.lblFiltroCuponId.Location = new System.Drawing.Point(28, 19);
            this.lblFiltroCuponId.Name = "lblFiltroCuponId";
            this.lblFiltroCuponId.Size = new System.Drawing.Size(88, 13);
            this.lblFiltroCuponId.TabIndex = 26;
            this.lblFiltroCuponId.Text = "Codigo de cupon";
            // 
            // dgCupones
            // 
            this.dgCupones.AllowUserToAddRows = false;
            this.dgCupones.AllowUserToDeleteRows = false;
            this.dgCupones.AllowUserToOrderColumns = true;
            this.dgCupones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCupones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCupones.Location = new System.Drawing.Point(30, 181);
            this.dgCupones.MultiSelect = false;
            this.dgCupones.Name = "dgCupones";
            this.dgCupones.ReadOnly = true;
            this.dgCupones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCupones.Size = new System.Drawing.Size(906, 150);
            this.dgCupones.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Cliente comprador DNI";
            // 
            // cliente_comprador_dni
            // 
            this.cliente_comprador_dni.Location = new System.Drawing.Point(147, 63);
            this.cliente_comprador_dni.MaxLength = 18;
            this.cliente_comprador_dni.Name = "cliente_comprador_dni";
            this.cliente_comprador_dni.Size = new System.Drawing.Size(200, 20);
            this.cliente_comprador_dni.TabIndex = 3;
            this.cliente_comprador_dni.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "(Texto exacto)";
            // 
            // ListadoDeCupones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 354);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cliente_comprador_dni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cupon_id);
            this.Controls.Add(this.oferta_id);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblFiltroEmail);
            this.Controls.Add(this.lblFiltroCuponId);
            this.Controls.Add(this.dgCupones);
            this.Name = "ListadoDeCupones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Cupones";
            this.Load += new System.EventHandler(this.ListadoDeCupones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCupones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cupon_id;
        private System.Windows.Forms.TextBox oferta_id;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblFiltroEmail;
        private System.Windows.Forms.Label lblFiltroCuponId;
        private System.Windows.Forms.DataGridView dgCupones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cliente_comprador_dni;
        private System.Windows.Forms.Label label5;
    }
}