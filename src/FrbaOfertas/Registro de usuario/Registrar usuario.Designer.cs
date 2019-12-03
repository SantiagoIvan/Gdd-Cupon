namespace FrbaOfertas.Registro_de_usuario
{
    partial class RegistrarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAtras.Location = new System.Drawing.Point(36, 141);
            this.btnAtras.Size = new System.Drawing.Size(100, 37);
            this.btnAtras.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(23, 28);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(99, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Nombre de usuario:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(148, 62);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(148, 25);
            this.txtUsuario.MaxLength = 255;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(148, 99);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 21);
            this.cmbRol.TabIndex = 3;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSeleccionar.Location = new System.Drawing.Point(159, 141);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(100, 37);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 192);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrarUsuario_FormClosed);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.cmbRol, 0);
            this.Controls.SetChildIndex(this.btnSeleccionar, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}