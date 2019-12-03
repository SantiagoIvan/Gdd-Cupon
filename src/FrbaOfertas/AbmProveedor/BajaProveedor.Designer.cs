namespace FrbaOfertas.AbmProveedor
{
    partial class BajaProveedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtCuit);
            this.groupBox1.Controls.Add(this.lblIdProveedor);
            this.groupBox1.Controls.Add(this.btnDarBaja);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 125);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar un Proveedor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(314, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCuit
            // 
            this.txtCuit.Enabled = false;
            this.txtCuit.Location = new System.Drawing.Point(92, 32);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.ReadOnly = true;
            this.txtCuit.Size = new System.Drawing.Size(266, 20);
            this.txtCuit.TabIndex = 0;
            this.txtCuit.TextChanged += new System.EventHandler(this.txtCuit_TextChanged);
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Location = new System.Drawing.Point(35, 35);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(25, 13);
            this.lblIdProveedor.TabIndex = 0;
            this.lblIdProveedor.Text = "Cuit";
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDarBaja.Enabled = false;
            this.btnDarBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnDarBaja.Location = new System.Drawing.Point(154, 71);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(115, 26);
            this.btnDarBaja.TabIndex = 5;
            this.btnDarBaja.Text = "Dar de Baja";
            this.btnDarBaja.UseVisualStyleBackColor = false;
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCancelar.Location = new System.Drawing.Point(22, 71);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 26);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BajaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 145);
            this.Controls.Add(this.groupBox1);
            this.Name = "BajaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dar de baja Proveedor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BajaProveedor_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblIdProveedor;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
    }
}