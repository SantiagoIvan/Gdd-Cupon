namespace FrbaOfertas.Listado
{
    partial class ListadoCliente
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.cliente_apellido = new System.Windows.Forms.TextBox();
            this.cliente_nombre = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(183, 102);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(100, 23);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(34, 102);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(792, 102);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.AllowUserToOrderColumns = true;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(34, 150);
            this.dgClientes.MultiSelect = false;
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(858, 150);
            this.dgClientes.TabIndex = 7;
            // 
            // cliente_apellido
            // 
            this.cliente_apellido.Location = new System.Drawing.Point(624, 25);
            this.cliente_apellido.MaxLength = 255;
            this.cliente_apellido.Name = "cliente_apellido";
            this.cliente_apellido.Size = new System.Drawing.Size(190, 20);
            this.cliente_apellido.TabIndex = 3;
            // 
            // cliente_nombre
            // 
            this.cliente_nombre.Location = new System.Drawing.Point(136, 24);
            this.cliente_nombre.MaxLength = 255;
            this.cliente_nombre.Name = "cliente_nombre";
            this.cliente_nombre.Size = new System.Drawing.Size(190, 20);
            this.cliente_nombre.TabIndex = 1;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(624, 66);
            this.email.MaxLength = 255;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(190, 20);
            this.email.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(547, 31);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(547, 73);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(73, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(73, 66);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 17;
            this.lblDni.Text = "Dni";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(136, 63);
            this.dni.MaxLength = 18;
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(190, 20);
            this.dni.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "(Texto exacto)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "(Texto libre)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(820, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "(Texto libre)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(824, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "(Texto libre)";
            // 
            // ListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 315);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.cliente_apellido);
            this.Controls.Add(this.cliente_nombre);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgClientes);
            this.Name = "ListadoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.ListadoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.TextBox cliente_apellido;
        private System.Windows.Forms.TextBox cliente_nombre;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}