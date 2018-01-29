namespace SisNissei
{
    partial class PagoProfesores
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.cbMesPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListadoPago = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPago)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListar);
            this.groupBox2.Controls.Add(this.cbMesPago);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblCurso);
            this.groupBox2.Controls.Add(this.cbCurso);
            this.groupBox2.Controls.Add(this.cbPeriodo);
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(21, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 84);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListar.Image = global::SisNissei.Properties.Resources.search;
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.Location = new System.Drawing.Point(636, 18);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(84, 23);
            this.btnListar.TabIndex = 25;
            this.btnListar.Text = "Listar";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cbMesPago
            // 
            this.cbMesPago.FormattingEnabled = true;
            this.cbMesPago.Location = new System.Drawing.Point(306, 20);
            this.cbMesPago.Name = "cbMesPago";
            this.cbMesPago.Size = new System.Drawing.Size(125, 21);
            this.cbMesPago.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mes de Pago :";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(451, 23);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(47, 13);
            this.lblCurso.TabIndex = 21;
            this.lblCurso.Text = "Curso :";
            // 
            // cbCurso
            // 
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(504, 19);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(126, 21);
            this.cbCurso.TabIndex = 20;
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Location = new System.Drawing.Point(78, 21);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(133, 21);
            this.cbPeriodo.TabIndex = 18;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Image = global::SisNissei.Properties.Resources.search;
            this.btnBuscarCliente.Location = new System.Drawing.Point(689, 54);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(31, 23);
            this.btnBuscarCliente.TabIndex = 17;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Periodo :";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(78, 56);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(605, 20);
            this.txtNombreCliente.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "CLIENTE :";
            // 
            // dgvListadoPago
            // 
            this.dgvListadoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPago.Location = new System.Drawing.Point(21, 96);
            this.dgvListadoPago.Name = "dgvListadoPago";
            this.dgvListadoPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoPago.Size = new System.Drawing.Size(740, 328);
            this.dgvListadoPago.TabIndex = 30;
            this.dgvListadoPago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoPago_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCancelar,
            this.btnGuardar,
            this.btnImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 439);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(779, 45);
            this.toolStrip1.TabIndex = 31;
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
            // btnGuardar
            // 
            this.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = global::SisNissei.Properties.Resources.save;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(36, 42);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImprimir.Image = global::SisNissei.Properties.Resources.Check_02;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(36, 42);
            this.btnImprimir.Text = "toolStripButton1";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // PagoProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvListadoPago);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PagoProfesores";
            this.Text = "PagoProfesores";
            this.Load += new System.EventHandler(this.PagoProfesores_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPago)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cbMesPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvListadoPago;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
    }
}