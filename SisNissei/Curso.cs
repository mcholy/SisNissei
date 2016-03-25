using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SisNissei.Template;
using Models.Services;
namespace SisNissei
{
    public partial class Curso : Form
    {
        Validacion itemValidacion = new Validacion();

        public Curso()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }
    }
}
