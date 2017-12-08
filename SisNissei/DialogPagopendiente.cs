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
using Models;
using System.Data.SqlClient;
namespace SisNissei
{
    public partial class DialogPagopendiente : Form
    {
        private Validacion itemValidacion = new Validacion();
        private IngresoEntity item = new IngresoEntity();
        ReporteIngresoEntity item2 = new ReporteIngresoEntity();
        private ResultadoEntity resultado;
        private string _Nombre = "";
        private int _id = 0;
        private double _monto = 0;
        private int id_adelanto = 0;
        private IngresoService servicio = new IngresoService();

        public DialogPagopendiente(int idpagopendiente, string nombre, string monto)
        {
            itemValidacion.Puntuacion();
            InitializeComponent();
            Skin.AplicarSkinDialog(this);
            _id = idpagopendiente;
            _Nombre = nombre;
            _monto = Double.Parse(monto.ToString());
            txtMonto.Text = _monto.ToString();
            txtNombre.Text = _Nombre;
        }

        private void Guadar()
        {
            resultado = new ResultadoEntity();
            item = new IngresoEntity();
            item.Id = _id;
            item.Monto = Double.Parse(txtMonto.Text);
            item.Nombre = txtNombre.Text;
            resultado = servicio.GuardarPagoPendiente(item);
            this.DialogResult = DialogResult.OK;
            this.Close();


        }


        private void Adelanto()
        {
            resultado = new ResultadoEntity();
            item = new IngresoEntity();
            item.Id = _id;
            item.Monto = Double.Parse(txtMonto.Text);
            item.Nombre = txtNombre.Text;
            resultado = servicio.GuardarAdelanto(item);
            id_adelanto = resultado.Id;
            if (Int32.Parse(resultado.Respuesta) == 1)
            {
                MessageBox.Show("Se guardo adelanto, aceptar para imprimir boleta.");
                imprimir();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
                
            else if (Int32.Parse(resultado.Respuesta) == 2)
            {
                MessageBox.Show("El adelanto no puede ser mayor al monto total.");
            }

            
            


        }
        private void imprimir()
        {
            item2.Id = id_adelanto;

            DatosIngreso dai = servicio.ReporteIngreso(item2);
            BoletaReporte rpt = new BoletaReporte();
            rpt.SetDataSource(dai);
            BoletaReporteFormulario frmReporte = new BoletaReporteFormulario();
            frmReporte.rp_Boleta.ReportSource = rpt;
            frmReporte.ShowDialog();

        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloDecimal(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guadar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void Eliminar()
        {

            resultado = new ResultadoEntity();
            item = new IngresoEntity();
            item.Id = _id;
            resultado = servicio.EliminarPagoPendiente(item);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_acuenta_Click(object sender, EventArgs e)
        {
            Adelanto();
        }
    }
}
