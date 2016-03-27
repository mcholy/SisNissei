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
    public partial class Periodo : Form
    {
        Validacion itemValidacion = new Validacion();
        PeriodoEntity item = new PeriodoEntity();
        PeriodoService servicio = new PeriodoService();
        public Periodo()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
        }
        private void Guardar()
        {
            item.Nombre = txtNombre.Text;
            PeriodoService servicio = new PeriodoService();
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
            dgvPeriodo.DataSource = servicio.Detalle();
            if (dgvPeriodo.RowCount > 0)
            {
                dgvPeriodo.Columns["id"].Visible = false;
                dgvPeriodo.Columns["estado"].Visible = false;
            }
        }
    }
}
