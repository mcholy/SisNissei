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
    public partial class Empleado : Form
    {
        #region Propiedades
        private Validacion itemValidacion = new Validacion();
        private EmpleadoEntity item = new EmpleadoEntity();
        private EmpleadoService servicio = new EmpleadoService();
        private int regmod = 0;
        private int idActual = 0;
       
         #endregion
        public Empleado()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
            ListarTipoEmpleados();
            Skin.AplicarSkinDGV(dgvEmpleado);
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtPaterno.Text = string.Empty;
            txtMaterno.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtSueldoBase.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            cbTipoEmpleado.DataSource = new TipoEmpleadoService().Listar();
        }


        
        private void Guardar()
        {
            item.Id = idActual;
            item.Nombre = txtNombre.Text;
            item.Paterno = txtPaterno.Text;
            item.Materno = txtMaterno.Text;
            item.Dni = txtDni.Text;
            item.Sueldobase= Double.Parse(txtSueldoBase.Text);
            item.Idtipoempleado = Int32.Parse(cbTipoEmpleado.SelectedValue.ToString());
            item.Celular = txtCelular.Text;
            item.Telefono = txtTelefono.Text;
            item.Direccion = txtDireccion.Text;
            item.Regmod = regmod;
            //item.idtipoemeplado = icbsexo.selectedvalue;
            EmpleadoService servicio = new EmpleadoService();
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
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }
        private void ListarTipoEmpleados()
        {
            cbTipoEmpleado.DisplayMember = "Nombre";
            cbTipoEmpleado.ValueMember = "Id";
            cbTipoEmpleado.DataSource = new TipoEmpleadoService().Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void CargarDetalle()
        {
            dgvEmpleado.DataSource = servicio.Detalle();
            if (dgvEmpleado.RowCount > 0)
            {
                dgvEmpleado.Columns["id"].Visible = false;
                dgvEmpleado.Columns["estado"].Visible = false;
                dgvEmpleado.Columns["nombre"].Visible = false;
                dgvEmpleado.Columns["paterno"].Visible = false;
                dgvEmpleado.Columns["materno"].Visible = false;
                dgvEmpleado.Columns["idtipoempleado"].Visible = false;
                dgvEmpleado.Columns["regmod"].Visible = false;
                dgvEmpleado.Columns["dni"].DisplayIndex = 0;
                dgvEmpleado.Columns["dni"].HeaderText = "DNI";
                dgvEmpleado.Columns["nombreempleado"].DisplayIndex = 1;
                dgvEmpleado.Columns["nombreempleado"].HeaderText = "Empleado";
                dgvEmpleado.Columns["direccion"].DisplayIndex = 2;
                dgvEmpleado.Columns["direccion"].HeaderText = "Direccion";
                dgvEmpleado.Columns["nombretipoempleado"].DisplayIndex = 3;
                dgvEmpleado.Columns["nombretipoempleado"].HeaderText = "Cargo";
                dgvEmpleado.Columns["telefono"].DisplayIndex = 4;
                dgvEmpleado.Columns["telefono"].HeaderText = "telefono";
                dgvEmpleado.Columns["celular"].DisplayIndex = 5;
                dgvEmpleado.Columns["celular"].HeaderText = "Celular";                
                dgvEmpleado.Columns["sueldobase"].DisplayIndex = 6;
                dgvEmpleado.Columns["sueldobase"].HeaderText = "Sueldo Base";
                dgvEmpleado.Columns["fecharegistro"].DisplayIndex = 7;
                dgvEmpleado.Columns["fecharegistro"].HeaderText = "Fecha Registro";
               
            }
        }
        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvEmpleado.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = servicio.Eliminar(item);
            if (respuesta == 1)
            {
                //Limpiar();
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
                CargarDetalle();
            }
        }
        private void Empleado_Load(object sender, EventArgs e)
        {
            dgvEmpleado.ClearSelection();
            dgvEmpleado.CurrentRow.Selected = false;
            txtBuscar.Focus();
            ListarTipoEmpleados();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.RowCount > 0)
            {
                if (dgvEmpleado.CurrentRow.Selected == true)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.RowCount > 0)
            {
                if (dgvEmpleado.CurrentRow.Selected == true)
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
            idActual = Int32.Parse(dgvEmpleado.CurrentRow.Cells["id"].Value.ToString());
            cbTipoEmpleado.SelectedValue = Int32.Parse(dgvEmpleado.CurrentRow.Cells["idtipoempleado"].Value.ToString());      
            txtNombre.Text = dgvEmpleado.CurrentRow.Cells["nombre"].Value.ToString();
            txtPaterno.Text = dgvEmpleado.CurrentRow.Cells["paterno"].Value.ToString();
            txtMaterno.Text = dgvEmpleado.CurrentRow.Cells["materno"].Value.ToString();
            txtDni.Text = dgvEmpleado.CurrentRow.Cells["dni"].Value.ToString();
            txtSueldoBase.Text = dgvEmpleado.CurrentRow.Cells["sueldobase"].Value.ToString();
            txtCelular.Text = dgvEmpleado.CurrentRow.Cells["celular"].Value.ToString();
            txtTelefono.Text = dgvEmpleado.CurrentRow.Cells["telefono"].Value.ToString();
            txtDireccion.Text = dgvEmpleado.CurrentRow.Cells["direccion"].Value.ToString();
        }
        #region Singleton
        private static Empleado m_FormDefInstance;
        public static Empleado DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Empleado();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion
    }
}
