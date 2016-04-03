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
    public partial class Cliente : Form
    {
        private Validacion itemValidacion = new Validacion();
        private ClienteService servicio = new ClienteService();
        private ClienteEntity item = new ClienteEntity();
        private int regmod = 0;
        private int idDistrito = 0;
        private int idActual = 0;
        private int idApoderado = 0;
        private string nombreApoderado = "";
        public Cliente()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
        }

        private void chkAlergia_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkAlergia.Checked)
                txtAlergia.ReadOnly = false;
            else
                txtAlergia.ReadOnly = true;
        }

  

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ListarDistritos()
        {
            cbDistrito.DisplayMember = "Nombre";
            cbDistrito.ValueMember = "Id";
            cbDistrito.DataSource = new DistritoService().Listar();
        }

        private void ListarSexo()
        {
            cbSexo.Items.Add("MASCULINO");
            cbSexo.Items.Add("FEMENINO");
        }

        private void Guardar()
        {
            item.Id = idActual;
            item.Nombre = txtNombre.Text;
            item.Paterno = txtPaterno.Text;
            item.Materno = txtMaterno.Text;
            item.Dni = Int32.Parse(txtDNI.Text);
            item.Sexo = cbSexo.Text == "MASCULINO" ? false : true;
            item.Idapoderado = idApoderado;
            item.Fechanacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            item.Iddistrito = Int32.Parse(cbDistrito.SelectedValue.ToString());
            item.Celular = Int32.Parse(txtCelular.Text);
            item.Telefono = Int32.Parse(txtTelefono.Text);
            item.Direccion = txtDireccion.Text;
            item.Alergia = txtAlergia.Text;
            item.Regmod = regmod;
            ClienteService servicio = new ClienteService();
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
            item.Id = Int32.Parse(dgvCliente.CurrentRow.Cells["id"].Value.ToString());
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
            dgvCliente.DataSource = servicio.Detalle();

            if (dgvCliente.RowCount > 0)
            {
                dgvCliente.Columns["id"].Visible = false;
                dgvCliente.Columns["estado"].Visible = false;
                dgvCliente.Columns["iddistrito"].Visible = false;
                dgvCliente.Columns["regmod"].Visible = false;
                dgvCliente.Columns["fecharegistro"].Visible = false;
                dgvCliente.Columns["estado"].Visible = false;
                dgvCliente.Columns["nombre"].DisplayIndex = 1;
                dgvCliente.ClearSelection();
            }
        }
        

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCliente.RowCount > 0)
            {
                if (dgvCliente.CurrentRow.Selected == true)
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
            if (dgvCliente.RowCount > 0)
            {
                if (dgvCliente.CurrentRow.Selected == true)
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
            idActual = Int32.Parse(dgvCliente.CurrentRow.Cells["id"].Value.ToString());
            idApoderado = Int32.Parse(dgvCliente.CurrentRow.Cells["idapoderado"].Value.ToString());
            txtNombre.Text = dgvCliente.CurrentRow.Cells["nombre"].Value.ToString();
            txtPaterno.Text = dgvCliente.CurrentRow.Cells["paterno"].Value.ToString();
            txtMaterno.Text = dgvCliente.CurrentRow.Cells["materno"].Value.ToString();
            txtDNI.Text = dgvCliente.CurrentRow.Cells["dni"].Value.ToString();
            idDistrito = Int32.Parse(dgvCliente.CurrentRow.Cells["iddistrito"].Value.ToString());
            txtCelular.Text = dgvCliente.CurrentRow.Cells["celular"].Value.ToString();
            txtTelefono.Text = dgvCliente.CurrentRow.Cells["telefono"].Value.ToString();
            txtDireccion.Text = dgvCliente.CurrentRow.Cells["direccion"].Value.ToString();
            txtAlergia.Text = dgvCliente.CurrentRow.Cells["alergia"].Value.ToString();
        }

        private void btnBuscarApoderado_Click(object sender, EventArgs e)
        {
            DialogCliente dialogEmpleado = new DialogCliente();
            DialogResult resultado = dialogEmpleado.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                nombreApoderado = dialogEmpleado.CargarNombre();
                idApoderado = dialogEmpleado.CargarId();

            }
            txtApoderado.Text = nombreApoderado;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            ListarDistritos();
            ListarSexo();
            dgvCliente.ClearSelection();
            dgvCliente.CurrentRow.Selected = false;
            txtBuscar.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
