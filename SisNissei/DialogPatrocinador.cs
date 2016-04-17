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
    public partial class DialogPatrocinador : Form
    {
        private string _Patrocinador = "";
        private int _id = 0;
        InscripcionSocioService servicio = new InscripcionSocioService();
        public DialogPatrocinador()
        {
            InitializeComponent();
            Skin.AplicarSkinDialog(this);
            CargarDetalle();
        }
        public string CargarNombre()
        {
            return _Patrocinador;
        }

        public int CargarId()
        {
            return _id;
        }


        private void CargarDetalle()
        {
            dgvPatrocinador.DataSource = servicio.Detalle();
            if (dgvPatrocinador.RowCount > 0)
            {
                dgvPatrocinador.Columns["id"].Visible = false;
                dgvPatrocinador.Columns["estado"].Visible = false;
                dgvPatrocinador.Columns["nombre"].DisplayIndex = 0;

            }
        }


        private void dgvPatrocinador_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPatrocinador.RowCount > 0)
            {
                _id = Int32.Parse(dgvPatrocinador.CurrentRow.Cells["id"].Value.ToString());
                _Patrocinador = dgvPatrocinador.CurrentRow.Cells["nombre"].Value.ToString();

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
