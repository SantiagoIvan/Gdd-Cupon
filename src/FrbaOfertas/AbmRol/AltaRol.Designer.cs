namespace FrbaOfertas.AbmRol
{
    partial class AltaRol
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
            this.lblRolNombre = new System.Windows.Forms.Label();
            this.lblFuncionalidades = new System.Windows.Forms.Label();
            this.txtRolNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgFuncionalidadesDisponibles = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionalidadesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 394);
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
            this.lblFuncionalidades.Location = new System.Drawing.Point(20, 66);
            this.lblFuncionalidades.Name = "lblFuncionalidades";
            this.lblFuncionalidades.Size = new System.Drawing.Size(143, 13);
            this.lblFuncionalidades.TabIndex = 1;
            this.lblFuncionalidades.Text = "Seleccionar Funcionalidades";
            // 
            // txtRolNombre
            // 
            this.txtRolNombre.Location = new System.Drawing.Point(177, 28);
            this.txtRolNombre.MaxLength = 100;
            this.txtRolNombre.Name = "txtRolNombre";
            this.txtRolNombre.Size = new System.Drawing.Size(120, 20);
            this.txtRolNombre.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCancelar.Location = new System.Drawing.Point(50, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 39);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCrear.Location = new System.Drawing.Point(266, 283);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(95, 39);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear Rol";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgFuncionalidadesDisponibles);
            this.groupBox1.Controls.Add(this.txtRolNombre);
            this.groupBox1.Controls.Add(this.lblRolNombre);
            this.groupBox1.Controls.Add(this.lblFuncionalidades);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 265);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese un Nuevo Rol";
            // 
            // dgFuncionalidadesDisponibles
            // 
            this.dgFuncionalidadesDisponibles.AllowUserToAddRows = false;
            this.dgFuncionalidadesDisponibles.AllowUserToDeleteRows = false;
            this.dgFuncionalidadesDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFuncionalidadesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncionalidadesDisponibles.Location = new System.Drawing.Point(6, 93);
            this.dgFuncionalidadesDisponibles.Name = "dgFuncionalidadesDisponibles";
            this.dgFuncionalidadesDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFuncionalidadesDisponibles.Size = new System.Drawing.Size(385, 162);
            this.dgFuncionalidadesDisponibles.TabIndex = 6;
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Name = "AltaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaRol";
            this.Controls.SetChildIndex(this.btnCrear, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionalidadesDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRolNombre;
        private System.Windows.Forms.Label lblFuncionalidades;
        private System.Windows.Forms.TextBox txtRolNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgFuncionalidadesDisponibles;
    }
}