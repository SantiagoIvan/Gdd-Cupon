namespace FrbaOfertas.AbmCliente
{
    partial class AltaCliente
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblDepto = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(184, 358);
            this.btnAtras.Size = new System.Drawing.Size(104, 44);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(494, 65);
            this.txtTelefono.MaxLength = 18;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 23);
            this.txtNombre.MaxLength = 255;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(97, 62);
            this.txtApellido.MaxLength = 255;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(493, 33);
            this.txtCp.MaxLength = 20;
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(200, 20);
            this.txtCp.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(96, 30);
            this.txtDireccion.MaxLength = 255;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(494, 26);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(97, 102);
            this.txtDni.MaxLength = 18;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(200, 20);
            this.txtDni.TabIndex = 3;
            this.txtDni.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(32, 65);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(32, 108);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 11;
            this.lblDni.Text = "Dni:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(370, 108);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNacimiento.TabIndex = 12;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(370, 65);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(370, 26);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(38, 13);
            this.lblMail.TabIndex = 14;
            this.lblMail.Text = "E-mail:";
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(366, 36);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(75, 13);
            this.lblCp.TabIndex = 15;
            this.lblCp.Text = "Codigo Postal:";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(31, 69);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 17;
            this.lblPiso.Text = "Piso:";
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(31, 103);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(39, 13);
            this.lblDepto.TabIndex = 18;
            this.lblDepto.Text = "Depto:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(31, 30);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(52, 13);
            this.lblCalle.TabIndex = 19;
            this.lblCalle.Text = "Direccion";
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(96, 66);
            this.txtPiso.MaxLength = 4;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(200, 20);
            this.txtPiso.TabIndex = 8;
            this.txtPiso.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(96, 103);
            this.txtDepto.MaxLength = 1;
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(200, 20);
            this.txtDepto.TabIndex = 9;
            this.txtDepto.TextChanged += new System.EventHandler(this.ControlChanged);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(493, 75);
            this.txtCiudad.MaxLength = 255;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(200, 20);
            this.txtCiudad.TabIndex = 11;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(366, 82);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(40, 13);
            this.lblLocalidad.TabIndex = 23;
            this.lblLocalidad.Text = "Ciudad";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Black;
            this.btnCrear.Location = new System.Drawing.Point(385, 357);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(111, 45);
            this.btnCrear.TabIndex = 13;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fechaNacimiento);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.lblDni);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblFechaNacimiento);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 149);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales del Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(700, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(700, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(700, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(303, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(303, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(303, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "*";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(494, 108);
            this.fechaNacimiento.MaxDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.fechaNacimiento.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimiento.TabIndex = 6;
            this.fechaNacimiento.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.lblPiso);
            this.groupBox2.Controls.Add(this.lblDepto);
            this.groupBox2.Controls.Add(this.lblCalle);
            this.groupBox2.Controls.Add(this.lblLocalidad);
            this.groupBox2.Controls.Add(this.txtPiso);
            this.groupBox2.Controls.Add(this.txtCiudad);
            this.groupBox2.Controls.Add(this.lblCp);
            this.groupBox2.Controls.Add(this.txtDepto);
            this.groupBox2.Controls.Add(this.txtCp);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 148);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dirección";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(700, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(699, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(302, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "*";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(571, 357);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 45);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 414);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCrear);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro del cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AltaCliente_FormClosed);
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

        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TextBox txtTelefono;
        protected System.Windows.Forms.TextBox txtNombre;
        protected System.Windows.Forms.TextBox txtApellido;
        protected System.Windows.Forms.TextBox txtCp;
        protected System.Windows.Forms.TextBox txtDireccion;
        protected System.Windows.Forms.TextBox txtEmail;
        protected System.Windows.Forms.TextBox txtDni;
        protected System.Windows.Forms.Label lblNombre;
        protected System.Windows.Forms.Label lblApellido;
        protected System.Windows.Forms.Label lblDni;
        protected System.Windows.Forms.Label lblFechaNacimiento;
        protected System.Windows.Forms.Label lblTelefono;
        protected System.Windows.Forms.Label lblMail;
        protected System.Windows.Forms.Label lblCp;
        protected System.Windows.Forms.Label lblPiso;
        protected System.Windows.Forms.Label lblDepto;
        protected System.Windows.Forms.Label lblCalle;
        protected System.Windows.Forms.TextBox txtPiso;
        protected System.Windows.Forms.TextBox txtDepto;
        protected System.Windows.Forms.TextBox txtCiudad;
        protected System.Windows.Forms.Label lblLocalidad;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.DateTimePicker fechaNacimiento;
        protected System.Windows.Forms.Button btnLimpiar;
        protected System.Windows.Forms.Button btnCrear;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label7;
    }
}