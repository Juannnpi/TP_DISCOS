namespace App_DISCOS
{
    partial class frmAltaDisco
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCantidadCanciones = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblUrlTapa = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.cboEdicion = new System.Windows.Forms.ComboBox();
            this.dtpAño = new System.Windows.Forms.DateTimePicker();
            this.txtUrlTapa = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCanciones = new System.Windows.Forms.TextBox();
            this.pbxAgregarTapa = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarTapa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(93, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // lblCantidadCanciones
            // 
            this.lblCantidadCanciones.AutoSize = true;
            this.lblCantidadCanciones.Location = new System.Drawing.Point(13, 53);
            this.lblCantidadCanciones.Name = "lblCantidadCanciones";
            this.lblCantidadCanciones.Size = new System.Drawing.Size(119, 13);
            this.lblCantidadCanciones.TabIndex = 1;
            this.lblCantidadCanciones.Text = "Cantidad de canciones:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(29, 80);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(103, 13);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año de lanzamiento:";
            // 
            // lblUrlTapa
            // 
            this.lblUrlTapa.AutoSize = true;
            this.lblUrlTapa.Location = new System.Drawing.Point(32, 108);
            this.lblUrlTapa.Name = "lblUrlTapa";
            this.lblUrlTapa.Size = new System.Drawing.Size(100, 13);
            this.lblUrlTapa.TabIndex = 3;
            this.lblUrlTapa.Text = "Url Imagen de tapa:";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(96, 135);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(35, 13);
            this.lblEstilo.TabIndex = 4;
            this.lblEstilo.Text = "Estilo:";
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(87, 165);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(45, 13);
            this.lblEdicion.TabIndex = 5;
            this.lblEdicion.Text = "Edición:";
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(138, 135);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(154, 21);
            this.cboEstilo.TabIndex = 4;
            // 
            // cboEdicion
            // 
            this.cboEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdicion.FormattingEnabled = true;
            this.cboEdicion.Location = new System.Drawing.Point(138, 162);
            this.cboEdicion.Name = "cboEdicion";
            this.cboEdicion.Size = new System.Drawing.Size(154, 21);
            this.cboEdicion.TabIndex = 5;
            // 
            // dtpAño
            // 
            this.dtpAño.Checked = false;
            this.dtpAño.CustomFormat = "yyyy";
            this.dtpAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAño.Location = new System.Drawing.Point(139, 78);
            this.dtpAño.Name = "dtpAño";
            this.dtpAño.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpAño.ShowCheckBox = true;
            this.dtpAño.ShowUpDown = true;
            this.dtpAño.Size = new System.Drawing.Size(153, 20);
            this.dtpAño.TabIndex = 2;
            this.dtpAño.Value = new System.DateTime(1753, 1, 1, 1, 1, 0, 0);
            // 
            // txtUrlTapa
            // 
            this.txtUrlTapa.Location = new System.Drawing.Point(138, 106);
            this.txtUrlTapa.Name = "txtUrlTapa";
            this.txtUrlTapa.Size = new System.Drawing.Size(154, 20);
            this.txtUrlTapa.TabIndex = 3;
            this.txtUrlTapa.Leave += new System.EventHandler(this.txtUrlTapa_Leave);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(139, 18);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(153, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtCanciones
            // 
            this.txtCanciones.Location = new System.Drawing.Point(139, 50);
            this.txtCanciones.Name = "txtCanciones";
            this.txtCanciones.Size = new System.Drawing.Size(153, 20);
            this.txtCanciones.TabIndex = 1;
            // 
            // pbxAgregarTapa
            // 
            this.pbxAgregarTapa.Location = new System.Drawing.Point(323, 18);
            this.pbxAgregarTapa.Name = "pbxAgregarTapa";
            this.pbxAgregarTapa.Size = new System.Drawing.Size(210, 217);
            this.pbxAgregarTapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAgregarTapa.TabIndex = 12;
            this.pbxAgregarTapa.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(35, 212);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(217, 212);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 251);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbxAgregarTapa);
            this.Controls.Add(this.txtCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtUrlTapa);
            this.Controls.Add(this.dtpAño);
            this.Controls.Add(this.cboEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblUrlTapa);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblCantidadCanciones);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(565, 290);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(565, 290);
            this.Name = "frmAltaDisco";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarTapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCantidadCanciones;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblUrlTapa;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.ComboBox cboEdicion;
        private System.Windows.Forms.DateTimePicker dtpAño;
        private System.Windows.Forms.TextBox txtUrlTapa;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCanciones;
        private System.Windows.Forms.PictureBox pbxAgregarTapa;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}