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
using Models.Services;


namespace SisNissei
{
    public partial class BoletaReporteFormulario : Form
    {
        public BoletaReporteFormulario()
        {
            InitializeComponent();
        }
        public int id;
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
