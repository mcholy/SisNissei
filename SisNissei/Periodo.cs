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
        private int idActual = 0;
        private int regmod = 0;
        public Periodo()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();

            Skin.AplicarSkinDGV(dgvPeriodo);
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
                dgvPeriodo.Columns["regmod"].Visible = false;
                dgvPeriodo.Columns["fecharegistro"].Visible = false;
            }
        }
        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvPeriodo.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = servicio.Eliminar(item);
            if (respuesta == 1)
            {
                MessageBox.Show("El registro se elimino satisfactoriamente");
                CargarDetalle();
            }
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
            PeriodoService servicio = new PeriodoService();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPeriodo.RowCount > 0)
            {
                if (dgvPeriodo.CurrentRow.Selected == true)
                {
                    LlenarContPeriodos();
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
            if (dgvPeriodo.RowCount > 0)
            {
                if (dgvPeriodo.CurrentRow.Selected == true)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void LlenarContPeriodos()
        {
            idActual = Int32.Parse(dgvPeriodo.CurrentRow.Cells["id"].Value.ToString());
            txtNombre.Text = dgvPeriodo.CurrentRow.Cells["nombre"].Value.ToString();

        }
        #region Singleton
        private static Periodo m_FormDefInstance;
        public static Periodo DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Periodo();
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
