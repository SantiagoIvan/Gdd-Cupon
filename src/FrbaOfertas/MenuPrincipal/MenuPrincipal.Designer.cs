namespace FrbaOfertas.MenuPrincipal
{
    partial class MenuPrincipal
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
            this.lblUsuarioLog = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.cmbFuncionalidades = new System.Windows.Forms.ComboBox();
            this.lblFuncionalidades = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuarioLog
            // 
            this.lblUsuarioLog.AutoSize = true;
            this.lblUsuarioLog.Location = new System.Drawing.Point(12, 23);
            this.lblUsuarioLog.Name = "lblUsuarioLog";
            this.lblUsuarioLog.Size = new System.Drawing.Size(90, 13);
            this.lblUsuarioLog.TabIndex = 0;
            this.lblUsuarioLog.Text = "Usuario logueado";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(13, 51);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol";
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Location = new System.Drawing.Point(96, 118);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(116, 23);
            this.btnCambiarContraseña.TabIndex = 5;
            this.btnCambiarContraseña.Text = "Cambiar Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // cmbFuncionalidades
            // 
            this.cmbFuncionalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionalidades.FormattingEnabled = true;
            this.cmbFuncionalidades.Location = new System.Drawing.Point(142, 82);
            this.cmbFuncionalidades.Name = "cmbFuncionalidades";
            this.cmbFuncionalidades.Size = new System.Drawing.Size(148, 21);
            this.cmbFuncionalidades.TabIndex = 6;
            // 
            // lblFuncionalidades
            // 
            this.lblFuncionalidades.AutoSize = true;
            this.lblFuncionalidades.Location = new System.Drawing.Point(13, 85);
            this.lblFuncionalidades.Name = "lblFuncionalidades";
            this.lblFuncionalidades.Size = new System.Drawing.Size(84, 13);
            this.lblFuncionalidades.TabIndex = 7;
            this.lblFuncionalidades.Text = "Funcionalidades";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(218, 118);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 8;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(15, 118);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(36, 85);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 10;
            // 
            // lblR
            // 
            this.lblR.BackColor = System.Drawing.SystemColors.Window;
            this.lblR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblR.Location = new System.Drawing.Point(142, 51);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(148, 20);
            this.lblR.TabIndex = 11;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuario.Location = new System.Drawing.Point(142, 23);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(148, 20);
            this.lblUsuario.TabIndex = 12;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 151);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblFuncionalidades);
            this.Controls.Add(this.cmbFuncionalidades);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblUsuarioLog);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioLog;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.ComboBox cmbFuncionalidades;
        private System.Windows.Forms.Label lblFuncionalidades;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblUsuario;
    }
}