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
        #region Propiedades
        private Validacion itemValidacion = new Validacion();
        private int idEmpleado = 0;
        private int idActual = 0;
        private string nombreEmpleado = "";
        private int regmod = 0;
        private CursoEntity item = new CursoEntity();
        private CursoService servicio = new CursoService();
        #endregion

        public Curso()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
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
            item.Id = idActual;
            item.Nombre = txtNombre.Text;
            item.Idempleado = idEmpleado;
            item.Inicial = Double.Parse(txtInicial.Text);
            item.Mensualidad = Double.Parse(txtMensualidad.Text);
            item.Regmod = regmod;
            CursoService servicio = new CursoService();
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
            item.Id = Int32.Parse(dgvCurso.CurrentRow.Cells["id"].Value.ToString());
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
            dgvCurso.DataSource = servicio.Detalle();

            if (dgvCurso.RowCount > 0)
            {
                dgvCurso.Columns["id"].Visible = false;
                dgvCurso.Columns["estado"].Visible = false;
                dgvCurso.Columns["idempleado"].Visible = false;
                dgvCurso.Columns["regmod"].Visible = false;
                dgvCurso.Columns["nombre"].DisplayIndex = 1;
                dgvCurso.ClearSelection();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCurso.RowCount > 0)
            {
                if (dgvCurso.CurrentRow.Selected == true)
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

        private void Curso_Load(object sender, EventArgs e)
        {
            dgvCurso.ClearSelection();
            dgvCurso.CurrentRow.Selected = false;
            txtBuscar.Focus();
        }

        private void LlenarControles()
        {
            idActual = Int32.Parse(dgvCurso.CurrentRow.Cells["id"].Value.ToString());
            idEmpleado = Int32.Parse(dgvCurso.CurrentRow.Cells["idempleado"].Value.ToString());
            txtNombre.Text = dgvCurso.CurrentRow.Cells["nombre"].Value.ToString();
            txtEmpleado.Text = dgvCurso.CurrentRow.Cells["nombreempleado"].Value.ToString();
            txtInicial.Text = dgvCurso.CurrentRow.Cells["inicial"].Value.ToString();
            txtMensualidad.Text = dgvCurso.CurrentRow.Cells["mensualidad"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCurso.RowCount > 0)
            {
                if (dgvCurso.CurrentRow.Selected == true)
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
    }
}
