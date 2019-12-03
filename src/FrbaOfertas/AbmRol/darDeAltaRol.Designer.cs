namespace FrbaOfertas.AbmRol
{
    partial class darDeAltaRol
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.comboBoxRoles);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Rol";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(31, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(37, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Rol ID";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(83, 42);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(267, 21);
            this.comboBoxRoles.TabIndex = 0;
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoles_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(346, 129);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            //this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 129);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // darDeAltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 166);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.Name = "darDeAltaRol";
            this.Text = "darDeAltaRol";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.darDeAltaRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lbl1;
    }
}