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
    public partial class DialogEmpresa : Form
    {

        private string _Empresa = "";
        private int _id = 0;
        EmpresaService servicio = new EmpresaService();

        public DialogEmpresa()
        {
            InitializeComponent();
            Skin.AplicarSkinDialog(this);
            CargarDetalle();

        }
        public string CargarNombre()
        {
            return _Empresa;
        }

        public int CargarId()
        {
            return _id;
        }


        private void CargarDetalle()
        {
            dgvEmpresa.DataSource = servicio.Detalle();
            if (dgvEmpresa.RowCount > 0)
            {
                dgvEmpresa.Columns["id"].Visible = false;
                dgvEmpresa.Columns["estado"].Visible = false;
                dgvEmpresa.Columns["nombre"].DisplayIndex = 0;

            }
        }

        private void dgvEmpresa_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgvEmpresa.RowCount > 0)
            {
                _id = Int32.Parse(dgvEmpresa.CurrentRow.Cells["id"].Value.ToString());
                _Empresa = dgvEmpresa.CurrentRow.Cells["nombre"].Value.ToString();

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
