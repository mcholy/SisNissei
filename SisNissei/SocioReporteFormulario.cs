﻿using System;
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
    public partial class SocioReporteFormulario : Form
    {
        public SocioReporteFormulario()
        {

            InitializeComponent();
        }
        public int id;
        private void SocioReporteFormulario_Load(object sender, EventArgs e)
        {

            SocioReporte objReporte = new SocioReporte();

            objReporte.SetParameterValue("@id", id);
            rp_socio.ReportSource = objReporte;
          
        }
    }
}
