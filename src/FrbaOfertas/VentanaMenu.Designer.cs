namespace FrbaOfertas
{
    partial class VentanaMenu
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
            this.btnAdmCupones = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAbmRol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdmCupones
            // 
            this.btnAdmCupones.Location = new System.Drawing.Point(26, 88);
            this.btnAdmCupones.Name = "btnAdmCupones";
            this.btnAdmCupones.Size = new System.Drawing.Size(190, 23);
            this.btnAdmCupones.TabIndex = 0;
            this.btnAdmCupones.Text = "Administrar Cupones";
            this.btnAdmCupones.UseVisualStyleBackColor = true;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(130, 59);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(86, 23);
            this.btnEstadisticas.TabIndex = 1;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(26, 59);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAbmRol
            // 
            this.btnAbmRol.Location = new System.Drawing.Point(27, 117);
            this.btnAbmRol.Name = "btnAbmRol";
            this.btnAbmRol.Size = new System.Drawing.Size(89, 23);
            this.btnAbmRol.TabIndex = 3;
            this.btnAbmRol.Text = "Gestionar Rol";
            this.btnAbmRol.UseVisualStyleBackColor = true;
            // 
            // VentanaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAbmRol);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnAdmCupones);
            this.Name = "VentanaMenu";
            this.Text = "VentanaMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmCupones;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAbmRol;
    }
}