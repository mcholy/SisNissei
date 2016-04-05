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
        private int idActual = 0;
        private int regmod = 0;
        public TipoEgreso()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
        }
        private void CargarDetalle()
        {
            dgvTipoEgreso.DataSource = servicio.Detalle();
            if (dgvTipoEgreso.RowCount > 0)
            {
                dgvTipoEgreso.Columns["id"].Visible = false;
                dgvTipoEgreso.Columns["estado"].Visible = false;
                dgvTipoEgreso.Columns["regmod"].Visible = false;
                dgvTipoEgreso.Columns["fecharegistro"].Visible = false;
            }
        }
        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvTipoEgreso.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = servicio.Eliminar(item);
            if (respuesta == 1)
            {
                MessageBox.Show("El registro se elimino satisfactoriamente");
                CargarDetalle();
            }
        }
        private void LlenarControles()
        {
            idActual = Int32.Parse(dgvTipoEgreso.CurrentRow.Cells["id"].Value.ToString());
            txtNombre.Text = dgvTipoEgreso.CurrentRow.Cells["nombre"].Value.ToString();

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
            TipoEgresoService servicio = new TipoEgresoService();
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTipoEgreso.RowCount > 0)
            {
                if (dgvTipoEgreso.CurrentRow.Selected == true)
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
            if (dgvTipoEgreso.RowCount > 0)
            {
                if (dgvTipoEgreso.CurrentRow.Selected == true)
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
        #region Singleton
        private static TipoEgreso m_FormDefInstance;
        public static TipoEgreso DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new TipoEgreso();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion
    }
}
