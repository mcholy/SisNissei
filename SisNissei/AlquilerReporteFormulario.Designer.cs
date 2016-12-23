namespace SisNissei
{
    partial class AlquilerReporteFormulario
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
            this.rp_Alquiler = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rp_Alquiler
            // 
            this.rp_Alquiler.ActiveViewIndex = -1;
            this.rp_Alquiler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rp_Alquiler.Cursor = System.Windows.Forms.Cursors.Default;
            this.rp_Alquiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_Alquiler.Location = new System.Drawing.Point(0, 0);
            this.rp_Alquiler.Name = "rp_Alquiler";
            this.rp_Alquiler.Size = new System.Drawing.Size(953, 699);
            this.rp_Alquiler.TabIndex = 0;
            // 
            // AlquilerReporteFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 699);
            this.Controls.Add(this.rp_Alquiler);
            this.Name = "AlquilerReporteFormulario";
            this.Text = "AlquilerReporteFormulario";
            this.Load += new System.EventHandler(this.AlquilerReporteFormulario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rp_Alquiler;

    }
}