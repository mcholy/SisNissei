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
    public partial class InscripcionSocio : Form
    {
        #region Propiedades
        private Validacion itemValidacion = new Validacion();
        private int idCliente = 0;
        private int idConyugue = 0;
        private int idPatrocinador = 0;
        private int idActual = 0;
        private string nombreCliente = "";
        private string nombreConyugue = "";
        private string nombrePatrocinador = "";
        private int regmod = 0;
        private InscripcionSocioEntity item = new InscripcionSocioEntity();
        private InscripcionSocioService servicio = new InscripcionSocioService();
        #endregion
        public InscripcionSocio()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
            Skin.AplicarSkinDGV(dgvInscripcionSocio);
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtConyugue.Text = string.Empty;
            txtPatrocinador.Text = string.Empty;
            txtTrabajo.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtHijosMayores.Text = string.Empty;
            txtHijosMenores.Text = string.Empty;
            txtFamiliarJapon.Text = string.Empty;
            txtFamiliarEeuu.Text = string.Empty;
            txtFamiliarItalia.Text = string.Empty;
            txtFamiliarOtros.Text = string.Empty;
        }
        private void Guardar()
        {
            item.Id = idActual;
            item.Nombre = txtNombre.Text;
            item.Idcliente = idCliente;
            item.Idconyugue = idConyugue;
            item.Idpatrocinador = idPatrocinador;
            item.Trabajo = txtTrabajo.Text;
            item.Cargo = txtCargo.Text;
            item.Hijosmayores = Int32.Parse(txtHijosMayores.Text);
            item.Hijosmenores = Int32.Parse(txtHijosMenores.Text);
            item.Familiarjapon = Int32.Parse(txtFamiliarJapon.Text);
            item.Familiareeuu = Int32.Parse(txtFamiliarEeuu.Text);
            item.Familiaritalia = Int32.Parse(txtFamiliarItalia.Text);
            item.Familiarotros = Int32.Parse(txtFamiliarOtros.Text);
            item.Regmod = regmod;
            InscripcionSocioService servicio = new InscripcionSocioService();
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

        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvInscripcionSocio.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = servicio.Eliminar(item);
            if (respuesta == 1)
            {
                //Limpiar();
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
                CargarDetalle();
            }
        }
        private void CargarDetalle()
        {
            dgvInscripcionSocio.DataSource = servicio.Detalle();

            if (dgvInscripcionSocio.RowCount > 0)
            {
                dgvInscripcionSocio.Columns["id"].Visible = false;
                dgvInscripcionSocio.Columns["estado"].Visible = false;
                dgvInscripcionSocio.Columns["idcliente"].Visible = false;
                dgvInscripcionSocio.Columns["idconyugue"].Visible = false;
                dgvInscripcionSocio.Columns["idpatrocinador"].Visible = false;
                dgvInscripcionSocio.Columns["regmod"].Visible = false;
                dgvInscripcionSocio.Columns["nombre"].DisplayIndex = 1;
                dgvInscripcionSocio.Columns["nombrecliente"].DisplayIndex = 2;
                dgvInscripcionSocio.Columns["nombreconyugue"].DisplayIndex = 3;
                dgvInscripcionSocio.Columns["nombrepatrocinador"].DisplayIndex = 4;
                dgvInscripcionSocio.Columns["trabajo"].DisplayIndex = 5;
                dgvInscripcionSocio.Columns["cargo"].DisplayIndex = 6;
                dgvInscripcionSocio.Columns["hijosmayores"].DisplayIndex = 7;
                dgvInscripcionSocio.Columns["hijosmenores"].DisplayIndex = 8;
                dgvInscripcionSocio.Columns["familiarjapon"].DisplayIndex = 9;
                dgvInscripcionSocio.Columns["familiareeuu"].DisplayIndex = 10;
                dgvInscripcionSocio.Columns["familiaritalia"].DisplayIndex = 11;
                dgvInscripcionSocio.Columns["familiarotros"].DisplayIndex = 12;
                dgvInscripcionSocio.ClearSelection();
            }
        }

        #region Singleton
        private static InscripcionSocio m_FormDefInstance;
        public static InscripcionSocio DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new InscripcionSocio();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            DialogCliente dialogCliente = new DialogCliente();
            DialogResult resultado = dialogCliente.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                nombreCliente = dialogCliente.CargarNombre();
                idCliente = dialogCliente.CargarId();

            }
            txtCliente.Text = nombreCliente;
        }

        private void btnBuscarConyugue_Click(object sender, EventArgs e)
        {
            DialogCliente dialogCliente = new DialogCliente();
            DialogResult resultado = dialogCliente.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                nombreCliente = dialogCliente.CargarNombre();
                idCliente = dialogCliente.CargarId();

            }
            txtCliente.Text = nombreCliente;
        }

        private void btnBuscarPatrocinador_Click(object sender, EventArgs e)
        {
            DialogPatrocinador dialogPatrocinador = new DialogPatrocinador();
            DialogResult resultado = dialogPatrocinador.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                nombrePatrocinador = dialogPatrocinador.CargarNombre();
                idPatrocinador = dialogPatrocinador.CargarId();

            }
            txtCliente.Text = nombreCliente;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void InscripcionSocio_Load(object sender, EventArgs e)
        {
            dgvInscripcionSocio.ClearSelection();
            dgvInscripcionSocio.CurrentRow.Selected = false;
            txtBuscar.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInscripcionSocio.RowCount > 0)
            {
                if (dgvInscripcionSocio.CurrentRow.Selected == true)
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
        private void LlenarControles()
        {
            idActual = Int32.Parse(dgvInscripcionSocio.CurrentRow.Cells["id"].Value.ToString());
            idCliente = Int32.Parse(dgvInscripcionSocio.CurrentRow.Cells["idcliente"].Value.ToString());
            idConyugue = Int32.Parse(dgvInscripcionSocio.CurrentRow.Cells["idconyugue"].Value.ToString());
            idPatrocinador = Int32.Parse(dgvInscripcionSocio.CurrentRow.Cells["idpatrocinador"].Value.ToString());
            txtNombre.Text = dgvInscripcionSocio.CurrentRow.Cells["nombre"].Value.ToString();
            txtCliente.Text = dgvInscripcionSocio.CurrentRow.Cells["nombrecliente"].Value.ToString();
            txtConyugue.Text = dgvInscripcionSocio.CurrentRow.Cells["nombreconyugue"].Value.ToString();
            txtPatrocinador.Text = dgvInscripcionSocio.CurrentRow.Cells["nombrepatrocinador"].Value.ToString();
            txtTrabajo.Text = dgvInscripcionSocio.CurrentRow.Cells["trabajo"].Value.ToString();
            txtCargo.Text = dgvInscripcionSocio.CurrentRow.Cells["cargo"].Value.ToString();
            txtHijosMayores.Text = dgvInscripcionSocio.CurrentRow.Cells["hijosmayores"].Value.ToString();
            txtHijosMenores.Text = dgvInscripcionSocio.CurrentRow.Cells["hijosmenores"].Value.ToString();
            txtFamiliarJapon.Text = dgvInscripcionSocio.CurrentRow.Cells["familiarjapon"].Value.ToString();
            txtFamiliarEeuu.Text = dgvInscripcionSocio.CurrentRow.Cells["familiareeuu"].Value.ToString();
            txtFamiliarItalia.Text = dgvInscripcionSocio.CurrentRow.Cells["familiaritalia"].Value.ToString();
            txtFamiliarOtros.Text = dgvInscripcionSocio.CurrentRow.Cells["familiarotros"].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvInscripcionSocio.RowCount > 0)
            {
                if (dgvInscripcionSocio.CurrentRow.Selected == true)
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
