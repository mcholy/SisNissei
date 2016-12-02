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
            CargarDetalle();

        }
        private void ListarAmbientes()
        {
            cbAmbiente.DisplayMember = "Nombre";
            cbAmbiente.ValueMember = "Id";
            cbAmbiente.DataSource = new AmbienteService().ListarenDetalle();
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
       
        private void CargarDetalle()
        {
            dgvAmbienteDetalle.DataSource = servicio.Detalle();
            if (dgvAmbienteDetalle.RowCount > 0)
            {
                dgvAmbienteDetalle.Columns["id"].Visible = false;
                dgvAmbienteDetalle.Columns["estado"].Visible = false;
                dgvAmbienteDetalle.Columns["regmod"].Visible = false;
                dgvAmbienteDetalle.Columns["fecharegistro"].Visible = false;
                dgvAmbienteDetalle.Columns["nombre"].DisplayIndex = 0;
                dgvAmbienteDetalle.Columns["nombre"].HeaderText = "Nombre";
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
        private void Ambiente_Load(object sender, EventArgs e)
        {
            
            dgvAmbienteDetalle.ClearSelection();
            dgvAmbienteDetalle.CurrentRow.Selected = false;
            txtBuscar.Focus();
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
            item.Derechocorcho = Int32.Parse(txtDerechoCorcho.Text);
            item.Limpieza = Int32.Parse(txtLimpieza.Text);
            item.Garantia = Int32.Parse(txtGarantiaLocal.Text);
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
            txtDerechoCorcho.Text = string.Empty;
            txtLimpieza.Text = string.Empty;
            txtGarantiaLocal.Text = string.Empty;
            cbAmbiente.SelectedValue = 0;
            cbTipoCliente.SelectedValue = 0;           
        }


    }
}
