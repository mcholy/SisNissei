using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SisNissei.Template
{
  public static class Skin
    {
        public static void AplicarSkin(Form formulario)
        {
            formulario.MinimumSize = formulario.Size;
            formulario.BackColor = Color.White;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.MinimizeBox = false;
        }
        public static void AplicarSkinDialog(Form formulario)
        {
            formulario.MinimumSize = formulario.Size;
            formulario.BackColor = Color.White;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.MinimizeBox = false;
            formulario.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            formulario.ShowIcon = false;
            formulario.ShowInTaskbar = false;
        }
        public static void AplicarSkinPopUp(Form formulario)
        {
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.MinimumSize = formulario.Size;
            formulario.BackColor = Color.White;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.MinimizeBox = false;
            formulario.Paint += formulario_Paint;
            formulario.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            formulario.ShowIcon = false;
            formulario.ShowInTaskbar = false;
        }

        static void formulario_Paint(object sender, PaintEventArgs e)
        {
            Form frm = (Form)sender;
            Pen p = new Pen(Color.FromArgb(60, 60, 60), 3);
            e.Graphics.DrawRectangle(p, 0, 0, frm.Width - 1, frm.Height - 1);

        }
    }
}
