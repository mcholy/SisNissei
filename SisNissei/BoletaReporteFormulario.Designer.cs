namespace SisNissei
{
    partial class BoletaReporteFormulario
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
            this.rp_Boleta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rp_Boleta
            // 
            this.rp_Boleta.ActiveViewIndex = -1;
            this.rp_Boleta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rp_Boleta.Cursor = System.Windows.Forms.Cursors.Default;
            this.rp_Boleta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_Boleta.Location = new System.Drawing.Point(0, 0);
            this.rp_Boleta.Name = "rp_Boleta";
            this.rp_Boleta.Size = new System.Drawing.Size(914, 584);
            this.rp_Boleta.TabIndex = 0;
            this.rp_Boleta.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // BoletaReporteFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 584);
            this.Controls.Add(this.rp_Boleta);
            this.Name = "BoletaReporteFormulario";
            this.Text = "BoletaReporteFormulario";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rp_Boleta;

    }
}