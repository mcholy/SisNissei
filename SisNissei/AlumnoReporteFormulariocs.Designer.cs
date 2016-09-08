namespace SisNissei
{
    partial class AlumnoReporteFormulariocs
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
            this.rp_alumno = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rp_alumno
            // 
            this.rp_alumno.ActiveViewIndex = -1;
            this.rp_alumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rp_alumno.Cursor = System.Windows.Forms.Cursors.Default;
            this.rp_alumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_alumno.Location = new System.Drawing.Point(0, 0);
            this.rp_alumno.Name = "rp_alumno";
            this.rp_alumno.Size = new System.Drawing.Size(860, 447);
            this.rp_alumno.TabIndex = 0;
            // 
            // AlumnoReporteFormulariocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 447);
            this.Controls.Add(this.rp_alumno);
            this.Name = "AlumnoReporteFormulariocs";
            this.Text = "AlumnoReporteFormulariocs";
            this.Load += new System.EventHandler(this.AlumnoReporteFormulariocs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rp_alumno;
    }
}