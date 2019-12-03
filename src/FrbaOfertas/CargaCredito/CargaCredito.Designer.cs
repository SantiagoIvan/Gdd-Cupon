namespace FrbaOfertas.CragaCredito
{
    partial class CargaCredito
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTarjetaTitular = new System.Windows.Forms.TextBox();
            this.txtTarjeta_id = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTipoTarjeta = new System.Windows.Forms.Label();
            this.lblFechaVto = new System.Windows.Forms.Label();
            this.lblTarjetaId = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.cmbTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.fecha_vto = new System.Windows.Forms.DateTimePicker();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(34, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(220, 277);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(129, 57);
            this.txtMonto.MaxLength = 18;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(200, 20);
            this.txtMonto.TabIndex = 2;
            this.txtMonto.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // txtTarjetaTitular
            // 
            this.txtTarjetaTitular.Location = new System.Drawing.Point(129, 175);
            this.txtTarjetaTitular.MaxLength = 255;
            this.txtTarjetaTitular.Name = "txtTarjetaTitular";
            this.txtTarjetaTitular.Size = new System.Drawing.Size(200, 20);
            this.txtTarjetaTitular.TabIndex = 5;
            // 
            // txtTarjeta_id
            // 
            this.txtTarjeta_id.Location = new System.Drawing.Point(129, 133);
            this.txtTarjeta_id.MaxLength = 18;
            this.txtTarjeta_id.Name = "txtTarjeta_id";
            this.txtTarjeta_id.Size = new System.Drawing.Size(200, 20);
            this.txtTarjeta_id.TabIndex = 4;
            this.txtTarjeta_id.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(24, 60);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 10;
            this.lblMonto.Text = "Monto";
            // 
            // lblTipoTarjeta
            // 
            this.lblTipoTarjeta.AutoSize = true;
            this.lblTipoTarjeta.Location = new System.Drawing.Point(24, 93);
            this.lblTipoTarjeta.Name = "lblTipoTarjeta";
            this.lblTipoTarjeta.Size = new System.Drawing.Size(75, 13);
            this.lblTipoTarjeta.TabIndex = 11;
            this.lblTipoTarjeta.Text = "Tipo de tarjeta";
            // 
            // lblFechaVto
            // 
            this.lblFechaVto.AutoSize = true;
            this.lblFechaVto.Location = new System.Drawing.Point(25, 220);
            this.lblFechaVto.Name = "lblFechaVto";
            this.lblFechaVto.Size = new System.Drawing.Size(74, 13);
            this.lblFechaVto.TabIndex = 12;
            this.lblFechaVto.Text = "Fecha de Vto.";
            // 
            // lblTarjetaId
            // 
            this.lblTarjetaId.AutoSize = true;
            this.lblTarjetaId.Location = new System.Drawing.Point(24, 136);
            this.lblTarjetaId.Name = "lblTarjetaId";
            this.lblTarjetaId.Size = new System.Drawing.Size(91, 13);
            this.lblTarjetaId.TabIndex = 15;
            this.lblTarjetaId.Text = "Numero de tarjeta";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(25, 175);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 16;
            this.lblTitular.Text = "Titular";
            // 
            // cmbTipoTarjeta
            // 
            this.cmbTipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTarjeta.FormattingEnabled = true;
            this.cmbTipoTarjeta.Location = new System.Drawing.Point(129, 93);
            this.cmbTipoTarjeta.Name = "cmbTipoTarjeta";
            this.cmbTipoTarjeta.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoTarjeta.TabIndex = 3;
            // 
            // fecha_vto
            // 
            this.fecha_vto.Location = new System.Drawing.Point(129, 220);
            this.fecha_vto.Name = "fecha_vto";
            this.fecha_vto.Size = new System.Drawing.Size(200, 20);
            this.fecha_vto.TabIndex = 6;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(129, 20);
            this.txtCliente.MaxLength = 18;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(119, 20);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(26, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 13);
            this.lblCliente.TabIndex = 21;
            this.lblCliente.Text = "Cliente DNI";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(254, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CargaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 324);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.fecha_vto);
            this.Controls.Add(this.cmbTipoTarjeta);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.lblTarjetaId);
            this.Controls.Add(this.lblFechaVto);
            this.Controls.Add(this.lblTipoTarjeta);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtTarjeta_id);
            this.Controls.Add(this.txtTarjetaTitular);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "CargaCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de credito";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CargaCredito_FormClosed);
            this.Load += new System.EventHandler(this.CargaCredito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTarjetaTitular;
        private System.Windows.Forms.TextBox txtTarjeta_id;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTipoTarjeta;
        private System.Windows.Forms.Label lblFechaVto;
        private System.Windows.Forms.Label lblTarjetaId;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.ComboBox cmbTipoTarjeta;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker fecha_vto;
    }
}