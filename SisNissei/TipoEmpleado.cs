using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SisNissei.Template;

namespace SisNissei
{
    
    public partial class TipoEmpleado : Form
    {
        Validacion itemValidacion = new Validacion();
        public TipoEmpleado()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

        private void txtPorcentajeMensualidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void txtPorcentajeMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }
    }
}
