namespace SisNissei
{
    partial class IngresoMantenimiento
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
            this.label9 = new System.Windows.Forms.Label();
            this.rdbfactura = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbBoleta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbFecha = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechFin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscaRecibos = new System.Windows.Forms.Button();
            this.cbTipoIngreso = new System.Windows.Forms.ComboBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechIni = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFicha = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "TIPO :";
            // 
            // rdbfactura
            // 
            this.rdbfactura.AutoSize = true;
            this.rdbfactura.Location = new System.Drawing.Point(13, 65);
            this.rdbfactura.Name = "rdbfactura";
            this.rdbfactura.Size = new System.Drawing.Size(75, 17);
            this.rdbfactura.TabIndex = 1;
            this.rdbfactura.Text = "FACTURA";
            this.rdbfactura.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCancelar,
            this.btnEliminar,
            this.btnFicha});
            this.toolStrip1.Location = new System.Drawing.Point(0, 476);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(805, 45);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "tsCliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::SisNissei.Properties.Resources.cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 42);
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::SisNissei.Properties.Resources.delete;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(36, 42);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.rdbfactura);
            this.groupBox3.Controls.Add(this.rdbBoleta);
            this.groupBox3.Location = new System.Drawing.Point(690, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 105);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // rdbBoleta
            // 
            this.rdbBoleta.AutoSize = true;
            this.rdbBoleta.Checked = true;
            this.rdbBoleta.Location = new System.Drawing.Point(13, 42);
            this.rdbBoleta.Name = "rdbBoleta";
            this.rdbBoleta.Size = new System.Drawing.Size(67, 17);
            this.rdbBoleta.TabIndex = 0;
            this.rdbBoleta.TabStop = true;
            this.rdbBoleta.Text = "BOLETA";
            this.rdbBoleta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "CIRCULO SOCIAL NISEI - HUACHO";
            // 
            // dgvRecibos
            // 
            this.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibos.Location = new System.Drawing.Point(12, 218);
            this.dgvRecibos.Name = "dgvRecibos";
            this.dgvRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecibos.Size = new System.Drawing.Size(777, 255);
            this.dgvRecibos.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbFecha);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpFechFin);
            this.groupBox2.Controls.Add(this.btnBuscaRecibos);
            this.groupBox2.Controls.Add(this.cbTipoIngreso);
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpFechIni);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 105);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // ckbFecha
            // 
            this.ckbFecha.AutoSize = true;
            this.ckbFecha.Location = new System.Drawing.Point(345, 43);
            this.ckbFecha.Name = "ckbFecha";
            this.ckbFecha.Size = new System.Drawing.Size(110, 17);
            this.ckbFecha.TabIndex = 25;
            this.ckbFecha.Text = "Filtrar por  Fechas";
            this.ckbFecha.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "FECHA FIN :";
            // 
            // dtpFechFin
            // 
            this.dtpFechFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechFin.Location = new System.Drawing.Point(559, 69);
            this.dtpFechFin.Name = "dtpFechFin";
            this.dtpFechFin.Size = new System.Drawing.Size(96, 20);
            this.dtpFechFin.TabIndex = 23;
            // 
            // btnBuscaRecibos
            // 
            this.btnBuscaRecibos.Location = new System.Drawing.Point(35, 72);
            this.btnBuscaRecibos.Name = "btnBuscaRecibos";
            this.btnBuscaRecibos.Size = new System.Drawing.Size(150, 23);
            this.btnBuscaRecibos.TabIndex = 19;
            this.btnBuscaRecibos.Text = "Buscar Recibos";
            this.btnBuscaRecibos.UseVisualStyleBackColor = true;
            // 
            // cbTipoIngreso
            // 
            this.cbTipoIngreso.FormattingEnabled = true;
            this.cbTipoIngreso.Location = new System.Drawing.Point(145, 40);
            this.cbTipoIngreso.Name = "cbTipoIngreso";
            this.cbTipoIngreso.Size = new System.Drawing.Size(151, 21);
            this.cbTipoIngreso.TabIndex = 18;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Image = global::SisNissei.Properties.Resources.search;
            this.btnBuscarCliente.Location = new System.Drawing.Point(625, 12);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(31, 23);
            this.btnBuscarCliente.TabIndex = 17;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "FECHA INICIO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "CLIENTE :";
            // 
            // dtpFechIni
            // 
            this.dtpFechIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechIni.Location = new System.Drawing.Point(559, 42);
            this.dtpFechIni.Name = "dtpFechIni";
            this.dtpFechIni.Size = new System.Drawing.Size(96, 20);
            this.dtpFechIni.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "EN CONCEPTO DE:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(145, 13);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(468, 20);
            this.txtNombreCliente.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SisNissei.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(47, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // btnFicha
            // 
            this.btnFicha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFicha.Image = global::SisNissei.Properties.Resources.imprimir;
            this.btnFicha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFicha.Name = "btnFicha";
            this.btnFicha.Size = new System.Drawing.Size(36, 42);
            this.btnFicha.Text = "Imprimir Ficha";
            this.btnFicha.Click += new System.EventHandler(this.btnFicha_Click);
            // 
            // IngresoMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 521);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRecibos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "IngresoMantenimiento";
            this.Text = "IngresoMantenimiento";
            this.Load += new System.EventHandler(this.IngresoMantenimiento_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdbfactura;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbBoleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRecibos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscaRecibos;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechIni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechFin;
        private System.Windows.Forms.ComboBox cbTipoIngreso;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.CheckBox ckbFecha;
        private System.Windows.Forms.ToolStripButton btnFicha;
    }
}