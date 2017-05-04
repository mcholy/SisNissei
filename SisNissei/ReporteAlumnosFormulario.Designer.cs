namespace SisNissei
{
    partial class ReporteAlumnosFormulario
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
            this.rpReporteAlumnos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpReporteAlumnos
            // 
            this.rpReporteAlumnos.ActiveViewIndex = -1;
            this.rpReporteAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpReporteAlumnos.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpReporteAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpReporteAlumnos.Location = new System.Drawing.Point(0, 0);
            this.rpReporteAlumnos.Name = "rpReporteAlumnos";
            this.rpReporteAlumnos.Size = new System.Drawing.Size(653, 508);
            this.rpReporteAlumnos.TabIndex = 0;
            // 
            // ReporteAlumnosFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 508);
            this.Controls.Add(this.rpReporteAlumnos);
            this.Name = "ReporteAlumnosFormulario";
            this.Text = "ReporteAlumnosFormulario";
            this.Load += new System.EventHandler(this.ReporteAlumnosFormulario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rpReporteAlumnos;

    }
}