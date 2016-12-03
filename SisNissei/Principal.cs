using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SisNissei
{
    public partial class Principal : Form
    {
        private int childFormNumber = 0;

        public Principal()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFFFF");
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

           
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente.DefInstance.MdiParent = this;
            Cliente.DefInstance.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresa.DefInstance.MdiParent = this;
            Empresa.DefInstance.Show();
        }

        private void periodoDeMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Periodo.DefInstance.MdiParent = this;
            Periodo.DefInstance.Show();
        }

        private void distritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Distrito.DefInstance.MdiParent = this;
            Distrito.DefInstance.Show();
        }

        
        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuario.DefInstance.MdiParent = this;
            Usuario.DefInstance.Show();
        }

        private void rolEnSistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rol.DefInstance.MdiParent = this;
            Rol.DefInstance.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Curso.DefInstance.MdiParent = this;
            Curso.DefInstance.Show();
        }

        private void empleadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Empleado.DefInstance.MdiParent = this;
            Empleado.DefInstance.Show();
        }

        private void tipoDeEmpleadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TipoEmpleado.DefInstance.MdiParent = this;
            TipoEmpleado.DefInstance.Show();
        }

      
        private void horarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Horario.DefInstance.MdiParent = this;
            Horario.DefInstance.Show();
        }

        private void rangoDeEdadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrupoEtario.DefInstance.MdiParent = this;
            GrupoEtario.DefInstance.Show();
        }


        private void inscripcionAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InscripcionAlumno.DefInstance.MdiParent = this;
            InscripcionAlumno.DefInstance.Show();
        }

        private void inscripcionSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InscripcionSocio.DefInstance.MdiParent = this;
            InscripcionSocio.DefInstance.Show();
        }

        private void tipoDeInscripcionDeSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoInscripcionSocio.DefInstance.MdiParent = this;
            TipoInscripcionSocio.DefInstance.Show();
        }



        private void alquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InscripcionAlquiler.DefInstance.MdiParent = this;
            InscripcionAlquiler.DefInstance.Show();
        }

        private void ambientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                
            Ambientes.DefInstance.MdiParent = this;
            Ambientes.DefInstance.Show();
        
        }

        private void ambienteDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
                  
            AmbienteDetalle.DefInstance.MdiParent = this;
            AmbienteDetalle.DefInstance.Show();
        
        }
               
    }
}
