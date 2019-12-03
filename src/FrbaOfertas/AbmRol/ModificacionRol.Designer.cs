namespace FrbaOfertas.AbmRol
{
    partial class ModificacionRol
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
            this.clbFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblRolNombre = new System.Windows.Forms.Label();
            this.lblFuncionalidades = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificarRol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbFuncionalidades);
            this.groupBox1.Controls.Add(this.btnDeshabilitar);
            this.groupBox1.Controls.Add(this.btnHabilitar);
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.cmbRoles);
            this.groupBox1.Controls.Add(this.lblRolNombre);
            this.groupBox1.Controls.Add(this.lblFuncionalidades);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 286);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese nombre del rol";
            // 
            // clbFuncionalidades
            // 
            this.clbFuncionalidades.CheckOnClick = true;
            this.clbFuncionalidades.FormattingEnabled = true;
            this.clbFuncionalidades.Location = new System.Drawing.Point(60, 106);
            this.clbFuncionalidades.Name = "clbFuncionalidades";
            this.clbFuncionalidades.Size = new System.Drawing.Size(359, 154);
            this.clbFuncionalidades.TabIndex = 14;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeshabilitar.Enabled = false;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitar.Location = new System.Drawing.Point(268, 54);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnDeshabilitar.TabIndex = 12;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHabilitar.Enabled = false;
            this.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitar.Location = new System.Drawing.Point(177, 54);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnHabilitar.TabIndex = 13;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = false;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(379, 27);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 12;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // cmbRoles
            // 
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(177, 27);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(166, 21);
            this.cmbRoles.TabIndex = 10;
            // 
            // lblRolNombre
            // 
            this.lblRolNombre.AutoSize = true;
            this.lblRolNombre.Location = new System.Drawing.Point(20, 35);
            this.lblRolNombre.Name = "lblRolNombre";
            this.lblRolNombre.Size = new System.Drawing.Size(80, 13);
            this.lblRolNombre.TabIndex = 0;
            this.lblRolNombre.Text = "Nombre del Rol";
            // 
            // lblFuncionalidades
            // 
            this.lblFuncionalidades.AutoSize = true;
            this.lblFuncionalidades.Location = new System.Drawing.Point(20, 72);
            this.lblFuncionalidades.Name = "lblFuncionalidades";
            this.lblFuncionalidades.Size = new System.Drawing.Size(143, 13);
            this.lblFuncionalidades.TabIndex = 1;
            this.lblFuncionalidades.Text = "Seleccionar Funcionalidades";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCancelar.Location = new System.Drawing.Point(35, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 39);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificarRol
            // 
            this.btnModificarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnModificarRol.Location = new System.Drawing.Point(389, 304);
            this.btnModificarRol.Name = "btnModificarRol";
            this.btnModificarRol.Size = new System.Drawing.Size(95, 39);
            this.btnModificarRol.TabIndex = 10;
            this.btnModificarRol.Text = "Modificar";
            this.btnModificarRol.UseVisualStyleBackColor = true;
            this.btnModificarRol.Click += new System.EventHandler(this.btnModificarRol_Click);
            // 
            // ModificacionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificarRol);
            this.Name = "ModificacionRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion de Rol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModificacionRol_FormClosed);
            this.Load += new System.EventHandler(this.ModificacionRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRolNombre;
        private System.Windows.Forms.Label lblFuncionalidades;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificarRol;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.CheckedListBox clbFuncionalidades;

    }
}