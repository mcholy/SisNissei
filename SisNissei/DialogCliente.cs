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
        private int _idtipoingreso=0;
        ClienteService servicio = new ClienteService();

        public DialogCliente()
        {
            InitializeComponent();
            Skin.AplicarSkinDialog(this);
            CargarDetalle();
            Skin.AplicarSkinDGV(dgvCliente);

        }

        public DialogCliente(int idtipoingreso)
        {
            InitializeComponent();
            Skin.AplicarSkinDialog(this);
            _idtipoingreso = idtipoingreso;
            CargarDetalle(_idtipoingreso);
            Skin.AplicarSkinDGV(dgvCliente);
           
        }
        public string CargarNombre()
        {
            return _Cliente;
        }

        public int CargarId()
        {
            return _id;
        }

        private void CargarDetalle(int _idtipoingreso)
        {
            dgvCliente.DataSource = servicio.Detalle(_idtipoingreso);
            if (dgvCliente.RowCount > 0)
            {
                dgvCliente.Columns["id"].Visible = false;
                dgvCliente.Columns["estado"].Visible = false;
                dgvCliente.Columns["regmod"].Visible = false;
                dgvCliente.Columns["fecharegistro"].Visible = false;
                dgvCliente.Columns["alergia"].Visible = false;
                dgvCliente.Columns["direccion"].Visible = false;
                dgvCliente.Columns["celular"].Visible = false;
                dgvCliente.Columns["telefono"].Visible = false;
                dgvCliente.Columns["fechanacimiento"].Visible = false;
                dgvCliente.Columns["Iddistrito"].Visible = false;
                dgvCliente.Columns["idapoderado"].Visible = false;
                dgvCliente.Columns["nombredistrito"].Visible = false;
                dgvCliente.Columns["nombreapoderado"].Visible = false;
                dgvCliente.Columns["nombresexo"].Visible = false;
                dgvCliente.Columns["sexo"].Visible = false;
                dgvCliente.Columns["materno"].Visible = false;
                dgvCliente.Columns["paterno"].Visible = false;
                dgvCliente.Columns["nombre"].Visible = false;




                dgvCliente.Columns["nombre"].DisplayIndex = 0;
                dgvCliente.Columns["paterno"].DisplayIndex = 1;
                dgvCliente.Columns["materno"].DisplayIndex = 2;
            }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = string.Empty;
            busqueda = txtBuscar.Text.Trim();
            CargarDetalle(filterNombre: busqueda );
        }
        private void CargarDetalle(string filterNombre = "")
        {
            //(BUSCAR) LINEA ACTUALIZADA
            dgvCliente.DataSource = filterNombre == "" ? servicio.Detalle(_idtipoingreso) : servicio.Detalle(_idtipoingreso).Where(x => x.Nombrecliente.ToUpper().Contains(filterNombre.ToUpper())).ToList();
            if (dgvCliente.RowCount > 0)
            {
                dgvCliente.Columns["id"].Visible = false;
                dgvCliente.Columns["nombre"].DisplayIndex = 0;
                dgvCliente.Columns["estado"].Visible = false;
                dgvCliente.Columns["regmod"].Visible = false;
                dgvCliente.Columns["fecharegistro"].Visible = false;
            }
        }

        private void DialogCliente_Load(object sender, EventArgs e)
        {

        }
        
    }
}
