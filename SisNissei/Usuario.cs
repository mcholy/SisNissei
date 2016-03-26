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
        Validacion itemValidacion = new Validacion();
        private int idEmpleado = 0;
        private string nombreEmpleado = "";
        public Usuario()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            ListarRoles();
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
    }
}
