namespace FrbaOfertas.ComprarOferta
{
    partial class ComprarOferta
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
            this.dgPublicaciones = new System.Windows.Forms.DataGridView();
            this.lblOfertasPublicadas = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPublicaciones
            // 
            this.dgPublicaciones.AllowUserToAddRows = false;
            this.dgPublicaciones.AllowUserToDeleteRows = false;
            this.dgPublicaciones.AllowUserToOrderColumns = true;
            this.dgPublicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPublicaciones.Location = new System.Drawing.Point(15, 47);
            this.dgPublicaciones.MultiSelect = false;
            this.dgPublicaciones.Name = "dgPublicaciones";
            this.dgPublicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPublicaciones.Size = new System.Drawing.Size(902, 264);
            this.dgPublicaciones.TabIndex = 0;
            // 
            // lblOfertasPublicadas
            // 
            this.lblOfertasPublicadas.AutoSize = true;
            this.lblOfertasPublicadas.Location = new System.Drawing.Point(12, 22);
            this.lblOfertasPublicadas.Name = "lblOfertasPublicadas";
            this.lblOfertasPublicadas.Size = new System.Drawing.Size(95, 13);
            this.lblOfertasPublicadas.TabIndex = 1;
            this.lblOfertasPublicadas.Text = "Ofertas publicadas";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.SystemColors.Control;
            this.btnComprar.Location = new System.Drawing.Point(745, 320);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(172, 23);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Comprar Oferta";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(15, 317);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(607, 15);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(114, 13);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo disponible        $";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(739, 12);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(178, 20);
            this.txtSaldo.TabIndex = 5;
            // 
            // ComprarOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 355);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblOfertasPublicadas);
            this.Controls.Add(this.dgPublicaciones);
            this.Name = "ComprarOferta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar Oferta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComprarOferta_FormClosed);
            this.Load += new System.EventHandler(this.ComprarOferta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPublicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPublicaciones;
        private System.Windows.Forms.Label lblOfertasPublicadas;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
    }
}