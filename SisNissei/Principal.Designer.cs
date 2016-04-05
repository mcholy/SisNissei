namespace SisNissei
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rolEnSistemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMantenimiento = new System.Windows.Forms.ToolStripDropDownButton();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoEgresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodoDeMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevo = new System.Windows.Forms.ToolStripDropDownButton();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.resumenBalanceGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnMantenimiento,
            this.btnNuevo,
            this.toolStripDropDownButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem1,
            this.rolEnSistemaToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton1.Text = "Sistema";
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.usuarioToolStripMenuItem1.Text = "Usuario";
            this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.usuarioToolStripMenuItem1_Click);
            // 
            // rolEnSistemaToolStripMenuItem1
            // 
            this.rolEnSistemaToolStripMenuItem1.Name = "rolEnSistemaToolStripMenuItem1";
            this.rolEnSistemaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.rolEnSistemaToolStripMenuItem1.Text = "Rol en Sistema";
            this.rolEnSistemaToolStripMenuItem1.Click += new System.EventHandler(this.rolEnSistemaToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursoToolStripMenuItem,
            this.distritoToolStripMenuItem,
            this.empleadoToolStripMenuItem1,
            this.horarioToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.periodoDeMatriculaToolStripMenuItem});
            this.btnMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnMantenimiento.Image")));
            this.btnMantenimiento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(102, 22);
            this.btnMantenimiento.Text = "Mantenimiento";
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cursoToolStripMenuItem.Text = "Curso";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // distritoToolStripMenuItem
            // 
            this.distritoToolStripMenuItem.Name = "distritoToolStripMenuItem";
            this.distritoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.distritoToolStripMenuItem.Text = "Distrito";
            this.distritoToolStripMenuItem.Click += new System.EventHandler(this.distritoToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem1
            // 
            this.empleadoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem2,
            this.tipoDeEmpleadoToolStripMenuItem});
            this.empleadoToolStripMenuItem1.Name = "empleadoToolStripMenuItem1";
            this.empleadoToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.empleadoToolStripMenuItem1.Text = "Empleado";
            // 
            // empleadoToolStripMenuItem2
            // 
            this.empleadoToolStripMenuItem2.Name = "empleadoToolStripMenuItem2";
            this.empleadoToolStripMenuItem2.Size = new System.Drawing.Size(170, 22);
            this.empleadoToolStripMenuItem2.Text = "Empleado";
            this.empleadoToolStripMenuItem2.Click += new System.EventHandler(this.empleadoToolStripMenuItem2_Click);
            // 
            // tipoDeEmpleadoToolStripMenuItem
            // 
            this.tipoDeEmpleadoToolStripMenuItem.Name = "tipoDeEmpleadoToolStripMenuItem";
            this.tipoDeEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.tipoDeEmpleadoToolStripMenuItem.Text = "Tipo de Empleado";
            this.tipoDeEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeEmpleadoToolStripMenuItem_Click_1);
            // 
            // horarioToolStripMenuItem
            // 
            this.horarioToolStripMenuItem.Name = "horarioToolStripMenuItem";
            this.horarioToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.horarioToolStripMenuItem.Text = "Horario";
            this.horarioToolStripMenuItem.Click += new System.EventHandler(this.horarioToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoEgresoToolStripMenuItem});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // tipoEgresoToolStripMenuItem
            // 
            this.tipoEgresoToolStripMenuItem.Name = "tipoEgresoToolStripMenuItem";
            this.tipoEgresoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tipoEgresoToolStripMenuItem.Text = "TipoEgreso";
            // 
            // periodoDeMatriculaToolStripMenuItem
            // 
            this.periodoDeMatriculaToolStripMenuItem.Name = "periodoDeMatriculaToolStripMenuItem";
            this.periodoDeMatriculaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.periodoDeMatriculaToolStripMenuItem.Text = "Periodo de matricula";
            this.periodoDeMatriculaToolStripMenuItem.Click += new System.EventHandler(this.periodoDeMatriculaToolStripMenuItem_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.inscripciónToolStripMenuItem,
            this.movimientoToolStripMenuItem});
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(63, 22);
            this.btnNuevo.Text = "Registro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // inscripciónToolStripMenuItem
            // 
            this.inscripciónToolStripMenuItem.Name = "inscripciónToolStripMenuItem";
            this.inscripciónToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.inscripciónToolStripMenuItem.Text = "Inscripción";
            // 
            // movimientoToolStripMenuItem
            // 
            this.movimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.egresoToolStripMenuItem,
            this.ingresoToolStripMenuItem});
            this.movimientoToolStripMenuItem.Name = "movimientoToolStripMenuItem";
            this.movimientoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.movimientoToolStripMenuItem.Text = "Movimiento";
            // 
            // egresoToolStripMenuItem
            // 
            this.egresoToolStripMenuItem.Name = "egresoToolStripMenuItem";
            this.egresoToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.egresoToolStripMenuItem.Text = "Egreso";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ingresoToolStripMenuItem.Text = "Ingreso";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumenBalanceGeneralToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.sociosToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton1.Text = "Reporte";
            // 
            // resumenBalanceGeneralToolStripMenuItem
            // 
            this.resumenBalanceGeneralToolStripMenuItem.Name = "resumenBalanceGeneralToolStripMenuItem";
            this.resumenBalanceGeneralToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.resumenBalanceGeneralToolStripMenuItem.Text = "Resumen Balance General";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripDropDownButton btnNuevo;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btnMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem periodoDeMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rolEnSistemaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tipoDeEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoEgresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenBalanceGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
    }
}



