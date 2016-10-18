namespace SisNissei
{
    partial class SocioReporteFormulario
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
            this.rp_socio = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rp_socio
            // 
            this.rp_socio.ActiveViewIndex = -1;
            this.rp_socio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rp_socio.Cursor = System.Windows.Forms.Cursors.Default;
            this.rp_socio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_socio.Location = new System.Drawing.Point(0, 0);
            this.rp_socio.Name = "rp_socio";
            this.rp_socio.Size = new System.Drawing.Size(818, 377);
            this.rp_socio.TabIndex = 0;
           
            // 
            // SocioReporteFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 377);
            this.Controls.Add(this.rp_socio);
            this.Name = "SocioReporteFormulario";
            this.Text = "SocioReporteFormulario";
            this.Load += new System.EventHandler(this.SocioReporteFormulario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rp_socio;

    }
}