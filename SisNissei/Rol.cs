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
        private int idActual = 0;
        private int regmod = 0;
        public Rol()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
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
            dgvRol.DataSource = servicio.Detalle();
            if (dgvRol.RowCount > 0)
            {
                dgvRol.Columns["id"].Visible = false;
                dgvRol.Columns["estado"].Visible = false;
                dgvRol.Columns["regmod"].Visible = false;
                dgvRol.Columns["fecharegistro"].Visible = false;
            }
        }
        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvRol.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = servicio.Eliminar(item);
            if (respuesta == 1)
            {
                MessageBox.Show("El registro se elimino satisfactoriamente");
            }
            CargarDetalle();
        }
        private void LlenarControles()
        {
            idActual = Int32.Parse(dgvRol.CurrentRow.Cells["id"].Value.ToString());
            txtNombre.Text = dgvRol.CurrentRow.Cells["nombre"].Value.ToString();

        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
        }
        private void Guardar()
        {
            item.Id = idActual;
            item.Nombre = txtNombre.Text;
            item.Regmod = regmod;
            RolService servicio = new RolService();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRol.RowCount > 0)
            {
                if (dgvRol.CurrentRow.Selected == true)
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
            if (dgvRol.RowCount > 0)
            {
                if (dgvRol.CurrentRow.Selected == true)
                {
                    LlenarControles();
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
