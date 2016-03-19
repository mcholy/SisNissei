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
    public partial class Cliente : Form
    {
        Validacion itemValidacion= new Validacion();
        public Cliente()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
        }

        private void chkAlergia_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkAlergia.Checked)
                txtAlergia.ReadOnly = false;
            else
                txtAlergia.ReadOnly = true;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

    }
}
