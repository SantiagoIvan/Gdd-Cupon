namespace FrbaOfertas.Listado
{
    partial class ListadoDeProveedores
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
            this.dgProveedores = new System.Windows.Forms.DataGridView();
            this.lblFiltroCuit = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.rs = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.cuit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProveedores
            // 
            this.dgProveedores.AllowUserToAddRows = false;
            this.dgProveedores.AllowUserToDeleteRows = false;
            this.dgProveedores.AllowUserToOrderColumns = true;
            this.dgProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProveedores.Location = new System.Drawing.Point(27, 177);
            this.dgProveedores.MultiSelect = false;
            this.dgProveedores.Name = "dgProveedores";
            this.dgProveedores.ReadOnly = true;
            this.dgProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProveedores.Size = new System.Drawing.Size(906, 150);
            this.dgProveedores.TabIndex = 0;
            // 
            // lblFiltroCuit
            // 
            this.lblFiltroCuit.AutoSize = true;
            this.lblFiltroCuit.Location = new System.Drawing.Point(24, 28);
            this.lblFiltroCuit.Name = "lblFiltroCuit";
            this.lblFiltroCuit.Size = new System.Drawing.Size(25, 13);
            this.lblFiltroCuit.TabIndex = 1;
            this.lblFiltroCuit.Text = "Cuit";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Razon Social";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(745, 148);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(165, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(49, 148);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(143, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(240, 148);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(175, 23);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // rs
            // 
            this.rs.Location = new System.Drawing.Point(160, 64);
            this.rs.MaxLength = 100;
            this.rs.Name = "rs";
            this.rs.Size = new System.Drawing.Size(162, 20);
            this.rs.TabIndex = 2;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(160, 108);
            this.email.MaxLength = 255;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(162, 20);
            this.email.TabIndex = 3;
            // 
            // cuit
            // 
            this.cuit.Location = new System.Drawing.Point(160, 28);
            this.cuit.MaxLength = 20;
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(162, 20);
            this.cuit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "(Texto libre)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "(Texto exacto)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "(Texto libre)";
            // 
            // ListadoDeProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 346);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cuit);
            this.Controls.Add(this.email);
            this.Controls.Add(this.rs);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFiltroCuit);
            this.Controls.Add(this.dgProveedores);
            this.Name = "ListadoDeProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Proveedores";
            this.Load += new System.EventHandler(this.ListadoDeProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProveedores;
        private System.Windows.Forms.Label lblFiltroCuit;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox rs;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox cuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}