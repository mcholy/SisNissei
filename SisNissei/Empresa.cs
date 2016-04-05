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
    public partial class Empresa : Form
    {
        #region Propiedades
        private Validacion itemValidacion = new Validacion();
        private EmpresaEntity item = new EmpresaEntity();
        private EmpresaService servicio = new EmpresaService();
        private int regmod = 0;
        private int idActual = 0;
        #endregion
        public Empresa()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
        }
        private void Limpiar()
        {
            txtDescuento.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }
        private void Guardar()
        {
            item.Id = idActual;
            item.Nombre = txtNombre.Text;
            item.Descuento = Double.Parse(txtDescuento.Text);
            item.Descuento = item.Descuento / 100;
            item.Regmod = regmod;
            EmpresaService servicio = new EmpresaService();
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
        //int miVariable = Int32 conversion a variable
        //    double var2 = Double.parse

        private void CargarDetalle()
        {
            dgvEmpresa.DataSource = servicio.Detalle();
            if (dgvEmpresa.RowCount > 0)
            {
                dgvEmpresa.Columns["id"].Visible = false;
                dgvEmpresa.Columns["estado"].Visible = false;
                dgvEmpresa.Columns["regmod"].Visible = false;
                dgvEmpresa.Columns["fecharegistro"].Visible = false;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvEmpresa.CurrentRow.Cells["id"].Value.ToString());
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
            idActual = Int32.Parse(dgvEmpresa.CurrentRow.Cells["id"].Value.ToString());
            txtNombre.Text = dgvEmpresa.CurrentRow.Cells["nombre"].Value.ToString();
            txtDescuento.Text = dgvEmpresa.CurrentRow.Cells["descuento"].Value.ToString();

        }
        private void Empresa_Load(object sender, EventArgs e)
        {
            dgvEmpresa.ClearSelection();
            dgvEmpresa.CurrentRow.Selected = false;
            txtBuscar.Focus();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEmpresa.RowCount > 0)
            {
                if (dgvEmpresa.CurrentRow.Selected == true)
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
            if (dgvEmpresa.RowCount > 0)
            {
                if (dgvEmpresa.CurrentRow.Selected == true)
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
        private static Empresa m_FormDefInstance;
        public static Empresa DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Empresa();
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