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
    public partial class Login : Form
    {
        Validacion itemValidacion = new Validacion();
        public Login()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }
    }
}
