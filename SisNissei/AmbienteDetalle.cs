using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SisNissei
{
    public partial class AmbienteDetalle : Form
    {
        public AmbienteDetalle()
        {
            InitializeComponent();
        }

        private void ListarTipoCliente()
        {
            cbTipoCliente.Items.Add("Publico");
            cbTipoCliente.Items.Add("Socio");
        }
    }
}
