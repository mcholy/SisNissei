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
    public partial class Horario : Form
    {
        private HorarioService servicio = new HorarioService();
        private HorarioEntity item;
        private ResultadoEntity resultado;
        private string[] rowDetalle;
        private int regmod = 0;
        private int idActual = 0;
        public Horario()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            Skin.AplicarSkinDGV(dgvHorario);
            Skin.AplicarSkinDGV(dgvDetalleHorario);
        }

        private void Horario_Load(object sender, EventArgs e)
        {
            ListarCursos();
            ListarGruposEtarios();
            CrearColumnasDGV();
            CargarDetalle();
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
            dgvDetalleHorario.Columns[0].Visible = false;
            dgvDetalleHorario.Columns[1].Name = "HORARIO";
            dgvDetalleHorario.Columns[2].Name = "DIA";
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
            return cadena.Trim();
        }


        private string LlenarDia(string cadena)
        {
            string cadenasalida = String.Empty;
            cadenasalida += cadena.Substring(0, 1) == "1" ? "Lun " : "";
            cadenasalida += cadena.Substring(1, 1) == "1" ? "Mar " : "";
            cadenasalida += cadena.Substring(2, 1) == "1" ? "Mie " : "";
            cadenasalida += cadena.Substring(3, 1) == "1" ? "Jue " : "";
            cadenasalida += cadena.Substring(4, 1) == "1" ? "Vie " : "";
            cadenasalida += cadena.Substring(5, 1) == "1" ? "Sab " : "";
            cadenasalida += cadena.Substring(6, 1) == "1" ? "Dom " : "";
            return cadenasalida.Trim();
        }

        private void Limpiar()
        {
            txtHorario.Text = string.Empty;
            txtduracion.Text = string.Empty;
            regmod = 0;
            idActual = 0;
            cbCurso.SelectedValue = 0;
            cbGrupoEtario.SelectedValue = 0;
            chkLunes.Checked = false;
            chkMartes.Checked = false;
            chkMiercoles.Checked = false;
            chkJueves.Checked = false;
            chkViernes.Checked = false;
            chkSabado.Checked = false;
            chkDomingo.Checked = false;
            dgvDetalleHorario.Rows.Remove(dgvDetalleHorario.CurrentRow);
        }

        private void CargarDetalle()
        {
            dgvHorario.DataSource = servicio.Detalle();

            if (dgvHorario.RowCount > 0)
            {
                dgvHorario.Columns["id"].Visible = false;
                dgvHorario.Columns["estado"].Visible = false;
                dgvHorario.Columns["idcurso"].Visible = false;
                dgvHorario.Columns["idgrupoetario"].Visible = false;
                dgvHorario.Columns["idhorario"].Visible = false;
                dgvHorario.Columns["dia"].Visible = false;                
                dgvHorario.Columns["hora"].Visible = false;
                dgvHorario.Columns["regmod"].Visible = false;
                dgvHorario.Columns["fecharegistro"].Visible = false;
                dgvHorario.Columns["estado"].Visible = false;
                dgvHorario.Columns["nombre"].Visible = false;
                //dgvHorario.Columns["nombre"].DisplayIndex = 1;
                dgvHorario.ClearSelection();
            }
        }

        private void btnHora_Click(object sender, EventArgs e)
        {
            if (txtHorario.Text.Trim() != String.Empty)
            {
                PasarDatosDGV();
            }
        }

        private void Guardar()
        {
            resultado = new ResultadoEntity();
            item = new HorarioEntity();
            if (dgvDetalleHorario.RowCount > 0)
            {
                item.Id = idActual;
                item.Idcurso = Int32.Parse(cbCurso.SelectedValue.ToString());
                item.Idgrupoetario = Int32.Parse(cbGrupoEtario.SelectedIndex.ToString());
                item.Fechainicio = DateTime.Parse(dtpFechaInicio.Text);
                item.Duracion = Int32.Parse(txtduracion.Text);
                item.Regmod = regmod;
                resultado = servicio.Guardar(item);
                item = new HorarioEntity();
                item.IdHorario = resultado.Id;
                foreach (DataGridViewRow fila in dgvDetalleHorario.Rows)
                {
                    //Accediendo por el nombre de la columna
                    item.Hora = fila.Cells["HORARIO"].Value.ToString();
                    item.Dia = fila.Cells["CODIGO"].Value.ToString();
                    //Accediendo con el indice de la columna
                    //item.Hora=fila.Cells[1].Value.ToString();
                    resultado = servicio.GuardarDetalle(item);
                }

                if (Int32.Parse(resultado.Respuesta) == 1)
                {
                    MessageBox.Show("El registro se ingreso satisfactoriamente.");
                }
                else if (Int32.Parse(resultado.Respuesta) == 2)
                {
                    MessageBox.Show("El registro se actualizó satisfactoriamente.");
                }

                Limpiar();
                CargarDetalle();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Guardar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHorario.RowCount > 0)
            {
                if (dgvHorario.CurrentRow.Selected == true)
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

        private void Eliminar()
        {
            item = new HorarioEntity();
            item.Id = Int32.Parse(dgvHorario.CurrentRow.Cells["id"].Value.ToString());
            resultado = new ResultadoEntity();
            resultado = servicio.Eliminar(item);
            if (Int32.Parse(resultado.Respuesta) == 1)
            {
                //Limpiar();
                MessageBox.Show("El registro se ingreso satisfactoriamente.");
                CargarDetalle();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvHorario.RowCount > 0)
            {
                if (dgvHorario.CurrentRow.Selected == true)
                {
                    dgvDetalleHorario.DataSource = null;
                    dgvDetalleHorario.Rows.Clear();
                    LlenarControles();
                    regmod = 1;
                }
                else
                {
                    MessageBox.Show("No hay ningún registro seleccionado");
                }
            }
        }

        private void LlenarControles()
        {
            idActual = Int32.Parse(dgvHorario.CurrentRow.Cells["id"].Value.ToString());
            cbCurso.SelectedValue = Int32.Parse(dgvHorario.CurrentRow.Cells["idcurso"].Value.ToString());
            cbGrupoEtario.SelectedValue = Int32.Parse(dgvHorario.CurrentRow.Cells["idgrupoetario"].Value.ToString());
            dtpFechaInicio.Value = DateTime.Parse(dgvHorario.CurrentRow.Cells["fechainicio"].Value.ToString());
            txtduracion.Text=dgvHorario.CurrentRow.Cells["duracion"].Value.ToString();
            CargarDetalleHorario_Detalle(idActual);
        }

        private void CargarDetalleHorario_Detalle(int id)
        {
            List<HorarioEntity> lista = servicio.DetalleHorario_Detalle(id);

            foreach (HorarioEntity valor in lista)
            {
                
                rowDetalle = new string[] { valor.Dia, valor.Hora, LlenarDia(valor.Dia) };
                dgvDetalleHorario.Rows.Add(rowDetalle);
                dgvDetalleHorario.ClearSelection();
            }
            
        }

    }
}
