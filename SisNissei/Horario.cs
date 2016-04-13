using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models.Services;
using SisNissei.Template;

namespace SisNissei
{
    public partial class Horario : Form
    {
        private string[] rowDetalle;
        public Horario()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
        }

        private void Horario_Load(object sender, EventArgs e)
        {
            ListarCursos();
            ListarGruposEtarios();
            CrearColumnasDGV();
        }
        #region Singleton
        private static Horario m_FormDefInstance;
        public static Horario DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Horario();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion

        private void ListarCursos()
        {
            cbCurso.DisplayMember = "Nombre";
            cbCurso.ValueMember = "Id";
            cbCurso.DataSource = new CursoService().Listar();
        }
        private void ListarGruposEtarios()
        {
            cbGrupoEtario.DisplayMember = "Nombre";
            cbGrupoEtario.ValueMember = "Id";
            cbGrupoEtario.DataSource = new GrupoEtarioService().Listar();
        }

        private void PasarDatosDGV()
        {
            rowDetalle = new string[] { BuildingStringDays(), txtHorario.Text, TextoDias() };
            dgvDetalleHorario.Rows.Add(rowDetalle);
        }

        private void CrearColumnasDGV()
        {
            dgvDetalleHorario.ColumnCount = 3;
            dgvDetalleHorario.Columns[0].Name = "CODIGO";
            dgvDetalleHorario.Columns[1].Name = "DIA";
            dgvDetalleHorario.Columns[2].Name = "HORARIO";
        }


        private string BuildingStringDays()
        {
            string Days = String.Empty;
            Days += chkLunes.Checked ? "1" : "0";
            Days += chkMartes.Checked ? "1" : "0";
            Days += chkMiercoles.Checked ? "1" : "0";
            Days += chkJueves.Checked ? "1" : "0";
            Days += chkViernes.Checked ? "1" : "0";
            Days += chkSabado.Checked ? "1" : "0";
            Days += chkDomingo.Checked ? "1" : "0";
            return Days;
        }

        private string TextoDias()
        {
            string cadena = String.Empty;
            cadena += chkLunes.Checked ? "Lun " : "";
            cadena += chkMartes.Checked ? "Mar " : "";
            cadena += chkMiercoles.Checked ? "Mie " : "";
            cadena += chkJueves.Checked ? "Jue " : "";
            cadena += chkViernes.Checked ? "Vie " : "";
            cadena += chkSabado.Checked ? "Sab " : "";
            cadena += chkDomingo.Checked ? "Dom " : "";
            cadena = cadena.Trim();
            return cadena;
        }

        private void btnHora_Click(object sender, EventArgs e)
        {
            if (txtHorario.Text.Trim() != String.Empty)
            {
                PasarDatosDGV();
            }
        }

    }
}
