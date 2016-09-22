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
 

        private DetalleInscripcionAlquilerEntity itemdetalle=new DetalleInscripcionAlquilerEntity();



        private int regmod = 0;
        private int idActual = 0;

        public InscripcionAlquiler()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
        
         
        }
        private void Limpiar()
        {
 
        }
        private void InscripcionAlquiler_Load(object sender, EventArgs e)
        {

        }
    }
}
