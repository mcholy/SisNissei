namespace SisNissei
{
    partial class Horario
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvDetalleHorario = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtduracion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnHora = new System.Windows.Forms.Button();
            this.txtHorario = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGrupoEtario = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkDomingo = new System.Windows.Forms.CheckBox();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkMiercoles = new System.Windows.Forms.CheckBox();
            this.chkMartes = new System.Windows.Forms.CheckBox();
            this.chkLunes = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleHorario)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::SisNissei.Properties.Resources.search;
            this.btnBuscar.Location = new System.Drawing.Point(296, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvHorario
            // 
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.Location = new System.Drawing.Point(14, 60);
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.Size = new System.Drawing.Size(321, 348);
            this.dgvHorario.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(284, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::SisNissei.Properties.Resources.delete;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(36, 28);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = global::SisNissei.Properties.Resources.save;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(36, 28);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::SisNissei.Properties.Resources.cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 28);
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificar.Image = global::SisNissei.Properties.Resources.edit;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(36, 28);
            this.btnModificar.Text = "Editar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnCancelar,
            this.btnGuardar,
            this.btnEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 383);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(352, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "tsCliente";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::SisNissei.Properties.Resources._new;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(36, 28);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "HORARIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 36);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvDetalleHorario);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvHorario);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(706, 416);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.TabIndex = 6;
            // 
            // dgvDetalleHorario
            // 
            this.dgvDetalleHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleHorario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetalleHorario.Location = new System.Drawing.Point(16, 269);
            this.dgvDetalleHorario.Name = "dgvDetalleHorario";
            this.dgvDetalleHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleHorario.Size = new System.Drawing.Size(323, 110);
            this.dgvDetalleHorario.TabIndex = 2;
            this.dgvDetalleHorario.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDetalleHorario_UserDeletingRow);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtduracion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpFechaInicio);
            this.groupBox2.Controls.Add(this.btnHora);
            this.groupBox2.Controls.Add(this.txtHorario);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbCurso);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbGrupoEtario);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(11, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 222);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Duración (Meses)";
            // 
            // txtduracion
            // 
            this.txtduracion.Location = new System.Drawing.Point(276, 88);
            this.txtduracion.Name = "txtduracion";
            this.txtduracion.Size = new System.Drawing.Size(43, 20);
            this.txtduracion.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha de Inicio :";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(98, 63);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaInicio.TabIndex = 12;
            // 
            // btnHora
            // 
            this.btnHora.Location = new System.Drawing.Point(245, 60);
            this.btnHora.Name = "btnHora";
            this.btnHora.Size = new System.Drawing.Size(75, 23);
            this.btnHora.TabIndex = 18;
            this.btnHora.Text = "+ Horas";
            this.btnHora.UseVisualStyleBackColor = true;
            this.btnHora.Click += new System.EventHandler(this.btnHora_Click);
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(109, 89);
            this.txtHorario.Mask = "90:00 - 90:00";
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(74, 20);
            this.txtHorario.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Grupo Etario :";
            // 
            // cbCurso
            // 
            this.cbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(15, 33);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(127, 21);
            this.cbCurso.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Curso :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Rango de Horario :";
            // 
            // cbGrupoEtario
            // 
            this.cbGrupoEtario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupoEtario.FormattingEnabled = true;
            this.cbGrupoEtario.Location = new System.Drawing.Point(193, 33);
            this.cbGrupoEtario.Name = "cbGrupoEtario";
            this.cbGrupoEtario.Size = new System.Drawing.Size(127, 21);
            this.cbGrupoEtario.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkDomingo);
            this.groupBox3.Controls.Add(this.chkViernes);
            this.groupBox3.Controls.Add(this.chkSabado);
            this.groupBox3.Controls.Add(this.chkJueves);
            this.groupBox3.Controls.Add(this.chkMiercoles);
            this.groupBox3.Controls.Add(this.chkMartes);
            this.groupBox3.Controls.Add(this.chkLunes);
            this.groupBox3.Location = new System.Drawing.Point(15, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 92);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Días";
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.Location = new System.Drawing.Point(14, 68);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(68, 17);
            this.chkDomingo.TabIndex = 11;
            this.chkDomingo.Text = "Domingo";
            this.chkDomingo.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.Location = new System.Drawing.Point(108, 45);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(61, 17);
            this.chkViernes.TabIndex = 9;
            this.chkViernes.Text = "Viernes";
            this.chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Location = new System.Drawing.Point(203, 45);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(63, 17);
            this.chkSabado.TabIndex = 10;
            this.chkSabado.Text = "Sábado";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.Location = new System.Drawing.Point(14, 45);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(60, 17);
            this.chkJueves.TabIndex = 8;
            this.chkJueves.Text = "Jueves";
            this.chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.Location = new System.Drawing.Point(203, 22);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(71, 17);
            this.chkMiercoles.TabIndex = 7;
            this.chkMiercoles.Text = "Miércoles";
            this.chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.Location = new System.Drawing.Point(108, 22);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(58, 17);
            this.chkMartes.TabIndex = 6;
            this.chkMartes.Text = "Martes";
            this.chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.Location = new System.Drawing.Point(14, 22);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(55, 17);
            this.chkLunes.TabIndex = 5;
            this.chkLunes.Text = "Lunes";
            this.chkLunes.UseVisualStyleBackColor = true;
            // 
            // Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 416);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Horario";
            this.Load += new System.EventHandler(this.Horario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleHorario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetalleHorario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkDomingo;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkMiercoles;
        private System.Windows.Forms.CheckBox chkMartes;
        private System.Windows.Forms.CheckBox chkLunes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbGrupoEtario;
        private System.Windows.Forms.Button btnHora;
        private System.Windows.Forms.MaskedTextBox txtHorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtduracion;
    }
}