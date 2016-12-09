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
using System.Data.SqlClient;
using Models;

namespace SisNissei
{
    public partial class InscripcionAlumno : Form
    {
        #region Propiedades
        private Validacion itemValidacion = new Validacion();
        private InscripcionAlumnoEntity item = new InscripcionAlumnoEntity();
        private InscripcionAlumnoService servicio = new InscripcionAlumnoService();
        private DetalleInscripcionAlumnoEntity itemdetalle = new DetalleInscripcionAlumnoEntity();
        private DetalleInscripcionAlumnoService serviciodetalle = new DetalleInscripcionAlumnoService();
        ReporteInscripcionAlumnoEntity item2 = new ReporteInscripcionAlumnoEntity();
        private int idCliente = 0;
        private int idApoderado = 0;
        private string nombreCliente = "";
        private string nombreApoderado = "";
        private int idCurso = 0;
        private int idHorario = 0;
        private int idEmpresa = 0;
        private string nombreEmpresa = "";
        private int idPeriodo = 0;
        private int idActual = 0;
        private int idActualDetalle = 0;
        private int regmod = 0;
        private int regmoddetalle = 0;
        #endregion

        public InscripcionAlumno()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
            InsertarCodigo();
            Skin.AplicarSkinDGV(dgvInscripcionAlumno);
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
        private void ListarCursos()
        {
            cbCurso.DisplayMember = "Nombre";
            cbCurso.ValueMember = "Id";
            cbCurso.DataSource = new CursoService().Listar();
        }

        private void InsertarCodigo()
        {
            txtNombre.Text = new InscripcionAlumnoService().Codigo(item);
        }
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
            item.Idapoderado = idApoderado;
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
            else if (respuesta == 3)
            {
                MessageBox.Show("El DNI ingresado ya se encuentra registrado.");
            }
            Limpiar();
            CargarDetalle();
        }

        private void GuardarDetalle()
        {
            itemdetalle.Id = idActualDetalle;
            itemdetalle.Idinscripcionalumno = idActual;
            itemdetalle.Idempresa = idEmpresa;
            itemdetalle.Idcurso = Int32.Parse(cbCurso.SelectedValue.ToString());
            itemdetalle.Idhorario = Int32.Parse(cbHorario.SelectedValue.ToString());
            itemdetalle.Idperiodo = Int32.Parse(cbPeriodo.SelectedValue.ToString());
            itemdetalle.Regmoddetalle = regmoddetalle;
            DetalleInscripcionAlumnoService serviciodetalle = new DetalleInscripcionAlumnoService();
            int respuesta = serviciodetalle.Guardar(itemdetalle);
            if (respuesta == 1)
            {
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
            }
            else if (respuesta == 2)
            {
                MessageBox.Show("El registro se actualizó satisfactoriamente.");
            }
            LimpiarDetalle();
            CargarDetalleDetalle(idActual);
        }


        private void Limpiar()
        {
            txtCliente.Text = string.Empty;
            txtApoderado.Text = string.Empty;
            txtNombre.Text = string.Empty;
            InsertarCodigo();
        }
        private void LimpiarDetalle()
        {
            txtEmpresa.Text = string.Empty;
            cbHorario.DataSource = new HorarioService().Listar(0);
            cbCurso.DataSource = new CursoService().Listar();
            cbPeriodo.DataSource = new PeriodoService().Listar();
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
        private void EliminarDetalle()
        {
            itemdetalle.Id = Int32.Parse(dgvInscripcionAlumnoDetalle.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = serviciodetalle.Eliminar(itemdetalle);
            if (respuesta == 1)
            {
                //Limpiar();
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
                CargarDetalleDetalle(idActual);
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
                dgvInscripcionAlumno.Columns["idapoderado"].Visible = false;
                dgvInscripcionAlumno.Columns["regmod"].Visible = false;


                dgvInscripcionAlumno.Columns["nombre"].DisplayIndex = 1;
                dgvInscripcionAlumno.Columns["nombrecliente"].DisplayIndex = 2;
                dgvInscripcionAlumno.ClearSelection();
            }
        }

        private void CargarDetalleDetalle(int idActual)
        {
            dgvInscripcionAlumnoDetalle.DataSource = serviciodetalle.Detalle(idActual);

            if (dgvInscripcionAlumnoDetalle.RowCount > 0)
            {

                dgvInscripcionAlumnoDetalle.Columns["estado"].Visible = false;
                dgvInscripcionAlumnoDetalle.Columns["regmoddetalle"].Visible = false;
                dgvInscripcionAlumnoDetalle.Columns["idcurso"].Visible = false;
                dgvInscripcionAlumnoDetalle.Columns["idempresa"].Visible = false;
                dgvInscripcionAlumnoDetalle.Columns["idperiodo"].Visible = false;
                dgvInscripcionAlumnoDetalle.Columns["idhorario"].Visible = false;
                dgvInscripcionAlumnoDetalle.Columns["fecharegistro"].Visible = false;
                dgvInscripcionAlumnoDetalle.Columns["idinscripcionalumno"].Visible = false;
                dgvInscripcionAlumnoDetalle.Columns["id"].Visible = false;

                dgvInscripcionAlumnoDetalle.ClearSelection();
            }
        }

        private void InscripcionAlumno_Load(object sender, EventArgs e)
        {
            ListarCursos();
            ListarPeriodos();
            dgvInscripcionAlumno.ClearSelection();
            dgvInscripcionAlumno.CurrentRow.Selected = false;
            dgvInscripcionAlumnoDetalle.ClearSelection();
            dgvInscripcionAlumnoDetalle.CurrentRow.Selected = false;
            txtBuscar.Focus();
        }
        private void LlenarControles()
        {
            idActual = Int32.Parse(dgvInscripcionAlumno.CurrentRow.Cells["id"].Value.ToString());
            idCliente = Int32.Parse(dgvInscripcionAlumno.CurrentRow.Cells["idcliente"].Value.ToString());
            txtCliente.Text = dgvInscripcionAlumno.CurrentRow.Cells["nombrecliente"].Value.ToString();
            idApoderado = Int32.Parse(dgvInscripcionAlumno.CurrentRow.Cells["idapoderado"].Value.ToString());
            txtApoderado.Text = dgvInscripcionAlumno.CurrentRow.Cells["nombreapoderado"].Value.ToString();
            txtNombre.Text = dgvInscripcionAlumno.CurrentRow.Cells["nombre"].Value.ToString();
            CargarDetalleDetalle(idActual);
        }
        private void LlenarControlesDetalle()
        {
            idActualDetalle = Int32.Parse(dgvInscripcionAlumnoDetalle.CurrentRow.Cells["id"].Value.ToString());
            cbCurso.SelectedValue = Int32.Parse(dgvInscripcionAlumnoDetalle.CurrentRow.Cells["idcurso"].Value.ToString());
            cbHorario.SelectedValue = Int32.Parse(dgvInscripcionAlumnoDetalle.CurrentRow.Cells["idhorario"].Value.ToString());
            cbPeriodo.SelectedValue = Int32.Parse(dgvInscripcionAlumnoDetalle.CurrentRow.Cells["idperiodo"].Value.ToString());
            idEmpresa = Int32.Parse(dgvInscripcionAlumnoDetalle.CurrentRow.Cells["idempresa"].Value.ToString());
            txtEmpresa.Text = dgvInscripcionAlumnoDetalle.CurrentRow.Cells["nombreempresa"].Value.ToString();

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
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Se debe seleccionar al alumno antes de matricularlo");
            }
            else
            {
                if (txtApoderado.Text == "")
                {
                    MessageBox.Show("Se debe seleccionar al apoderado antes de matricular a un alumno");
                }
                else
                {

                    Guardar();
                    regmod = 0;
                }
            }
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

        private void btnBuscarApoderado_Click(object sender, EventArgs e)
        {
            DialogCliente dialogCliente = new DialogCliente();
            DialogResult resultado = dialogCliente.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                nombreApoderado = dialogCliente.CargarNombre();
                idApoderado = dialogCliente.CargarId();

            }
            txtApoderado.Text = nombreApoderado;
        }

        private void cbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPeriodo = Int32.Parse(cbPeriodo.SelectedValue.ToString());
        }

        private void cbHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            idHorario = Int32.Parse(cbHorario.SelectedValue.ToString());

        }

        private void btnGuardarDetalle_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(idActual.ToString()) == 0)
            {
                MessageBox.Show("Se debe guardar el alumno antes de inscribirlo a un curso");
                if (txtCliente.Text == "")
                {
                    MessageBox.Show("Se debe seleccionar al alumno antes de inscribirlo a un curso");

                }
            }
            else
            {

                if (cbCurso.SelectedIndex == 0)
                {
                    MessageBox.Show("Debe seleccionarse un curso.");
                }
                else
                {
                    if (txtEmpresa.Text == "")
                    {
                        MessageBox.Show("Debe seleccionarse una Empresa.");
                    }
                    else
                    {
                        if (cbPeriodo.SelectedIndex == 0)
                        {
                            MessageBox.Show("Debe seleccionarse un Periodo.");
                        }
                        else
                        {
                            GuardarDetalle();
                            regmoddetalle = 0;
                        }
                    }
                }

            }



        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarDetalle();
            CargarDetalle();
            CargarDetalleDetalle(0);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvInscripcionAlumno.RowCount > 0)
            {
                if (dgvInscripcionAlumno.CurrentRow.Selected == true)
                {
                    LlenarControles();
                    regmod = 1;
                }
                else
                {
                    MessageBox.Show("No hay ningún registro seleccionado");
                }
            }

        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            EliminarDetalle();
        }

        private void EditarDetalle_Click(object sender, EventArgs e)
        {
            if (dgvInscripcionAlumnoDetalle.RowCount > 0)
            {
                if (dgvInscripcionAlumnoDetalle.CurrentRow.Selected == true)
                {
                    LlenarControlesDetalle();
                    regmoddetalle = 1;
                }
                else
                {
                    MessageBox.Show("No hay ningún registro seleccionado");
                }
            }


        }

        private void NuevoDetalle_Click(object sender, EventArgs e)
        {
            LimpiarDetalle();
        }

        private void imprimir()
        {
            item2.Id = Int32.Parse(dgvInscripcionAlumno.CurrentRow.Cells["id"].Value.ToString());

            DatosAlumno da = servicio.ReporteAlumno(item2);
            AlumnoReporte rpt = new AlumnoReporte();
            rpt.SetDataSource(da);
            AlumnoReporteFormulariocs frmReporte = new AlumnoReporteFormulariocs();
            frmReporte.rp_alumno.ReportSource = rpt;
            frmReporte.ShowDialog();

        }
        private void btnFicha_Click(object sender, EventArgs e)
        {
            if (dgvInscripcionAlumno.RowCount > 0)
            {
                if (dgvInscripcionAlumno.CurrentRow.Selected == true)
                {
                    if (MessageBox.Show("¿Esta seguro de imprimir este registro?", "SisNisei", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        imprimir();
                    }
                }
                else

                    MessageBox.Show("No hay ni un registro seleccionado.");
            }
        }

    }


}