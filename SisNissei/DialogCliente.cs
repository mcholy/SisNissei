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
    public partial class DialogCliente : Form
    {
        private string _Cliente = "";
        private int _id = 0;
        ClienteService servicio = new ClienteService();

        public DialogCliente()
        {
            InitializeComponent();
            Skin.AplicarSkinDialog(this);
            CargarDetalle();

        }
        public string CargarNombre()
        {
            return _Cliente;
        }

        public int CargarId()
        {
            return _id;
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCliente.RowCount > 0)
            {
                _id = Int32.Parse(dgvCliente.CurrentRow.Cells["id"].Value.ToString());
                _Cliente = dgvCliente.CurrentRow.Cells["nombre"].Value.ToString() + " " +
                    dgvCliente.CurrentRow.Cells["paterno"].Value.ToString() + " " +
                    dgvCliente.CurrentRow.Cells["materno"].Value.ToString();

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CargarDetalle()
        {
            dgvCliente.DataSource = servicio.Detalle();
            if (dgvCliente.RowCount > 0)
            {
                dgvCliente.Columns["id"].Visible = false;
                dgvCliente.Columns["estado"].Visible = false;
                dgvCliente.Columns["nombre"].DisplayIndex = 0;
                dgvCliente.Columns["paterno"].DisplayIndex = 1;
                dgvCliente.Columns["materno"].DisplayIndex = 2;
            }
        }
    }
}
