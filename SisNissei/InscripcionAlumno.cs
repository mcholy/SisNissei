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
    public partial class InscripcionAlumno : Form
    {
        private Validacion itemValidacion = new Validacion();
        private InscripcionAlumnoEntity item = new InscripcionAlumnoEntity();
        private InscripcionAlumnoService servicio = new InscripcionAlumnoService();
        private int idCliente = 0;
        private string nombreCliente = "";
        private int idCurso = 0;
        private int idHorario= 0;
        private int idEmpresa = 0;
        private string nombreEmpresa = "";
        private int idPeriodo = 0;
        private int idActual = 0;
        private int regmod = 0;

        public InscripcionAlumno()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
        }
        private void ListarCursos()
        {
            cbCurso.DisplayMember = "Nombre";
            cbCurso.ValueMember = "Id";
            cbCurso.DataSource = new CursoService().Listar();
        }


        #region Singleton
        private static InscripcionAlumno m_FormDefInstance;
        public static InscripcionAlumno DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new InscripcionAlumno();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            DialogCliente dialogCliente = new DialogCliente();
            DialogResult resultado = dialogCliente.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                nombreCliente = dialogCliente.CargarNombre();
                idCliente = dialogCliente.CargarId();

            }
            txtCliente.Text = nombreCliente;
        }

        private void btnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            DialogEmpresa dialogEmpresa = new DialogEmpresa();
            DialogResult resultado = dialogEmpresa.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                nombreEmpresa = dialogEmpresa.CargarNombre();
                idEmpresa = dialogEmpresa.CargarId();

            }
            txtEmpresa.Text = nombreEmpresa;
        }
        private void ListarPeriodos()
        {
            cbPeriodo.DisplayMember = "Nombre";
            cbPeriodo.ValueMember = "Id";
            cbPeriodo.DataSource = new PeriodoService().Listar();
        }
        private void Guardar()
        {
            item.Id = idActual;
            item.Nombre = txtNombre.Text;
            item.Idcliente = idCliente;
            item.Idcurso = idCurso;
            item.Idhorario = idHorario;
            item.Idempresa = idEmpresa;
            item.Idperiodo = idPeriodo;
            item.Regmod = regmod;
            InscripcionAlumnoService servicio = new InscripcionAlumnoService();
            int respuesta = servicio.Guardar(item);
            if (respuesta == 1)
            {
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
            }
            else if (respuesta == 2)
            {
                MessageBox.Show("El registro se actualizó satisfactoriamente.");
            }
            Limpiar();
            CargarDetalle();
        }
        private void Limpiar()
        {
            txtCliente.Text = string.Empty;
            txtEmpresa.Text = string.Empty;

        }
        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvInscripcionAlumno.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = servicio.Eliminar(item);
            if (respuesta == 1)
            {
                //Limpiar();
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
                CargarDetalle();
            }
        }
        private void CargarDetalle()
        {
            dgvInscripcionAlumno.DataSource = servicio.Detalle();

            if (dgvInscripcionAlumno.RowCount > 0)
            {
                dgvInscripcionAlumno.Columns["id"].Visible = false;
                dgvInscripcionAlumno.Columns["estado"].Visible = false;
                dgvInscripcionAlumno.Columns["idcliente"].Visible = false;
                dgvInscripcionAlumno.Columns["idcurso"].Visible = false;
                dgvInscripcionAlumno.Columns["idhorario"].Visible = false;
                dgvInscripcionAlumno.Columns["idperiodo"].Visible = false;
                dgvInscripcionAlumno.Columns["idempresa"].Visible = false;
                dgvInscripcionAlumno.Columns["regmod"].Visible = false;
                dgvInscripcionAlumno.Columns["nombre"].DisplayIndex = 1;
                dgvInscripcionAlumno.Columns["nombrecliente"].DisplayIndex = 2;
                dgvInscripcionAlumno.Columns["nombrecurso"].DisplayIndex = 3;
                dgvInscripcionAlumno.Columns["nombrehorario"].DisplayIndex = 4;
                dgvInscripcionAlumno.Columns["nombreempresa"].DisplayIndex = 5;
                dgvInscripcionAlumno.Columns["nombreperiodo"].DisplayIndex = 6;
                dgvInscripcionAlumno.ClearSelection();
            }
        }

        private void InscripcionAlumno_Load(object sender, EventArgs e)
        {
            ListarCursos();
            ListarPeriodos();

            dgvInscripcionAlumno.ClearSelection();
            dgvInscripcionAlumno.CurrentRow.Selected = false;
            txtBuscar.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInscripcionAlumno.RowCount > 0)
            {
                if (dgvInscripcionAlumno.CurrentRow.Selected == true)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar este registro?", "SisNisei",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Eliminar();
                    }
                }
                else
                {
                    MessageBox.Show("No hay ningún registro seleccionado.");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void ListarHorarioEtario(int idcurso)
        {
            cbHorario.DisplayMember = "Nombre";
            cbHorario.ValueMember = "Id";
            cbHorario.DataSource = new HorarioService().Listar(idcurso);
        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCurso = Int32.Parse(cbCurso.SelectedValue.ToString());
            ListarHorarioEtario(idCurso);
            }
     
        }


    }
