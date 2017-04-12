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
    public partial class Egresos : Form
    {
        #region Propiedades
        private Validacion itemValidacion = new Validacion();
        private string nombreEmpleado = "";
        private int idEmpleado = 0;
        private int idActual = 0;
        private int regmod = 0;
        private EgresoEntity item = new EgresoEntity();
        private EgresoService servicio = new EgresoService();
        #endregion
        public Egresos()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            Skin.AplicarSkinDGV(dgvEgreso);
        }

        private void ListarTipoEgreso()
        {
            cbTipoEgreso.DisplayMember = "Nombre";
            cbTipoEgreso.ValueMember = "Id";
            cbTipoEgreso.DataSource = new TipoEgresoService().ListarTipoPago();
        }
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            DialogEmpleado dialogEmpleado = new DialogEmpleado();
            DialogResult resultado = dialogEmpleado.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                nombreEmpleado = dialogEmpleado.CargarNombre();
                idEmpleado = dialogEmpleado.CargarId();

            }
            txtEmpleado.Text = nombreEmpleado;
        }

        #region Singleton
        private static Egresos m_FormDefInstance;
        public static Egresos DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Egresos();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion

        private void Guardar()
        {
            item.Id = idActual;
            item.Nombre = txtRecibo.Text;
            item.Idempleado = idEmpleado;
            item.Idtipoegreso = Int32.Parse(cbTipoEgreso.SelectedValue.ToString());
            item.Detalle = txtDetalle.Text;
            item.Monto = Double.Parse(txtMonto.Text);
            item.Regmod = regmod;
            EgresoService servicio = new EgresoService();
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
        private void Limpiar()
        {
            txtRecibo.Text = string.Empty;
            cbTipoEgreso.SelectedValue = 0;
            txtEmpleado.Text = string.Empty;
            idEmpleado = 0;
            nombreEmpleado = "";
            txtRecibo.Text = string.Empty;
            txtDetalle.Text = string.Empty;
            txtMonto.Text = string.Empty;


        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void CargarDetalle(string filterNombre = "")
        {

            dgvEgreso.DataSource = filterNombre == "" ? servicio.Detalle() : servicio.Detalle().Where(x => x.Detalle.ToUpper().Contains(filterNombre.ToUpper())).ToList();
            if (dgvEgreso.RowCount > 0)
            {
                dgvEgreso.Columns["id"].Visible = false;
                dgvEgreso.Columns["regmod"].Visible = false;
                dgvEgreso.Columns["fecharegistro"].Visible = false;
                dgvEgreso.Columns["estado"].Visible = false;
                dgvEgreso.Columns["idempleado"].Visible = false;
                dgvEgreso.Columns["idusuario"].Visible = false;
                dgvEgreso.Columns["idtipoegreso"].Visible = false;
                dgvEgreso.Columns["tipoegreso"].DisplayIndex = 0;
                dgvEgreso.Columns["tipoegreso"].HeaderText = "Tipo Egreso";
                dgvEgreso.Columns["nombre"].DisplayIndex = 1;
                dgvEgreso.Columns["nombre"].HeaderText = "Recibo Nro.";
                dgvEgreso.Columns["detalle"].DisplayIndex = 2;
                dgvEgreso.Columns["detalle"].HeaderText = "Detalle";

                dgvEgreso.ClearSelection();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEgreso.RowCount > 0)
            {
                if (dgvEgreso.CurrentRow.Selected == true)
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
        private void LlenarControles()
        {
            idActual = Int32.Parse(dgvEgreso.CurrentRow.Cells["id"].Value.ToString());
            idEmpleado = Int32.Parse(dgvEgreso.CurrentRow.Cells["idempleado"].Value.ToString());
            txtEmpleado.Text = dgvEgreso.CurrentRow.Cells["nombreempleado"].Value.ToString();
            cbTipoEgreso.SelectedValue = Int32.Parse(dgvEgreso.CurrentRow.Cells["idtipoegreso"].Value.ToString());
            txtRecibo.Text = dgvEgreso.CurrentRow.Cells["nombre"].Value.ToString();
            txtDetalle.Text = dgvEgreso.CurrentRow.Cells["detalle"].Value.ToString();
            txtMonto.Text = dgvEgreso.CurrentRow.Cells["monto"].Value.ToString();
        }

        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvEgreso.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = servicio.Eliminar(item);
            if (respuesta == 1)
            {
                //Limpiar();
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
                CargarDetalle();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEgreso.RowCount > 0)
            {
                if (dgvEgreso.CurrentRow.Selected == true)
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

        private void Egresos_Load(object sender, EventArgs e)
        {
            ListarTipoEgreso();
            CargarDetalle();
            dgvEgreso.ClearSelection();
            dgvEgreso.CurrentRow.Selected = false;
            txtBuscar.Focus();
        }
    }
}
