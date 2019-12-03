namespace FrbaOfertas.LoginYSeguridad
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.txtUsserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gD2C2019DataSet = new FrbaOfertas.GD2C2019DataSet();
            this.gD2C2019DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsserName
            // 
            this.txtUsserName.Location = new System.Drawing.Point(118, 74);
            this.txtUsserName.MaxLength = 255;
            this.txtUsserName.Name = "txtUsserName";
            this.txtUsserName.Size = new System.Drawing.Size(100, 20);
            this.txtUsserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(118, 110);
            this.txtPassword.MaxLength = 255;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblUsserName
            // 
            this.lblUsserName.AutoSize = true;
            this.lblUsserName.Location = new System.Drawing.Point(6, 77);
            this.lblUsserName.Name = "lblUsserName";
            this.lblUsserName.Size = new System.Drawing.Size(96, 13);
            this.lblUsserName.TabIndex = 2;
            this.lblUsserName.Text = "Nombre de usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.Firebrick;
            this.lblBienvenido.Location = new System.Drawing.Point(44, 25);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(145, 33);
            this.lblBienvenido.TabIndex = 4;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnIngresar.Location = new System.Drawing.Point(50, 154);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(102, 36);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // gD2C2019DataSet
            // 
            this.gD2C2019DataSet.DataSetName = "GD2C2019DataSet";
            this.gD2C2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gD2C2019DataSetBindingSource
            // 
            this.gD2C2019DataSetBindingSource.DataSource = this.gD2C2019DataSet;
            this.gD2C2019DataSetBindingSource.Position = 0;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnRegistrarse.Location = new System.Drawing.Point(99, 154);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(102, 36);
            this.btnRegistrarse.TabIndex = 6;
            this.btnRegistrarse.Text = "Registrarse!";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBienvenido);
            this.groupBox1.Controls.Add(this.txtUsserName);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.lblUsserName);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Location = new System.Drawing.Point(15, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 205);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio de Sesión";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnRegistrarse);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(277, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 205);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.label2.Location = new System.Drawing.Point(84, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Registrate! ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "¿No tenés cuenta?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 249);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2019DataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.BindingSource gD2C2019DataSetBindingSource;
        private GD2C2019DataSet gD2C2019DataSet;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}