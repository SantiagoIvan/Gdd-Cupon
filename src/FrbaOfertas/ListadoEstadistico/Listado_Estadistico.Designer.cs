namespace FrbaOfertas.ListadoEstadistico
{
    partial class Listado_Estadistico
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
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.lblSemestral = new System.Windows.Forms.Label();
            this.lblTipoListado = new System.Windows.Forms.Label();
            this.cmbTipoListado = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgListado = new System.Windows.Forms.DataGridView();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemestre.Location = new System.Drawing.Point(157, 69);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(241, 21);
            this.cmbSemestre.TabIndex = 2;
            // 
            // lblSemestral
            // 
            this.lblSemestral.AutoSize = true;
            this.lblSemestral.Location = new System.Drawing.Point(65, 69);
            this.lblSemestral.Name = "lblSemestral";
            this.lblSemestral.Size = new System.Drawing.Size(51, 13);
            this.lblSemestral.TabIndex = 1;
            this.lblSemestral.Text = "Semestre";
            // 
            // lblTipoListado
            // 
            this.lblTipoListado.AutoSize = true;
            this.lblTipoListado.Location = new System.Drawing.Point(65, 108);
            this.lblTipoListado.Name = "lblTipoListado";
            this.lblTipoListado.Size = new System.Drawing.Size(80, 13);
            this.lblTipoListado.TabIndex = 2;
            this.lblTipoListado.Text = "Tipo de Listado";
            // 
            // cmbTipoListado
            // 
            this.cmbTipoListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoListado.Location = new System.Drawing.Point(157, 108);
            this.cmbTipoListado.Name = "cmbTipoListado";
            this.cmbTipoListado.Size = new System.Drawing.Size(241, 21);
            this.cmbTipoListado.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnConsultar.Location = new System.Drawing.Point(169, 149);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(155, 36);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgListado
            // 
            this.dgListado.AllowUserToAddRows = false;
            this.dgListado.AllowUserToDeleteRows = false;
            this.dgListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgListado.Location = new System.Drawing.Point(12, 201);
            this.dgListado.MultiSelect = false;
            this.dgListado.Name = "dgListado";
            this.dgListado.ReadOnly = true;
            this.dgListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListado.Size = new System.Drawing.Size(462, 153);
            this.dgListado.TabIndex = 7;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(65, 30);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 8;
            this.lblAnio.Text = "Año";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(157, 30);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(241, 20);
            this.txtYear.TabIndex = 1;
            // 
            // Listado_Estadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 366);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.dgListado);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cmbTipoListado);
            this.Controls.Add(this.cmbSemestre);
            this.Controls.Add(this.lblTipoListado);
            this.Controls.Add(this.lblSemestral);
            this.Name = "Listado_Estadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Estadistico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Listado_Estadistico_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSemestral;
        private System.Windows.Forms.Label lblTipoListado;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.ComboBox cmbTipoListado;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgListado;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox txtYear;
    }
}