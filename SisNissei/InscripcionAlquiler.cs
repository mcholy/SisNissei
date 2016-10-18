using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SisNissei.Template;
using Entities;
using Models.Services;


namespace SisNissei
{
    public partial class InscripcionAlquiler : Form
    {
        private Validacion ItemValidacion = new Validacion();
        private InscripcionAlquilerEntity item = new InscripcionAlquilerEntity();
        private InscripcionAlumnoService servicio = new InscripcionAlumnoService();

        private DetalleInscripcionAlquilerEntity itemdetalle=new DetalleInscripcionAlquilerEntity();

        private string nombreCliente = "";
        private int idCliente = 0;
        private int idAmbiente=0;
        private int regmod = 0;
        private int idActual = 0;

        public InscripcionAlquiler()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            InsertarCodigo();
        Skin.AplicarSkinDGV(dgvInscripcionAlquiler);
            Skin.AplicarSkinDGV(dgvInscripcionAlquilerDetalle);
         
        }
        #region Singleton
        private static InscripcionAlquiler m_FormDefInstance;
        public static InscripcionAlquiler DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new InscripcionAlquiler();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion
        private void Limpiar()
        {
            InsertarCodigo();
            txtCliente.Text = string.Empty;
            txtGarantia.Text = string.Empty;
            dtpHoraFin.ResetText();
            dtpHoraInicio.ResetText();

        }
         private void InsertarCodigo()
        {
            txtNombre.Text = new InscripcionAlquilerService().Codigo(item);
        }
         private void ListarAmbientes(int idActual)
        {
            cbAmbiente.DisplayMember = "Nombre";
            cbAmbiente.ValueMember = "Id";
            cbAmbiente.DataSource = new AmbienteService().Listar(idActual);
        }

        private void InscripcionAlquiler_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
              if (txtCliente.Text == "")
            {
                MessageBox.Show("Se debe seleccionar al alumno antes de matricularlo");
            }
              else{
           
                Guardar();
                regmod = 0;
            }}
         private void Guardar()
        {
            item.Id = idActual;
            item.Nombre = txtNombre.Text;
            item.Idcliente = idCliente;
             
             item.Horainicio=DateTime.Parse(dtpHoraInicio.Text);

             item.Horafin = DateTime.Parse(dtpHoraFin.Text);
             item.Garantia=double.Parse(txtGarantia.Text);
            item.Regmod = regmod;
            InscripcionAlquilerService servicio = new InscripcionAlquilerService();
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
                MessageBox.Show("La Hora ingresada ya esta ocupada.");
            }
            Limpiar();
            CargarDetalle();
        }

         private void CargarDetalle()
         {
             dgvInscripcionAlquiler.DataSource = servicio.Detalle();

             if (dgvInscripcionAlquiler.RowCount > 0)
             {
                 dgvInscripcionAlquiler.Columns["id"].Visible = false;
                 dgvInscripcionAlquiler.Columns["estado"].Visible = false;
                 dgvInscripcionAlquiler.Columns["idcliente"].Visible = false;

                 dgvInscripcionAlquiler.Columns["regmod"].Visible = false;
                 dgvInscripcionAlquiler.Columns["nombre"].DisplayIndex = 1;

                 dgvInscripcionAlquiler.ClearSelection();
             }
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
            ListarAmbientes(idActual);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        
        }
        }
    

