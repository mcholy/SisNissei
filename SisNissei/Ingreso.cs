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
using SisNissei.Template;
using System.Data.SqlClient;


namespace SisNissei
{
    public partial class Ingreso : Form
    {
        private IngresoEntity item = new IngresoEntity();
        ReporteIngresoEntity item2 = new ReporteIngresoEntity();
        private ResultadoEntity resultado;
        private string nombreCliente = "";
        private int idCliente = 0;
        private int nropago = 0;
        private int idTipoIngreso = 0;
        private int idCurso = 0;
        private int idActual = 0;
        private IngresoService servicio = new IngresoService();

        public Ingreso()
        {

            InitializeComponent();
            InsertarCodigo();
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            ListarTipoIngreso();
            Skin.AplicarSkinDGV(dgvPagosPendientes);
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
           
            InsertarCodigo();
            idTipoIngreso = Int32.Parse(cbTipoIngreso.SelectedValue.ToString());

            DialogCliente DialogCliente = new DialogCliente(idTipoIngreso);
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
            nropago = 0;
            if (idTipoIngreso == 2)
            {
                ListarPagoPendiente(idCliente);
                lblCurso.Visible = true;
                cbCurso.Visible = true;
            }
            else
            {
                lblCurso.Visible = false;
                cbCurso.Visible = false;
            }
        }
        private void InsertarCodigo()
        {
            txtNombre.Text = new IngresoService().Codigo(item);
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
        private void limpiar()
        {
            nropago = 0;
            idCliente = 0;
            idTipoIngreso = 0;
            txtNombreCliente.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            idCliente = 0;
            cbCurso.SelectedValue = 0;
            cbTipoIngreso.SelectedValue = 0;
            nropago = 0;
            lblTotal.Text = string.Empty;

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
            if (idCliente > 0)
            {
                nropago = nropago + 1;
                idTipoIngreso = Int32.Parse(cbTipoIngreso.SelectedValue.ToString());
                idCurso = Int32.Parse(cbCurso.SelectedValue.ToString());


                CargarPagopendiente(idCliente, idTipoIngreso, idCurso);
                total();
            }
            else
            {
                MessageBox.Show("Se debe de elegir a un cliente para buscar su pago");
            }
        }


        private void CargarPagopendiente(int idCliente, int idTipoIngreso, int idCurso)
        {

            dgvPagosPendientes.DataSource = servicio.PagosPendientes(idCliente, idTipoIngreso, nropago, idCurso);
            if (dgvPagosPendientes.RowCount > 0)
            {
                dgvPagosPendientes.Columns["estado"].Visible = false;
                dgvPagosPendientes.Columns["nombreusuario"].Visible = false;
                dgvPagosPendientes.Columns["dni"].Visible = false;
                dgvPagosPendientes.Columns["direccion"].Visible = false;
                dgvPagosPendientes.Columns["idcliente"].Visible = false;
                dgvPagosPendientes.Columns["idtipoingreso"].Visible = false;
                dgvPagosPendientes.Columns["tipocomprobante"].Visible = false;
                dgvPagosPendientes.Columns["id"].Visible = false;
                dgvPagosPendientes.Columns["fecharegistro"].Visible = false;
                dgvPagosPendientes.Columns["regmod"].Visible = false;
                dgvPagosPendientes.Columns["idfactura"].Visible = false;
                dgvPagosPendientes.ClearSelection();
            }
        }
        private void ListarPagoPendiente(int idCliente)
        {
            cbCurso.DisplayMember = "Nombre";
            cbCurso.ValueMember = "Id";
            cbCurso.DataSource = new CursoService().ListarPagoPendiente(idCliente);
        }
        private void cbTipoIngreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTipoIngreso = Int32.Parse(cbTipoIngreso.SelectedValue.ToString());
            if (idTipoIngreso == 2)
            {
                ListarPagoPendiente(idCliente);
                lblCurso.Visible = true;
                cbCurso.Visible = true;
            }
            else
            {
                lblCurso.Visible = false;
                cbCurso.Visible = false;
            }
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            nropago = 0;
        }
        private void imprimirboleta()
        {
            item2.Id = item.Idfactura;

            DatosIngreso dai = servicio.ReporteIngreso(item2);
            BoletaReporte rpt = new BoletaReporte();
            rpt.SetDataSource(dai);
            BoletaReporteFormulario frmReporte = new BoletaReporteFormulario();
            frmReporte.rp_Boleta.ReportSource = rpt;
            frmReporte.ShowDialog();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Guardar();

        }
        private void Guardar()
        {
            resultado = new ResultadoEntity();
            item = new IngresoEntity();
            if (dgvPagosPendientes.RowCount > 0)
            {

                item.Idcliente = idCliente;
                item.Nombre = txtNombre.Text;
                item.Tipocomprobante = rdbBoleta.Checked ? 1 : 2;
                item.Monto = Double.Parse(lblTotal.Text.ToString());
                resultado = servicio.Guardar(item);
                item = new IngresoEntity();
                item.Idfactura = resultado.Id;

                foreach (DataGridViewRow fila in dgvPagosPendientes.Rows)
                {
                    //Accediendo por el nombre de la columna

                    item.Id = Int32.Parse(fila.Cells["ID"].Value.ToString());
                    item.Nombre = fila.Cells["Nombre"].Value.ToString();
                    //Accediendo con el indice de la columna
                    //item.Hora=fila.Cells[1].Value.ToString();
                    resultado = servicio.GuardarDetalle(item);
                }

                if (Int32.Parse(resultado.Respuesta) == 1)
                {
                    MessageBox.Show("Se registro el pago correctamente.");
                }
                else if (Int32.Parse(resultado.Respuesta) == 2)
                {
                    MessageBox.Show("El registro se actualizó satisfactoriamente.");
                }
                imprimirboleta();
                nropago = 0;
                CargarPagopendiente(idCliente, idTipoIngreso, idCurso);
                limpiar();
                InsertarCodigo();
            }
        }

        private void dgvPagosPendientes_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nropago == 0)
            {

            }
            else
            {
                nropago = nropago - 1;
                CargarPagopendiente(idCliente, idTipoIngreso, idCurso);
                total();
            }
        }
    }
}
