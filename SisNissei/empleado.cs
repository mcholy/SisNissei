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
        Validacion itemValidacion = new Validacion();
        EmpleadoEntity item = new EmpleadoEntity();
        public Empleado()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
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
        }


        
        private void Guardar()
        {
            item.Nombre = txtNombre.Text;
            item.Paterno = txtPaterno.Text;
            item.Materno = txtMaterno.Text;
            item.Dni = txtDni.Text;
            item.Sueldobase= Double.Parse(txtSueldoBase.Text);
            item.Idtipoempleado = Int32.Parse(cbTipoEmpleado.SelectedValue.ToString());
            item.Celular = txtCelular.Text;
            item.Telefono = txtTelefono.Text;
            item.Direccion = txtDireccion.Text;
            //item.idtipoemeplado = icbsexo.selectedvalue;
            EmpleadoService servicio = new EmpleadoService();
            int respuesta = servicio.Guardar(item);
            if (respuesta == 1)
                
            {
                Limpiar();
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
            }
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

        private void Empleado_Load(object sender, EventArgs e)
        {
            ListarTipoEmpleados();
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

            
    }
}
