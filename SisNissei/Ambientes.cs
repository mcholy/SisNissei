﻿using System;
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
    public partial class Ambientes : Form
    {
        private Validacion itemValidacion = new Validacion();
        private AmbienteEntity item = new AmbienteEntity();
        private AmbienteService servicio = new AmbienteService();
        private int regmod = 0;
        private int idActual = 0;
        public Ambientes()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
            CargarDetalle();
            Skin.AplicarSkinDGV(dgvAmbiente);
        }



        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            regmod = 0;
        
        }

        private void Guardar()
        {
            //item.idtipoemeplado = icbsexo.selectedvalue;
                item.Id = idActual;
                item.Nombre = txtNombre.Text;
                item.Regmod = regmod;
                AmbienteService servicio = new AmbienteService();
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

        private void CargarDetalle()
        {
            dgvAmbiente.DataSource = servicio.Detalle();
            if (dgvAmbiente.RowCount > 0)
            {
                dgvAmbiente.Columns["id"].Visible = false;
                dgvAmbiente.Columns["estado"].Visible = false;
                dgvAmbiente.Columns["regmod"].Visible = false;
                dgvAmbiente.Columns["fecharegistro"].Visible = false;
                dgvAmbiente.Columns["nombre"].DisplayIndex = 0;
                dgvAmbiente.Columns["nombre"].HeaderText = "Nombre";
            }
        }
        private void Eliminar()
        {
            item.Id = Int32.Parse(dgvAmbiente.CurrentRow.Cells["id"].Value.ToString());
            int respuesta = servicio.Eliminar(item);
            if (respuesta == 1)
            {
                //Limpiar();
                MessageBox.Show("El registro se elimino satisfactoriamente.");
                CargarDetalle();
            }
        }
        private void LlenarControles()
        {
            idActual = Int32.Parse(dgvAmbiente.CurrentRow.Cells["id"].Value.ToString());
            txtNombre.Text = dgvAmbiente.CurrentRow.Cells["nombre"].Value.ToString();
        }

        #region Singleton
        private static Ambientes m_FormDefInstance;
        public static Ambientes DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Ambientes();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        #endregion
        private void Ambientes_Load(object sender, EventArgs e)
        {
            dgvAmbiente.ClearSelection();
            dgvAmbiente.CurrentRow.Selected = false;
            txtBuscar.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAmbiente.RowCount > 0)
            {
                if (dgvAmbiente.CurrentRow.Selected == true)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAmbiente.RowCount > 0)
            {
                if (dgvAmbiente.CurrentRow.Selected == true)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            itemValidacion.SoloLetras(e);
        }


    }
}
