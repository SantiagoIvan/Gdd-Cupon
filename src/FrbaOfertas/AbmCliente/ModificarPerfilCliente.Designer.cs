namespace FrbaOfertas.AbmCliente
{
    partial class ModificarPerfilCliente
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.ReadOnly = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(554, 448);
            this.btnCrear.Size = new System.Drawing.Size(128, 45);
            this.btnCrear.Text = "Actualizar";
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnActualizar.Location = new System.Drawing.Point(357, 357);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(134, 45);
            this.btnActualizar.TabIndex = 28;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ModificarPerfilCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 407);
            this.Controls.Add(this.btnActualizar);
            this.Name = "ModificarPerfilCliente";
            this.Text = "Modificar Perfil";
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.btnCrear, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;

    }
}