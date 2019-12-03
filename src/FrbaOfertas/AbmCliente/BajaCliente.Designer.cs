namespace FrbaOfertas.AbmCliente
{
    partial class BajaCliente
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 36);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Dni del cliente";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(87, 33);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(295, 20);
            this.txtDni.TabIndex = 1;
            this.txtDni.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(307, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBaja.Enabled = false;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBaja.Location = new System.Drawing.Point(176, 75);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "Dar de baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(45, 75);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 138);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblUsuario);
            this.Name = "BajaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dar  de baja Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BajaCliente_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnCancelar;
    }
}