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

    public partial class TipoEmpleado : Form
    {
        private Validacion itemValidacion = new Validacion();
        private TipoEmpleadoEntity item = new TipoEmpleadoEntity();
        private TipoEmpleadoService servicio = new TipoEmpleadoService();
        private int regmod = 0;
        private int idActual = 0;
        public TipoEmpleado()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();

            Skin.AplicarSkinDGV(dgvTipoEmpleado);
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtPorcentajeMatricula.Text = string.Empty;
            txtPorcentajeMensual.Text = string.Empty;
        }
        private void Guardar()
        {
            item.Id = idActual;
            item.Nombre = txtNombre.Text;
            item.Porcentajematricula = Double.Parse(txtPorcentajeMatricula.Text);
            item.Porcentajematricula = item.Porcentajematricula / 100;
            item.Porcentajemensual = Double.Parse(txtPorcentajeMensual.Text);
            item.Porcentajemensual = item.Porcentajemensual / 100;
            item.Regmod = regmod;
            //item.idtipoemeplado = icbsexo.selectedvalue;
            TipoEmpleadoService servicio = new TipoEmpleadoService();
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
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

        private void txtPorcentajeMensualidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void txtPorcentajeMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void CargarDetalle()
        {
            dgvTipoEmpleado.DataSource = servicio.Detalle();
            if (dgvTipoEmpleado.RowCount > 0)
            {
                dgvTipoEmpleado.Columns["id"].Visible = false;
                dgvTipoEmpleado.Columns["estado"].Visible = false;
                dgvTipoEmpleado.Columns["regmod"].Visible = false;
                dgvTipoEmpleado.Columns["fecharegistro"].Visible = false;
                dgvTipoEmpleado.Columns["nombre"].DisplayIndex = 0;
                dgvTipoEmpleado.Columns["nombre"].HeaderText = "Nombre";
                dgvTipoEmpleado.Columns["porcentajemensual"].DisplayIndex = 1;
                dgvTipoEmpleado.Columns["porcentajemensual"].HeaderText = "Porcentaje Mensual";
                dgvTipoEmpleado.Columns["porcentajematricula"].DisplayIndex = 2;
                dgvTipoEmpleado.Columns["porcentajematricula"].HeaderText = "Porcentaje Matricula";
            }
        }
        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvTipoEmpleado.CurrentRow.Cells["id"].Value.ToString());
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
            idActual = Int32.Parse(dgvTipoEmpleado.CurrentRow.Cells["id"].Value.ToString());
            txtNombre.Text = dgvTipoEmpleado.CurrentRow.Cells["nombre"].Value.ToString();
            txtPorcentajeMensual.Text = dgvTipoEmpleado.CurrentRow.Cells["porcentajemensual"].Value.ToString();
            txtPorcentajeMatricula.Text = dgvTipoEmpleado.CurrentRow.Cells["porcentajematricula"].Value.ToString();
        }
        private void TipoEmpleado_Load(object sender, EventArgs e)
        {
            dgvTipoEmpleado.ClearSelection();
            dgvTipoEmpleado.CurrentRow.Selected = false;
            txtBuscar.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvTipoEmpleado.RowCount > 0)
            {
                if (dgvTipoEmpleado.CurrentRow.Selected == true)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTipoEmpleado.RowCount > 0)
            {
                if (dgvTipoEmpleado.CurrentRow.Selected == true)
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
        #region Singleton
        private static TipoEmpleado m_FormDefInstance;
        public static TipoEmpleado DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new TipoEmpleado();
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
