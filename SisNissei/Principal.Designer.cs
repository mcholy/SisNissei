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
            this.btnNuevo = new System.Windows.Forms.ToolStripDropDownButton();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMantenimiento = new System.Windows.Forms.ToolStripDropDownButton();
            this.tipoDeEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolEnSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodoDeMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnNuevo,
            this.btnMantenimiento});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.empresaToolStripMenuItem});
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(55, 22);
            this.btnNuevo.Text = "Nuevo";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeEmpleadoToolStripMenuItem,
            this.rolEnSistemaToolStripMenuItem,
            this.periodoDeMatriculaToolStripMenuItem,
            this.distritoToolStripMenuItem});
            this.btnMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnMantenimiento.Image")));
            this.btnMantenimiento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(102, 22);
            this.btnMantenimiento.Text = "Mantenimiento";
            // 
            // tipoDeEmpleadoToolStripMenuItem
            // 
            this.tipoDeEmpleadoToolStripMenuItem.Name = "tipoDeEmpleadoToolStripMenuItem";
            this.tipoDeEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tipoDeEmpleadoToolStripMenuItem.Text = "Tipo de Empleado";
            // 
            // rolEnSistemaToolStripMenuItem
            // 
            this.rolEnSistemaToolStripMenuItem.Name = "rolEnSistemaToolStripMenuItem";
            this.rolEnSistemaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.rolEnSistemaToolStripMenuItem.Text = "Rol en Sistema";
            // 
            // periodoDeMatriculaToolStripMenuItem
            // 
            this.periodoDeMatriculaToolStripMenuItem.Name = "periodoDeMatriculaToolStripMenuItem";
            this.periodoDeMatriculaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.periodoDeMatriculaToolStripMenuItem.Text = "Periodo de matricula";
            // 
            // distritoToolStripMenuItem
            // 
            this.distritoToolStripMenuItem.Name = "distritoToolStripMenuItem";
            this.distritoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.distritoToolStripMenuItem.Text = "Distrito";
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
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btnMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem tipoDeEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolEnSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodoDeMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distritoToolStripMenuItem;
    }
}



