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
using Entities;

namespace SisNissei
{
    public partial class Listado_de_Alumnos : Form
    {
        private ReporteAlumnosEntity item = new ReporteAlumnosEntity();
        private ReporteAlumnosService servicio = new ReporteAlumnosService();
        private int idcurso = 0;
        private int idperiodo = 0;
        private string mes = "";
        private int mespago = 0;
        public Listado_de_Alumnos()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            
            Skin.AplicarSkinDGV(dgvListadoAlumnos);
            CargarDetalle();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ListarMes()
        {
            cbMesPago.Items.Add("Ninguno");
            cbMesPago.Items.Add("Enero");
            cbMesPago.Items.Add("Febrero");
            cbMesPago.Items.Add("Marzo");
            cbMesPago.Items.Add("Abril");
            cbMesPago.Items.Add("Mayo");
            cbMesPago.Items.Add("Junio");
            cbMesPago.Items.Add("Julio");
            cbMesPago.Items.Add("Agosto");
            cbMesPago.Items.Add("Septiembre");
            cbMesPago.Items.Add("Octubre");
            cbMesPago.Items.Add("Noviembre");
            cbMesPago.Items.Add("Diciembre");
        }
        private void ListarCursos()
        {
            cbCurso.DisplayMember = "Nombre";
            cbCurso.ValueMember = "Id";
            cbCurso.DataSource = new CursoService().Listar();
        }
        private void ListarPeriodos()
        {
            cbPeriodo.DisplayMember = "Nombre";
            cbPeriodo.ValueMember = "Id";
            cbPeriodo.DataSource = new PeriodoService().Listar();
        }

        private void Listado_de_Alumnos_Load(object sender, EventArgs e)
        {
            ListarMes();
            ListarCursos();
            ListarPeriodos();
        }

        private void CargarDetalle(string filterNombre = "")
        {
           
            item.Idcurso = idcurso;           
            item.Idperiodo = idperiodo;
            item.Mespago = mespago;
            dgvListadoAlumnos.DataSource = filterNombre == "" ? servicio.Detalle(item) : servicio.Detalle(item).Where(x => x.Nombrecliente.ToUpper().Contains(filterNombre.ToUpper())).ToList();
            if (dgvListadoAlumnos.RowCount > 0)
            {
                dgvListadoAlumnos.Columns["idcurso"].Visible = false;
                dgvListadoAlumnos.Columns["idperiodo"].Visible = false;
                dgvListadoAlumnos.Columns["mespago"].Visible = false;
            }
        }
        #region Singleton
        private static Listado_de_Alumnos m_FormDefInstance;
        public static Listado_de_Alumnos DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Listado_de_Alumnos();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion

        private void btnListar_Click(object sender, EventArgs e)
        {
            mes = cbMesPago.Text;
            switch (mes)
            {
                case "Ninguno":
                    mespago = 0;
                    break;
                case "Enero":
                    mespago=1;
                    break;
                case "Febrero":
                    mespago = 2;
                    break;
                case "Marzo":
                    mespago = 3;
                    break;
                case "Abril":
                    mespago = 4;
                    break;
                case "Mayo":
                    mespago = 5;
                    break;
                case "Junio":
                    mespago = 6;
                    break;
                case "Julio":
                    mespago = 7;
                    break;
                case "Agosto":
                    mespago = 8;
                    break;
                case "Septiembre":
                    mespago = 9;
                    break;
                case "Octubre":
                    mespago = 10;
                    break;
                case "Noviembre":
                    mespago = 11;
                    break;
                case "Diciembre":
                    mespago = 12;
                    break;
            }
            idcurso = Int32.Parse(cbCurso.SelectedValue.ToString());
            idperiodo = Int32.Parse(cbPeriodo.SelectedValue.ToString());
            CargarDetalle();
        }
    }
}