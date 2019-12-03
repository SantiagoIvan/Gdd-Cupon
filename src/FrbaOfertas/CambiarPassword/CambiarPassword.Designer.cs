namespace FrbaOfertas.CambiarPassword
{
    partial class CambiarPassword
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
            this.lblNewP = new System.Windows.Forms.Label();
            this.lblConfirmNewP = new System.Windows.Forms.Label();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.txtConfirmNuevaContraseña = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewP
            // 
            this.lblNewP.AutoSize = true;
            this.lblNewP.Location = new System.Drawing.Point(28, 34);
            this.lblNewP.Name = "lblNewP";
            this.lblNewP.Size = new System.Drawing.Size(96, 13);
            this.lblNewP.TabIndex = 1;
            this.lblNewP.Text = "Nueva Contraseña";
            // 
            // lblConfirmNewP
            // 
            this.lblConfirmNewP.AutoSize = true;
            this.lblConfirmNewP.Location = new System.Drawing.Point(28, 81);
            this.lblConfirmNewP.Name = "lblConfirmNewP";
            this.lblConfirmNewP.Size = new System.Drawing.Size(140, 13);
            this.lblConfirmNewP.TabIndex = 2;
            this.lblConfirmNewP.Text = "Confirmar nueva contraseña";
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(179, 34);
            this.txtNuevaContraseña.MaxLength = 255;
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.PasswordChar = '*';
            this.txtNuevaContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaContraseña.TabIndex = 4;
            // 
            // txtConfirmNuevaContraseña
            // 
            this.txtConfirmNuevaContraseña.Location = new System.Drawing.Point(179, 78);
            this.txtConfirmNuevaContraseña.MaxLength = 255;
            this.txtConfirmNuevaContraseña.Name = "txtConfirmNuevaContraseña";
            this.txtConfirmNuevaContraseña.PasswordChar = '*';
            this.txtConfirmNuevaContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmNuevaContraseña.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(116, 126);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // CambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 171);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtConfirmNuevaContraseña);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.lblConfirmNewP);
            this.Controls.Add(this.lblNewP);
            this.Name = "CambiarPassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarContraseña";
            this.TopMost = true;
            this.Controls.SetChildIndex(this.lblNewP, 0);
            this.Controls.SetChildIndex(this.lblConfirmNewP, 0);
            this.Controls.SetChildIndex(this.txtNuevaContraseña, 0);
            this.Controls.SetChildIndex(this.txtConfirmNuevaContraseña, 0);
            this.Controls.SetChildIndex(this.btnConfirmar, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewP;
        private System.Windows.Forms.Label lblConfirmNewP;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.TextBox txtConfirmNuevaContraseña;
        private System.Windows.Forms.Button btnConfirmar;
    }
}