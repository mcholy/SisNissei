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
    public partial class InscripcionAlquiler : Form
    {
        private Validacion ItemValidacion = new Validacion();
        private InscripcionAlquilerEntity item = new InscripcionAlquilerEntity();
        private InscripcionAlquilerService servicio = new InscripcionAlquilerService();
        private DetalleInscripcionAlquilerService serviciodetalle = new DetalleInscripcionAlquilerService();
        private DetalleInscripcionAlquilerEntity itemdetalle = new DetalleInscripcionAlquilerEntity();

        private string nombreCliente = "";
        private int idCliente = 0;
        private int regmod = 0;
        private int idActual = 0;
        private int idActualDetalle = 0;
        private int regmoddetalle = 0;
        public InscripcionAlquiler()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            InsertarCodigo();
            Skin.AplicarSkinDGV(dgvInscripcionAlquiler);
            Skin.AplicarSkinDGV(dgvInscripcionAlquilerDetalle);
            CargarDetalle();
        }
        #region Singleton
        private static InscripcionAlquiler m_FormDefInstance;
        public static InscripcionAlquiler DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new InscripcionAlquiler();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion
        private void Limpiar()
        {
            InsertarCodigo();
            idActual = 0;
            idCliente = 0;
            txtCliente.Text = string.Empty;
            txtGarantia.Text = string.Empty;
            lblTotal.Text = string.Empty;
            sumatoria = 0;
            dtpHoraFin.ResetText();
            dtpHoraInicio.ResetText();
            LimpiarDetalle();

        }
        private void InsertarCodigo()
        {
            txtNombre.Text = new InscripcionAlquilerService().Codigo(item);
        }
        private void ListarAmbientes(int idActual)
        {
            cbAmbiente.DisplayMember = "Nombre";
            cbAmbiente.ValueMember = "Id";
            cbAmbiente.DataSource = new AmbienteService().Listar(idCliente);
        }

        private void InscripcionAlquiler_Load(object sender, EventArgs e)
        {
            dgvInscripcionAlquiler.ClearSelection();
            dgvInscripcionAlquiler.CurrentRow.Selected = false;
            dgvInscripcionAlquilerDetalle.ClearSelection();
            dgvInscripcionAlquilerDetalle.CurrentRow.Selected = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Se debe seleccionar al alumno antes de matricularlo");
            }
            else if (dtpHoraInicio.Value.Date > dtpHoraFin.Value.Date)
            {
                MessageBox.Show("La fecha y  hora de Inicio no puede ser mayor que la fecha y hora de fin de alquiler");
            }
            else
            {

                Guardar();
                regmod = 0;
            }
        }
        private void Guardar()
        {
            item.Id = idActual;
            item.Nombre = txtNombre.Text;
            item.Idcliente = idCliente;
            item.Horainicio = DateTime.Parse(dtpHoraInicio.Value.ToString());
            item.Horafin = DateTime.Parse(dtpHoraFin.Value.ToString());
            item.Garantia = double.Parse(txtGarantia.Text);
            item.Regmod = regmod;
            InscripcionAlquilerService servicio = new InscripcionAlquilerService();
            int respuesta = servicio.Guardar(item);
            if (respuesta == 1)
            {
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
            }
            else if (respuesta == 2)
            {
                MessageBox.Show("El registro se actualizó satisfactoriamente.");
            }
            else if (respuesta == 3)
            {
                MessageBox.Show("La Hora ingresada ya esta ocupada.");
            }
            Limpiar();
            CargarDetalle();
        }

        private void CargarDetalle()
        {
            dgvInscripcionAlquiler.DataSource = servicio.Detalle();

            if (dgvInscripcionAlquiler.RowCount > 0)
            {
                dgvInscripcionAlquiler.Columns["id"].Visible = false;
                dgvInscripcionAlquiler.Columns["estado"].Visible = false;
                dgvInscripcionAlquiler.Columns["idcliente"].Visible = false;

                dgvInscripcionAlquiler.Columns["regmod"].Visible = false;
                dgvInscripcionAlquiler.Columns["Horainicio"].Visible = false;
                dgvInscripcionAlquiler.Columns["Horafin"].Visible = false;
                dgvInscripcionAlquiler.Columns["nombre"].DisplayIndex = 1;

                dgvInscripcionAlquiler.ClearSelection();
            }
        }
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
            ListarAmbientes(idActual);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            CargarDetalleDetalle(idActual);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvInscripcionAlquiler.RowCount > 0)
            {
                if (dgvInscripcionAlquiler.CurrentRow.Selected == true)
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
            idActual = Int32.Parse(dgvInscripcionAlquiler.CurrentRow.Cells["id"].Value.ToString());
            idCliente = Int32.Parse(dgvInscripcionAlquiler.CurrentRow.Cells["idcliente"].Value.ToString());
            txtCliente.Text = dgvInscripcionAlquiler.CurrentRow.Cells["nombrecliente"].Value.ToString();
            txtGarantia.Text = dgvInscripcionAlquiler.CurrentRow.Cells["garantia"].Value.ToString();
            dtpHoraInicio.Value = DateTime.Parse(dgvInscripcionAlquiler.CurrentRow.Cells["fechainicioalquiler"].Value.ToString());
            dtpHoraFin.Value = DateTime.Parse(dgvInscripcionAlquiler.CurrentRow.Cells["fechafinalquiler"].Value.ToString());

            txtNombre.Text = dgvInscripcionAlquiler.CurrentRow.Cells["nombre"].Value.ToString();
            lblTotal.Text = string.Empty;
            sumatoria = 0;
            ListarAmbientes(idCliente);
            CargarDetalleDetalle(idActual);
        }
        private void LimpiarDetalle()
        {
            cbAmbiente.DataSource = new AmbienteService().Listar(idCliente);
            lblTotal.Text = string.Empty;
            sumatoria = 0;
        }

        private double sumatoria = 0;


        private void CargarDetalleDetalle(int
            idActual)
        {
            dgvInscripcionAlquilerDetalle.DataSource = serviciodetalle.Detalle(idActual);

            if (dgvInscripcionAlquilerDetalle.RowCount > 0)
            {

                dgvInscripcionAlquilerDetalle.Columns["estado"].Visible = false;
                dgvInscripcionAlquilerDetalle.Columns["regmoddetalle"].Visible = false;
                dgvInscripcionAlquilerDetalle.Columns["idambientes"].Visible = false;
                dgvInscripcionAlquilerDetalle.Columns["id"].Visible = false;
                dgvInscripcionAlquilerDetalle.Columns["idalquiler"].Visible = false;

                dgvInscripcionAlquilerDetalle.ClearSelection();
                foreach (DataGridViewRow row in dgvInscripcionAlquilerDetalle.Rows)
                {
                    sumatoria += Convert.ToDouble(row.Cells["Costos"].Value);
                    lblTotal.Text = Convert.ToString(sumatoria);
                }
            }
        }
        private void EliminarDetalle()
        {
            itemdetalle.Id = Int32.Parse(dgvInscripcionAlquilerDetalle.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = serviciodetalle.Eliminar(itemdetalle);
            if (respuesta == 1)
            {
                //Limpiar();
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
                CargarDetalleDetalle(idActual);
            }
        }

        private void GuardarDetalle()
        {
            itemdetalle.Id = idActualDetalle;
            itemdetalle.Idalquiler = idActual;
            itemdetalle.Idambientes = Int32.Parse(cbAmbiente.SelectedValue.ToString());
            itemdetalle.Regmoddetalle = regmoddetalle;
            DetalleInscripcionAlquilerService serviciodetalle = new DetalleInscripcionAlquilerService();
            int respuesta = serviciodetalle.Guardar(itemdetalle);
            if (respuesta == 1)
            {
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
            }
            else if (respuesta == 2)
            {
                MessageBox.Show("El registro se actualizó satisfactoriamente.");
            }
            LimpiarDetalle();
            CargarDetalleDetalle(idActual);
        }

        private void btnGuardarDetalle_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(idActual.ToString()) == 0)
            {
                MessageBox.Show("Se debe guardar el alquiler antes de seleccionar un Ambiente");
            }
            else if (txtCliente.Text == "")
            {
                MessageBox.Show("Se debe seleccionar un registro de alquiler antes de guardar un ambiente a alquilar");
            }
            else
            {
                GuardarDetalle();
                regmoddetalle = 0;

            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            EliminarDetalle();
        }
    }
}
