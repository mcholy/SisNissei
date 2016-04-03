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
        private int idActual = 0;
        private int regmod = 0;
        public Distrito()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
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
                dgvDistrito.Columns["regmod"].Visible = false;
                dgvDistrito.Columns["fecharegistro"].Visible = false;
            }
        }
        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvDistrito.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = servicio.Eliminar(item);
            if (respuesta == 1)
            {
                MessageBox.Show("El registro se elimino satisfactoriamente");
                CargarDetalle();
            }
        }
        private void LlenarContDistritoes()
        {
            idActual = Int32.Parse(dgvDistrito.CurrentRow.Cells["id"].Value.ToString());
            txtNombre.Text = dgvDistrito.CurrentRow.Cells["nombre"].Value.ToString();

        }
     
        private void Guardar()
        {
            item.Id = idActual;
            item.Nombre = txtNombre.Text;
            item.Regmod = regmod;
            DistritoService servicio = new DistritoService();
            int respuesta = servicio.Guardar(item);
            if (respuesta == 1)
            {
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
            }
            else if (respuesta == 2)
            {
                MessageBox.Show("El registro se actualizó satisfactoriamente.");
            }

            CargarDetalle();
            Limpiar();
        }
        private void LlenarContDistritos()
        {
            idActual = Int32.Parse(dgvDistrito.CurrentRow.Cells["id"].Value.ToString());
            txtNombre.Text = dgvDistrito.CurrentRow.Cells["nombre"].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDistrito.RowCount > 0)
            {
                if (dgvDistrito.CurrentRow.Selected == true)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar este registro?", "SisNisei",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Eliminar();
                    }
                }
                else
                {
                    MessageBox.Show("No hay ningún registro seleccionado.");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDistrito.RowCount > 0)
            {
                if (dgvDistrito.CurrentRow.Selected == true)
                {
                    LlenarContDistritos();
                    regmod = 1;
                }
                else
                {
                    MessageBox.Show("No hay ningún registro seleccionado");
                }
            }
        }
    }
}
