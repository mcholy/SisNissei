using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models.Services;
using Entities;
using Models;

namespace SisNissei
{
    public partial class Ingreso : Form
    {
        private IngresoEntity item = new IngresoEntity();

        private string nombreCliente = "";
        private int idCliente = 0;
        private int nropago = 0;
        private int idTipoIngreso = 0;
        private IngresoService servicio = new IngresoService();
        public Ingreso()
        {
            InitializeComponent();
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            ListarTipoIngreso();
        }
        #region Singleton
        private static Ingreso m_FormDefInstance;
        public static Ingreso DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Ingreso();
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
            DialogCliente DialogCliente = new DialogCliente();
            DialogResult resultado = DialogCliente.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                nombreCliente = DialogCliente.CargarNombre();
                idCliente = DialogCliente.CargarId();
            }
            txtNombreCliente.Text = nombreCliente;
            if (idCliente > 0)
            {
                DatosFac(idCliente);
            }
        }
        private void DatosFac(int idcliente)
        {
            item.Idcliente = idcliente;

          
            string direccion = servicio.DatosFacDir(item);
            string dni = servicio.DatosFacDni(item);
            txtDireccion.Text = direccion;
            txtDni.Text = dni;

        }
        private void ListarTipoIngreso()
        {
            cbTipoIngreso.DisplayMember = "Nombre";
            cbTipoIngreso.ValueMember = "Id";
            cbTipoIngreso.DataSource = new IngresoService().ListarTipoIngreso();
        }
        private void total()
        {
            //Variable donde almacenaremos el resultado de la sumatoria.
            double total = 0;
            //Método con el que recorreremos todas las filas de nuestro Datagridview
            foreach (DataGridViewRow row in dgvPagosPendientes.Rows)
            {
                //Aquí seleccionaremos la columna que contiene los datos numericos.
                total += Convert.ToDouble(row.Cells["Monto"].Value);
            }
            //Por ultimo asignamos el resultado a el texto de nuestro Label
            lblTotal.Text = Convert.ToString(total);
        }
        private void btnPagoPendiente_Click(object sender, EventArgs e)
        {
            idTipoIngreso = Int32.Parse(cbTipoIngreso.SelectedValue.ToString());
            if (idCliente > 0)
            {
                CargarPagopendiente(idCliente, idTipoIngreso);
                total();
            }
        }


        private void CargarPagopendiente(int idCliente, int idTipoIngreso)
        {
            nropago = nropago + 1;
        dgvPagosPendientes.DataSource=servicio.PagosPendientes(idCliente, idTipoIngreso,nropago);
        if (dgvPagosPendientes.RowCount > 0)
        {
            dgvPagosPendientes.Columns["estado"].Visible = false;
            dgvPagosPendientes.Columns["nombreusuario"].Visible = false;
            dgvPagosPendientes.Columns["dni"].Visible = false;
            dgvPagosPendientes.Columns["direccion"].Visible = false;
            dgvPagosPendientes.Columns["idcliente"].Visible = false;
            dgvPagosPendientes.Columns["idtipoingreso"].Visible = false;
            dgvPagosPendientes.Columns["tipocomprobante"].Visible = false;
            dgvPagosPendientes.Columns["numerocomprobante"].Visible = false;
            dgvPagosPendientes.Columns["id"].Visible = false;
            dgvPagosPendientes.Columns["fecharegistro"].Visible = false;
            dgvPagosPendientes.Columns["regmod"].Visible = false;
            dgvPagosPendientes.ClearSelection();
        }
        }

    }
}
