using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SisNissei.Template;
using Entities;
using Models.Services;

namespace SisNissei
{
    public partial class Distrito : Form
    {
        Validacion itemValidacion = new Validacion();
        DistritoEntity item = new DistritoEntity();
        DistritoService servicio = new DistritoService();
        public Distrito()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
        }


        private void Guardar()
        {
            item.Nombre = txtNombre.Text;
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
            dgvDistrito.DataSource = servicio.Detalle();
            if (dgvDistrito.RowCount > 0)
            {
                dgvDistrito.Columns["id"].Visible = false;
                dgvDistrito.Columns["estado"].Visible = false;
            }
        }

    }
}
