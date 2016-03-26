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
using SisNissei.Helper;
using Entities;

namespace SisNissei
{
    public partial class Cliente : Form
    {
        Validacion itemValidacion = new Validacion();
        ClienteEntity item;
        public Cliente()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            
        }

        private void chkAlergia_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkAlergia.Checked)
                txtAlergia.ReadOnly = false;
            else
                txtAlergia.ReadOnly = true;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            ListarDistritos();
            ListarSexo();
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
            item.Nombre = txtNombre.Text;
            item.Sexo = cbSexo.Text == "MASCULINO" ? false : true;
            ClienteService servicio = new ClienteService();
            int respuesta = servicio.Guardar(item);
            if (respuesta == 1)
            {
                Limpiar();

                MessageBox.Show("El registro se ingreso satisfactoriamente.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
        }

    }
}
