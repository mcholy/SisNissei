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
using Entities;

namespace SisNissei
{
    public partial class Rol : Form
    {
        RolEntity item = new RolEntity();
        public Rol()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
        }
        private void Guardar()
        {
            item.Nombre = txtNombre.Text;
            RolService servicio = new RolService();
            int respuesta = servicio.Guardar(item);
            if (respuesta == 1)
            {
                Limpiar();

                MessageBox.Show("El registro se ingreso satisfactoriamente.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
        }
    }
}
