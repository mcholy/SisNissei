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
    public partial class Periodo : Form
    {
        PeriodoEntity item = new PeriodoEntity();
        public Periodo()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
        }
        private void Guardar()
        {
            item.Nombre = txtNombre.Text;
            PeriodoService servicio = new PeriodoService();
            int respuesta = servicio.Guardar(item);
            if (respuesta == 1)
            {
                Limpiar();
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
            }
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
