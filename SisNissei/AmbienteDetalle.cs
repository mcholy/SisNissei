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
    public partial class AmbienteDetalle : Form
    {
        private Validacion itemValidacion = new Validacion();
        private AmbienteDetalleEntity item = new AmbienteDetalleEntity();
        private AmbienteDetalleService servicio = new AmbienteDetalleService();
        private int regmod = 0;
        private int idActual = 0;
      
       

        public AmbienteDetalle()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            Skin.AplicarSkinDGV(dgvAmbienteDetalle);
            ListarAmbientes();
            ListarTipoCliente();
            ListarAmbienteDescripcion();
            CargarDetalle();

        }
        private void ListarAmbientes()
        {
            cbAmbiente.DisplayMember = "Nombre";
            cbAmbiente.ValueMember = "Id";
            cbAmbiente.DataSource = new AmbienteService().ListarenDetalle();
        }
        private void ListarAmbienteDescripcion()
        {
            cbAmbienteDescripcion.DisplayMember = "Nombre";
            cbAmbienteDescripcion.ValueMember = "Id";
            cbAmbienteDescripcion.DataSource = new AmbienteDescripcionService().Listar();
        }
        private void ListarTipoCliente()
        {
            cbTipoCliente.Items.Add("Publico");
            cbTipoCliente.Items.Add("Socio");
        }
        #region Singleton
        private static AmbienteDetalle m_FormDefInstance;
        public static AmbienteDetalle DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new AmbienteDetalle();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion
        private void LlenarControles()
        {
            idActual = Int32.Parse(dgvAmbienteDetalle.CurrentRow.Cells["id"].Value.ToString());
            cbAmbiente.SelectedValue = Int32.Parse(dgvAmbienteDetalle.CurrentRow.Cells["idambiente"].Value.ToString());
            cbTipoCliente.SelectedItem = dgvAmbienteDetalle.CurrentRow.Cells["nombretipocliente1"].Value.ToString();
            txtCosto.Text = dgvAmbienteDetalle.CurrentRow.Cells["costo"].Value.ToString();
            cbAmbienteDescripcion.SelectedValue = Int32.Parse(dgvAmbienteDetalle.CurrentRow.Cells["idambientedescripcion"].Value.ToString());
        }
        private void CargarDetalle()
        {
            dgvAmbienteDetalle.DataSource = servicio.Detalle();
            if (dgvAmbienteDetalle.RowCount > 0)
            {
                dgvAmbienteDetalle.Columns["id"].Visible = false;
                dgvAmbienteDetalle.Columns["estado"].Visible = false;
                dgvAmbienteDetalle.Columns["regmod"].Visible = false;
                dgvAmbienteDetalle.Columns["fecharegistro"].Visible = false;
                dgvAmbienteDetalle.Columns["nombre"].Visible=false;
                dgvAmbienteDetalle.Columns["idambiente"].Visible=false;
                dgvAmbienteDetalle.Columns["idambientedescripcion"].Visible = false;
                dgvAmbienteDetalle.Columns["Tipocliente1"].Visible=false;
                dgvAmbienteDetalle.Columns["nombreambientedescripcion"].DisplayIndex = 1;
                dgvAmbienteDetalle.Columns["nombreambiente"].DisplayIndex = 0;
                dgvAmbienteDetalle.Columns["nombretipocliente1"].DisplayIndex = 2;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            item.Id = Int32.Parse(dgvAmbienteDetalle.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = servicio.Eliminar(item);
            if (respuesta == 1)
            {
                MessageBox.Show("El registro se elimino satisfactoriamente.");
                CargarDetalle();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            //item.idtipoemeplado = icbsexo.selectedvalue;
            item.Id = idActual;
            item.IdAmbiente = Int32.Parse(cbAmbiente.SelectedValue.ToString());
            item.TipoCliente1 = cbTipoCliente.Text == "Publico" ? false : true;
            item.Costo = Int32.Parse(txtCosto.Text);
            item.IdAmbienteDescripcion = Int32.Parse(cbAmbienteDescripcion.SelectedValue.ToString());
            item.Regmod = regmod;
            AmbienteDetalleService servicio = new AmbienteDetalleService();
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
            txtCosto.Text = string.Empty;
            cbAmbienteDescripcion.SelectedValue = 0;
            cbAmbiente.SelectedValue = 0;
            cbTipoCliente.SelectedValue = 0;           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            {
                if (dgvAmbienteDetalle.RowCount > 0)
                {
                    if (dgvAmbienteDetalle.CurrentRow.Selected == true)
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

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AmbienteDetalle_Load(object sender, EventArgs e)
        {
            dgvAmbienteDetalle.ClearSelection();
            dgvAmbienteDetalle.CurrentRow.Selected = false;
            txtBuscar.Focus();
        }


    }
}
