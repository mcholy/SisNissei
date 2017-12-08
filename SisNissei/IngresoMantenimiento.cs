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

    public partial class IngresoMantenimiento : Form
    {
        private IngresoEntity item = new IngresoEntity();
        ReporteIngresoEntity item2 = new ReporteIngresoEntity();
        private IngresoService servicio = new IngresoService();
     
        public IngresoMantenimiento()
        {
            InitializeComponent();
           
        }

        private void CargarDetalle()
        {
            dgvRecibos.DataSource = servicio.Detalle();
            if (dgvRecibos.RowCount > 0)
            {
                dgvRecibos.Columns["dni"].Visible = false;
                dgvRecibos.Columns["direccion"].Visible = false;
                dgvRecibos.Columns["idcliente"].Visible = false;
                dgvRecibos.Columns["idtipoingreso"].Visible = false;
                dgvRecibos.Columns["tipocomprobante"].Visible = false;
                dgvRecibos.Columns["idfactura"].Visible = false;
                dgvRecibos.Columns["tipocomprobante"].Visible = false;
                dgvRecibos.Columns["estado"].Visible = false;
                dgvRecibos.Columns["regmod"].Visible = false;
                dgvRecibos.Columns["id"].Visible = false;
                dgvRecibos.Columns["nombrerecibo"].DisplayIndex = 0;
                //dgvRecibos.Columns["nombrecliente"].DisplayIndex = 1;
                //dgvRecibos.Columns["nombreoperaciondetalle"].DisplayIndex = 2;
                //dgvRecibos.Columns["montototal"].DisplayIndex = 3;
                //dgvRecibos.Columns["fecharegistro"].DisplayIndex = 5;
                dgvRecibos.ClearSelection();
            }
        }

        private void IngresoMantenimiento_Load(object sender, EventArgs e)
        {
            CargarDetalle();
            Skin.AplicarSkinDGV(dgvRecibos);
        }
        #region Singleton
        private static IngresoMantenimiento m_FormDefInstance;
        public static IngresoMantenimiento DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new IngresoMantenimiento();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRecibos.RowCount > 0)
            {
                if (dgvRecibos.CurrentRow.Selected == true)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar este Rebcibo?", "SisNisei",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Eliminar();
                    }
                }
                else
                {
                    MessageBox.Show("No hay ningún recibo seleccionado.");
                }
            }
        }
        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvRecibos.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = servicio.Eliminar(item);
            if (respuesta == 1)
            {
                //Limpiar();
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
                CargarDetalle();
            }
        }

        private void btnFicha_Click(object sender, EventArgs e)
        {
            if (dgvRecibos.RowCount > 0)
            {
                if (dgvRecibos.CurrentRow.Selected == true)
                {
                    if (MessageBox.Show("¿Esta seguro de imprimir este registro?", "SisNisei", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        imprimir();
                    }
                }
                else

                    MessageBox.Show("No hay ni un registro seleccionado.");
            }
        }
        private void imprimir()
        {
            item2.Id = Int32.Parse(dgvRecibos.CurrentRow.Cells["id"].Value.ToString());

            DatosIngreso dai = servicio.ReporteIngreso(item2);
            BoletaReporte rpt = new BoletaReporte();
            rpt.SetDataSource(dai);
            BoletaReporteFormulario frmReporte = new BoletaReporteFormulario();
            frmReporte.rp_Boleta.ReportSource = rpt;
            frmReporte.ShowDialog();

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string busqueda = string.Empty;
            busqueda = txtNombreCliente.Text.Trim();
            CargarDetalle(filterNombre: busqueda);
        }
        private void CargarDetalle(string filterNombre = "")
        {
            //(BUSCAR) LINEA ACTUALIZADA
            dgvRecibos.DataSource = filterNombre == "" ? servicio.Detalle() : servicio.Detalle().Where(x => x.Nombreusuario.ToUpper().Contains(filterNombre.ToUpper())).ToList();
            if (dgvRecibos.RowCount > 0)
            {
                dgvRecibos.Columns["id"].Visible = false;
                dgvRecibos.Columns["nombrerecibo"].DisplayIndex = 0;
                dgvRecibos.Columns["estado"].Visible = false;
                dgvRecibos.Columns["regmod"].Visible = false;
            }
        }
    }
}
