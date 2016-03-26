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

    public partial class TipoEmpleado : Form
    {
        Validacion itemValidacion = new Validacion();
        TipoEmpleadoEntity item = new TipoEmpleadoEntity();
        public TipoEmpleado()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtPorcentajeMatricula.Text = string.Empty;
            txtPorcentajeMensual.Text = string.Empty;
        }
        private void Guardar()
        {
            item.Nombre = txtNombre.Text;
            item.Porcentajematricula = Double.Parse(txtPorcentajeMatricula.Text);
            item.Porcentajematricula = item.Porcentajematricula / 100;
            item.Porcentajemensual = Double.Parse(txtPorcentajeMensual.Text);
            item.Porcentajemensual = item.Porcentajemensual / 100;
            //item.idtipoemeplado = icbsexo.selectedvalue;
            TipoEmpleadoService servicio = new TipoEmpleadoService();
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

        private void txtPorcentajeMensualidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void txtPorcentajeMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
