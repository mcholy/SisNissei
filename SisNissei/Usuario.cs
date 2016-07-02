using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SisNissei.Template;
using Entities;
using Models.Services;

namespace SisNissei
{
    public partial class Usuario : Form
    {
        private Validacion itemValidacion = new Validacion();
        private UsuarioEntity item = new UsuarioEntity();
        private UsuarioService servicio = new UsuarioService();
        private int idEmpleado = 0;
        private int idRol = 0;
        private string nombreEmpleado = "";
        private int idActual = 0;
        private int regmod = 0;
        public Usuario()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
        }

        #region Singleton
        private static Usuario m_FormDefInstance;
        public static Usuario DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Usuario();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

        private void ListarRoles()
        {
            cbRol.DisplayMember = "Nombre";
            cbRol.ValueMember = "Id";
            cbRol.DataSource = new RolService().Listar();
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
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtEmpleado.Text = string.Empty;
            txtContrasenia.Text = string.Empty;
        }
        private void Guardar()
        {
            item.Id = idActual;
            item.Nombre = txtNombre.Text;
            item.Idempleado = idEmpleado;
            item.Idrol = Int32.Parse(cbRol.SelectedValue.ToString());
            item.Contrasenia = txtContrasenia.Text;
            item.Regmod = regmod;
            //item.idtipoemeplado = icbsexo.selectedvalue;
            UsuarioService servicio = new UsuarioService();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void CargarDetalle()
        {
            dgvUsuario.DataSource = servicio.Detalle();
            if (dgvUsuario.RowCount > 0)
            {
                dgvUsuario.Columns["id"].Visible = false;
                dgvUsuario.Columns["estado"].Visible = false;
                dgvUsuario.Columns["contrasenia"].Visible = false;
                dgvUsuario.Columns["idrol"].Visible = false;
                dgvUsuario.Columns["idempleado"].Visible = false;
                dgvUsuario.Columns["regmod"].Visible = false;
                dgvUsuario.Columns["nombreEmpleado"].DisplayIndex = 0;
                dgvUsuario.Columns["nombreEmpleado"].HeaderText = "Nombre y Apellidos";
                dgvUsuario.Columns["nombre"].DisplayIndex = 1;
                dgvUsuario.Columns["nombre"].HeaderText = "Usuario";
                dgvUsuario.Columns["nombrerol"].DisplayIndex = 2;
                dgvUsuario.Columns["nombrerol"].HeaderText = "Rol";
            }
        }
        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvUsuario.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = servicio.Eliminar(item);
            if (respuesta == 1)
            {
                //Limpiar();
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
                CargarDetalle();
            }
        }
        private void Usuario_Load(object sender, EventArgs e)
        {
            dgvUsuario.ClearSelection();
            dgvUsuario.CurrentRow.Selected = false;
            txtBuscar.Focus();
            ListarRoles();
        }
        private void LlenarControles()
        {
            idActual = Int32.Parse(dgvUsuario.CurrentRow.Cells["id"].Value.ToString());
            idEmpleado = Int32.Parse(dgvUsuario.CurrentRow.Cells["idempleado"].Value.ToString());
            txtNombre.Text = dgvUsuario.CurrentRow.Cells["nombre"].Value.ToString();
            txtEmpleado.Text = dgvUsuario.CurrentRow.Cells["nombreempleado"].Value.ToString();
            idRol = Int32.Parse(dgvUsuario.CurrentRow.Cells["idrol"].Value.ToString());
            txtContrasenia.Text = dgvUsuario.CurrentRow.Cells["contrasenia"].Value.ToString();
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.RowCount > 0)
            {
                if (dgvUsuario.CurrentRow.Selected == true)
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
            if (dgvUsuario.RowCount > 0)
            {
                if (dgvUsuario.CurrentRow.Selected == true)
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
    }
}
