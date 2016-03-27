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
        Validacion itemValidacion = new Validacion();
        RolEntity item = new RolEntity();
        RolService servicio = new RolService();
        public Rol()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }
        private void CargarDetalle()
        {
            dgvRol.DataSource = servicio.Detalle();
            if (dgvRol.RowCount > 0)
            {
                dgvRol.Columns["id"].Visible = false;
                dgvRol.Columns["estado"].Visible = false;
            }
        }
    }
}
