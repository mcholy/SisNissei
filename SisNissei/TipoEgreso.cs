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
    public partial class TipoEgreso : Form
    {
        Validacion itemValidacion = new Validacion();
        TipoEgresoEntity item = new TipoEgresoEntity();
        TipoEgresoService servicio = new TipoEgresoService();
        public TipoEgreso()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
        }
        private void Guardar()
        {
            item.Nombre = txtNombre.Text;
            TipoEgresoService servicio = new TipoEgresoService();

            int respuesta = servicio.Guardar(item);
            if (respuesta == 1)
            {
                Limpiar();

                MessageBox.Show("El registro se ingreso satisfactoriamente.");
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }
        private void CargarDetalle()
        {
            dgvTipoEgreso.DataSource = servicio.Detalle();
            if (dgvTipoEgreso.RowCount > 0)
            {
                dgvTipoEgreso.Columns["id"].Visible = false;
                dgvTipoEgreso.Columns["estado"].Visible = false;
            }
        }
    }
}
