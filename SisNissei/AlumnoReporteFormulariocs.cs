using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using SisNissei.Template;
using System.Data.SqlClient;


namespace SisNissei
{
    public partial class AlumnoReporteFormulariocs : Form
    {
        public AlumnoReporteFormulariocs()
        {
            InitializeComponent();
        }
        public int id;

        private void AlumnoReporteFormulariocs_Load(object sender, EventArgs e)
        {
            AlumnoReporte objReporte = new AlumnoReporte();
            objReporte.SetParameterValue("@id", id);
            rp_alumno.ReportSource = objReporte;
        }
    }
}
