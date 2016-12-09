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
            this.rpt_Alquiler = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpt_Alquiler
            // 
            this.rpt_Alquiler.ActiveViewIndex = -1;
            this.rpt_Alquiler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt_Alquiler.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt_Alquiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_Alquiler.Location = new System.Drawing.Point(0, 0);
            this.rpt_Alquiler.Name = "rpt_Alquiler";
            this.rpt_Alquiler.Size = new System.Drawing.Size(953, 699);
            this.rpt_Alquiler.TabIndex = 0;
            // 
            // AlquilerReporteFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 699);
            this.Controls.Add(this.rpt_Alquiler);
            this.Name = "AlquilerReporteFormulario";
            this.Text = "AlquilerReporteFormulario";
            this.Load += new System.EventHandler(this.AlquilerReporteFormulario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rpt_Alquiler;

    }
}