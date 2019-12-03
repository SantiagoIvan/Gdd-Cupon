namespace FrbaOfertas
{
    partial class VentanaPrincipal
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSesionUsuario = new System.Windows.Forms.Button();
            this.btnSesionCliente = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(94, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(49, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Usuario: ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(94, 70);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(67, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Contraseña: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inicio de sesion con Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inicio de sesion para Clientes";
            // 
            // btnSesionUsuario
            // 
            this.btnSesionUsuario.Location = new System.Drawing.Point(189, 109);
            this.btnSesionUsuario.Name = "btnSesionUsuario";
            this.btnSesionUsuario.Size = new System.Drawing.Size(145, 23);
            this.btnSesionUsuario.TabIndex = 4;
            this.btnSesionUsuario.Text = "Iniciar Sesion";
            this.btnSesionUsuario.UseVisualStyleBackColor = true;
            this.btnSesionUsuario.Click += new System.EventHandler(this.btnSesionUsuario_Click);
            // 
            // btnSesionCliente
            // 
            this.btnSesionCliente.Location = new System.Drawing.Point(189, 156);
            this.btnSesionCliente.Name = "btnSesionCliente";
            this.btnSesionCliente.Size = new System.Drawing.Size(146, 23);
            this.btnSesionCliente.TabIndex = 5;
            this.btnSesionCliente.Text = "Iniciar sesion Cliente";
            this.btnSesionCliente.UseVisualStyleBackColor = true;
            this.btnSesionCliente.Click += new System.EventHandler(this.btnSesionCliente_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(163, 31);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(145, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(163, 67);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(145, 20);
            this.txtContraseña.TabIndex = 7;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 323);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnSesionCliente);
            this.Controls.Add(this.btnSesionUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "VentanaPrincipal";
            this.Text = "Inicio de Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSesionUsuario;
        private System.Windows.Forms.Button btnSesionCliente;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
    }
}