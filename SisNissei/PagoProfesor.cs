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
    public partial class PagoProfesor : Form
    {
        private string _nombreEmpleado = "";
        private int _id_Empleado = 0;
        private string _monto = "";
        private int idActual = 0;
        private int regmod = 0;
        private EgresoService servicio = new EgresoService();
        private EgresoEntity item = new EgresoEntity();

        public PagoProfesor(int id_Empleado,string nombreEmpleado,string monto)
        {
            InitializeComponent();
            Skin.AplicarSkinDialog(this);
            Skin.AplicarSkinDGV(dgvListadoPagos);
            _nombreEmpleado = nombreEmpleado;
            _id_Empleado = id_Empleado;
            _monto = monto;
            txtEmpleado.Text = _nombreEmpleado;
            txtMonto.Text = _monto;
            CargarDetalle();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            item.Id = idActual;
            item.Nombre = txtNroRecibo.Text;
            item.Idempleado = _id_Empleado;
            item.Idtipoegreso = 8;
            item.Detalle = txtDetalle.Text;
            item.Monto = Decimal.Parse(txtMonto.Text);
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
            Close();
        }
        private void CargarDetalle(string filterNombre = "")
        {

            dgvListadoPagos.DataSource = filterNombre == "" ? servicio.Detalle(8) : servicio.Detalle(8).Where(x => x.Detalle.ToUpper().Contains(filterNombre.ToUpper())).ToList();
            if (dgvListadoPagos.RowCount > 0)
            {
                dgvListadoPagos.Columns["id"].Visible = false;
                dgvListadoPagos.Columns["regmod"].Visible = false;
                dgvListadoPagos.Columns["fecharegistro"].Visible = false;
                dgvListadoPagos.Columns["estado"].Visible = false;
                dgvListadoPagos.Columns["idempleado"].Visible = false;
                dgvListadoPagos.Columns["idusuario"].Visible = false;
                dgvListadoPagos.Columns["idtipoegreso"].Visible = false;
                dgvListadoPagos.Columns["tipoegreso"].DisplayIndex = 0;
                dgvListadoPagos.Columns["tipoegreso"].HeaderText = "Tipo Egreso";
                dgvListadoPagos.Columns["nombre"].DisplayIndex = 1;
                dgvListadoPagos.Columns["nombre"].HeaderText = "Recibo Nro.";
                dgvListadoPagos.Columns["detalle"].DisplayIndex = 2;
                dgvListadoPagos.Columns["detalle"].HeaderText = "Detalle";

                dgvListadoPagos.ClearSelection();
            }
        }
    }
}
