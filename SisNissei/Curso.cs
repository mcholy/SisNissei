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
    public partial class Curso : Form
    {
        Validacion itemValidacion = new Validacion();
        private int idEmpleado = 0;
        private string nombreEmpleado = "";
        CursoEntity item = new CursoEntity();
        CursoService servicio = new CursoService();
        public Curso()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }
        
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtEmpleado.Text = string.Empty;
            txtInicial.Text = string.Empty;
            txtMensualidad.Text = string.Empty;
        }
        private void Guardar()
        {
            item.Nombre = txtNombre.Text;
            item.Idempleado = idEmpleado;
            item.Inicial = Double.Parse(txtInicial.Text);
            item.Mensualidad = Double.Parse(txtMensualidad.Text);
            //item.idtipoemeplado = icbsexo.selectedvalue;
            CursoService servicio = new CursoService();
            int respuesta = servicio.Guardar(item);
            if (respuesta == 1)
            {
                Limpiar();
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
                CargarDetalle();
            }
        }
        private void CargarDetalle()
        {
            dgvCurso.DataSource = servicio.Detalle();
            if (dgvCurso.RowCount > 0)
            {
                dgvCurso.Columns["id"].Visible = false;
                dgvCurso.Columns["estado"].Visible = false;
                dgvCurso.Columns["idempleado"].Visible = false;
                
            }
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
