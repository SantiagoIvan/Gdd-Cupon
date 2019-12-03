namespace FrbaOfertas.AbmProveedor
{
    partial class ModificarProveedor
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
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeshabilitar.Enabled = false;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitar.Location = new System.Drawing.Point(33, 92);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnDeshabilitar.TabIndex = 13;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHabilitar.Enabled = false;
            this.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitar.Location = new System.Drawing.Point(114, 92);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnHabilitar.TabIndex = 12;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = false;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // txtCuit
            // 
            this.txtCuit.Enabled = false;
            this.txtCuit.Location = new System.Drawing.Point(135, 37);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.ReadOnly = true;
            this.txtCuit.Size = new System.Drawing.Size(221, 20);
            this.txtCuit.TabIndex = 11;
            this.txtCuit.TextChanged += new System.EventHandler(this.txtCuit_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(287, 92);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(195, 92);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar perfil";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(36, 37);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(93, 13);
            this.lblProveedor.TabIndex = 8;
            this.lblProveedor.Text = "Cuit del proveedor";
            // 
            // ModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 155);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblProveedor);
            this.Name = "ModificarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarProveedor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModificarProveedor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblProveedor;

    }
}