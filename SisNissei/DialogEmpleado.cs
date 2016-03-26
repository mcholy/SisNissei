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

namespace SisNissei
{
    public partial class DialogEmpleado : Form
    {
        private string _empleado = "";
        private int _id = 0;
        EmpleadoService servicio = new EmpleadoService();

        public DialogEmpleado()
        {
            InitializeComponent();
            Skin.AplicarSkinDialog(this);
            CargarDetalle();

        }
        public string CargarNombre()
        {
            return _empleado;
        }

        public int CargarId()
        {
            return _id;
        }

        private void dgvEmpleado_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmpleado.RowCount > 0)
            {
                _id = Int32.Parse(dgvEmpleado.CurrentRow.Cells["id"].Value.ToString());
                _empleado = dgvEmpleado.CurrentRow.Cells["nombre"].Value.ToString() + " " +
                    dgvEmpleado.CurrentRow.Cells["paterno"].Value.ToString() + " " +
                    dgvEmpleado.CurrentRow.Cells["materno"].Value.ToString();

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CargarDetalle()
        {
            dgvEmpleado.DataSource = servicio.Detalle();
            if (dgvEmpleado.RowCount > 0)
            {
                dgvEmpleado.Columns["id"].Visible = false;
                dgvEmpleado.Columns["estado"].Visible = false;
                dgvEmpleado.Columns["idtipoempleado"].Visible = false;
                dgvEmpleado.Columns["nombre"].DisplayIndex = 0;
                dgvEmpleado.Columns["paterno"].DisplayIndex = 1;
                dgvEmpleado.Columns["materno"].DisplayIndex = 2;
            }
        }
    }
}
