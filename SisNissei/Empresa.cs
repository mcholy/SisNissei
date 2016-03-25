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
    public partial class Empresa : Form
    {
        Validacion itemValidacion = new Validacion();
        EmpresaEntity item = new EmpresaEntity();
        public Empresa()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
        }
        private void Limpiar()
        {
            txtDescuento.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }
        private void Guardar()
        {
            item.Nombre = txtNombre.Text;
            item.Descuento = Double.Parse(txtDescuento.Text);
            item.Descuento = item.Descuento / 100;
            EmpresaService servicio = new EmpresaService();
            int respuesta = servicio.Guardar(item);
            if (respuesta == 1)
            {
                Limpiar();

                MessageBox.Show("El registro se ingreso satisfactoriamente.");
            }
         }
        //int miVariable = Int32 conversion a variable
        //    double var2 = Double.parse
               


        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
