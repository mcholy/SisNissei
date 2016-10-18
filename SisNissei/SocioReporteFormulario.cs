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

using SisNissei.Template;
using Models.Services;
using Entities;
using Models;


namespace SisNissei
{
    public partial class SocioReporteFormulario : Form
    {
        public SocioReporteFormulario()
        {

            InitializeComponent();
        }
        public int id;
        private void SocioReporteFormulario_Load(object sender, EventArgs e)
        {
            //SocioReporte rpt = new SocioReporte();

            //DatosSocio ds = new DatosSocio();
            
            //SocioReporte objReporte = new SocioReporte();
            //objReporte.SetDataSource(ds);
            //objReporte.SetParameterValue("@id", id);
            //rp_socio.ReportSource = objReporte;
          
        }
    }
}
