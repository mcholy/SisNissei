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
    public partial class TipoInscripcionSocio : Form
    {
        private Validacion itemValidacion = new Validacion();
        private TipoInscripcionSocioEntity item = new TipoInscripcionSocioEntity();
        private TipoInscripcionSocioService servicio = new TipoInscripcionSocioService();
        private int regmod = 0;
        private int idActual = 0;

        public TipoInscripcionSocio()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtCosto.Text = string.Empty;
        }
        private void Guardar()
        {
            //item.idtipoemeplado = icbsexo.selectedvalue;
             if (txtCosto.Text == string.Empty)
            {
                MessageBox.Show("Campos solicitados vacios.");
            }
            else
            {
                item.Id = idActual;
                item.Nombre = txtNombre.Text;
                item.Costo = Double.Parse(txtCosto.Text);
                item.Regmod = regmod;
                TipoInscripcionSocioService servicio = new TipoInscripcionSocioService();
                int respuesta = servicio.Guardar(item);
                if (respuesta == 1)
                {
                    MessageBox.Show("El registro se ingreso satisfactoriamente.");
                }
                else if (respuesta == 2)
                {
                    MessageBox.Show("El registro se actualizó satisfactoriamente.");
                }
                Limpiar();
                CargarDetalle();
            }
        }
        private void CargarDetalle()
        {
            dgvTipoInscripcionSocio.DataSource = servicio.Detalle();
            if (dgvTipoInscripcionSocio.RowCount > 0)
            {
                dgvTipoInscripcionSocio.Columns["id"].Visible = false;
                dgvTipoInscripcionSocio.Columns["estado"].Visible = false;
                dgvTipoInscripcionSocio.Columns["regmod"].Visible = false;
                dgvTipoInscripcionSocio.Columns["fecharegistro"].Visible = false;
                dgvTipoInscripcionSocio.Columns["nombre"].DisplayIndex = 0;
                dgvTipoInscripcionSocio.Columns["nombre"].HeaderText = "Nombre";
                dgvTipoInscripcionSocio.Columns["costo"].DisplayIndex = 1;
                dgvTipoInscripcionSocio.Columns["costo"].HeaderText = "Costo";
            }
        }
        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvTipoInscripcionSocio.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = servicio.Eliminar(item);
            if (respuesta == 1)
            {
                //Limpiar();
                MessageBox.Show("El registro se elimino satisfactoriamente.");
                CargarDetalle();
            }
        }
        private void LlenarControles()
        {
            idActual = Int32.Parse(dgvTipoInscripcionSocio.CurrentRow.Cells["id"].Value.ToString());
            txtNombre.Text = dgvTipoInscripcionSocio.CurrentRow.Cells["nombre"].Value.ToString();
            txtCosto.Text = dgvTipoInscripcionSocio.CurrentRow.Cells["costo"].Value.ToString();
        }
        private void TipoInscripcionSocio_Load(object sender, EventArgs e)
        {
            dgvTipoInscripcionSocio.ClearSelection();
            dgvTipoInscripcionSocio.CurrentRow.Selected = false;
            txtBuscar.Focus();
        }
        #region Singleton
        private static TipoInscripcionSocio m_FormDefInstance;
        public static TipoInscripcionSocio DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new TipoInscripcionSocio();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTipoInscripcionSocio.RowCount > 0)
            {
                if (dgvTipoInscripcionSocio.CurrentRow.Selected == true)
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
            if (dgvTipoInscripcionSocio.RowCount > 0)
            {
                if (dgvTipoInscripcionSocio.CurrentRow.Selected == true)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

    }
}
