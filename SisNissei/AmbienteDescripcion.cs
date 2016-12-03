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
    public partial class AmbienteDescripcion : Form
    {
        private Validacion itemValidacion = new Validacion();
        private AmbienteDescripcionEntity item = new AmbienteDescripcionEntity();
        private AmbienteDescripcionService servicio = new AmbienteDescripcionService();
        private int regmod = 0;
        private int idActual = 0;
        public AmbienteDescripcion()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
            Skin.AplicarSkinDGV(dgvAmbienteDescripcion);
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            regmod = 0;

        }
        private void Guardar()
        {
            //item.idtipoemeplado = icbsexo.selectedvalue;
            item.Id = idActual;
            item.Nombre = txtNombre.Text;
            item.Regmod = regmod;
            AmbienteDescripcionService servicio = new AmbienteDescripcionService();
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
        private void CargarDetalle()
        {
            dgvAmbienteDescripcion.DataSource = servicio.Detalle();
            if (dgvAmbienteDescripcion.RowCount > 0)
            {
                dgvAmbienteDescripcion.Columns["id"].Visible = false;
                dgvAmbienteDescripcion.Columns["estado"].Visible = false;
                dgvAmbienteDescripcion.Columns["regmod"].Visible = false;
                dgvAmbienteDescripcion.Columns["fecharegistro"].Visible = false;
                dgvAmbienteDescripcion.Columns["nombre"].DisplayIndex = 0;
                dgvAmbienteDescripcion.Columns["nombre"].HeaderText = "Nombre";
            }
        }
        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvAmbienteDescripcion.CurrentRow.Cells["id"].Value.ToString());
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
            idActual = Int32.Parse(dgvAmbienteDescripcion.CurrentRow.Cells["id"].Value.ToString());
            txtNombre.Text = dgvAmbienteDescripcion.CurrentRow.Cells["nombre"].Value.ToString();
        }

        #region Singleton
        private static AmbienteDescripcion m_FormDefInstance;
        public static AmbienteDescripcion DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new AmbienteDescripcion();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion


        private void AmbienteDescripcion_Load(object sender, EventArgs e)
        {
            dgvAmbienteDescripcion.ClearSelection();
            dgvAmbienteDescripcion.CurrentRow.Selected = false;
            txtBuscar.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAmbienteDescripcion.RowCount > 0)
            {
                if (dgvAmbienteDescripcion.CurrentRow.Selected == true)
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
            if (dgvAmbienteDescripcion.RowCount > 0)
            {
                if (dgvAmbienteDescripcion.CurrentRow.Selected == true)
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
