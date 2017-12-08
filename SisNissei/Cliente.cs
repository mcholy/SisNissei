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
        private int idtipoingreso = 0;
        public Cliente()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
            Skin.AplicarSkinDGV(dgvCliente);
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
            item = new ClienteEntity();
            item.Id = idActual;
            item.Nombre = txtNombre.Text;
            item.Paterno = txtPaterno.Text;
            item.Materno = txtMaterno.Text;
            item.Dni = Int32.Parse(txtDNI.Text);
            item.Sexo = cbSexo.Text == "MASCULINO" ? false : true;
            item.Idapoderado = idApoderado;
            item.Fechanacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            item.Iddistrito = Int32.Parse(cbDistrito.SelectedValue.ToString());
            item.Celular = Int32.Parse(txtCelular.Text == "" ? "0": txtCelular.Text);

            item.Telefono = Int32.Parse(txtTelefono.Text == "" ? "0" : txtTelefono.Text);
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
            else if (respuesta == 3)
            {
                MessageBox.Show("El DNI ingresado ya se encuentra registrado.");
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
        private void CargarDetalle(string filterNombre = "")
        {

            dgvCliente.DataSource = filterNombre == "" ? servicio.Detalle(idtipoingreso) : servicio.Detalle(idtipoingreso).Where(x => x.Nombrecliente.ToUpper().Contains(filterNombre.ToUpper())).ToList();
            if (dgvCliente.RowCount > 0)
            {
                dgvCliente.Columns["id"].Visible = false;
                dgvCliente.Columns["estado"].Visible = false;
                dgvCliente.Columns["iddistrito"].Visible = false;
                dgvCliente.Columns["regmod"].Visible = false;
                dgvCliente.Columns["fecharegistro"].Visible = false;
                dgvCliente.Columns["estado"].Visible = false;
                dgvCliente.Columns["nombre"].Visible = false;
                dgvCliente.Columns["paterno"].Visible = false;
                dgvCliente.Columns["materno"].Visible = false;
                dgvCliente.Columns["Idapoderado"].Visible = false;
                dgvCliente.Columns["Sexo"].Visible = false;
                dgvCliente.Columns["nombrecliente"].DisplayIndex = 0;
                dgvCliente.Columns["nombrecliente"].HeaderText = "Nombre";
                dgvCliente.Columns["dni"].DisplayIndex = 1;
                dgvCliente.Columns["dni"].HeaderText = "DNI";
                dgvCliente.Columns["nombreapoderado"].DisplayIndex = 2;
                dgvCliente.Columns["nombreapoderado"].HeaderText = "Apoderado";
                dgvCliente.Columns["nombresexo"].DisplayIndex = 3;
                dgvCliente.Columns["nombresexo"].HeaderText = "Sexo";
                dgvCliente.Columns["direccion"].DisplayIndex = 4;
                dgvCliente.Columns["direccion"].HeaderText = "Direccion";
                dgvCliente.Columns["nombredistrito"].DisplayIndex = 5;
                dgvCliente.Columns["nombredistrito"].HeaderText = "Distrito";
                dgvCliente.Columns["fechanacimiento"].DisplayIndex = 6;
                dgvCliente.Columns["fechanacimiento"].HeaderText = "Fecha de nacimiento";
                dgvCliente.Columns["telefono"].DisplayIndex = 7;
                dgvCliente.Columns["telefono"].HeaderText = "Telefono";
                dgvCliente.Columns["celular"].DisplayIndex = 8;
                dgvCliente.Columns["celular"].HeaderText = "Celular";
                dgvCliente.Columns["Alergia"].DisplayIndex = 9;
                dgvCliente.Columns["alergia"].HeaderText = "Alergia";
                dgvCliente.ClearSelection();
            }
        }
        

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApoderado.Text = string.Empty;
            txtPaterno.Text = string.Empty;
            txtMaterno.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
            cbSexo.SelectedValue = 0;
            cbDistrito.SelectedValue = 0;
            txtCelular.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtAlergia.Text = string.Empty;
            idApoderado = 0;
            idActual = 0;
            regmod = 0;
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
            txtApoderado.Text = dgvCliente.CurrentRow.Cells["nombreapoderado"].Value.ToString();
            txtNombre.Text = dgvCliente.CurrentRow.Cells["nombre"].Value.ToString();
            txtPaterno.Text = dgvCliente.CurrentRow.Cells["paterno"].Value.ToString();
            txtMaterno.Text = dgvCliente.CurrentRow.Cells["materno"].Value.ToString();
            txtDNI.Text = dgvCliente.CurrentRow.Cells["dni"].Value.ToString();
             cbDistrito.SelectedValue = Int32.Parse(dgvCliente.CurrentRow.Cells["iddistrito"].Value.ToString());
             txtFechaNacimiento.Text = dgvCliente.CurrentRow.Cells["fechanacimiento"].Value.ToString();
             cbSexo.SelectedItem= dgvCliente.CurrentRow.Cells["nombresexo"].Value.ToString();

            idDistrito = Int32.Parse(dgvCliente.CurrentRow.Cells["iddistrito"].Value.ToString());
            txtCelular.Text = dgvCliente.CurrentRow.Cells["celular"].Value.ToString();
            txtTelefono.Text = dgvCliente.CurrentRow.Cells["telefono"].Value.ToString();
            txtDireccion.Text = dgvCliente.CurrentRow.Cells["direccion"].Value.ToString();
            txtAlergia.Text = dgvCliente.CurrentRow.Cells["alergia"].Value.ToString();
        }

        private void btnBuscarApoderado_Click(object sender, EventArgs e)
        {
            DialogCliente dialogCliente = new DialogCliente();
            DialogResult resultado = dialogCliente.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                nombreApoderado = dialogCliente.CargarNombre();
                idApoderado = dialogCliente.CargarId();

            }
            txtApoderado.Text = nombreApoderado;
            DatosApo(idApoderado);
        }


        private void DatosApo(int idApoderado)
        {
            item.Idapoderado = idApoderado;
            string direccion = servicio.DatosApoDir(item);
            string telefono = servicio.DatosApoTel(item);
            string celular = servicio.DatosApoCel(item);
            txtDireccion.Text = direccion;
            txtCelular.Text = celular;
            txtTelefono.Text = telefono;

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
        #region Singleton
        private static Cliente m_FormDefInstance;
        public static Cliente DefInstance
        {
            get
            {
              
                    m_FormDefInstance = new Cliente();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion

        private void chkAlergia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlergia.Checked)
                txtAlergia.ReadOnly = false;
            else
                txtAlergia.ReadOnly = true;
        }

        private void txtDNI_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void txtCelular_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = string.Empty;
            busqueda = txtBuscar.Text.Trim();
            CargarDetalle(filterNombre: busqueda);
        }
    }
}
