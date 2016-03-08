using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SisNissei.Base
{
    public static class BaseView
    {
        public static void SetConfiguration(Form form)
        {
            form.MinimumSize = form.Size;
            form.BackColor = Color.White;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
        }
        public static void SetConfigurationDialog(Form form)
        {
            form.MinimumSize = form.Size;
            form.BackColor = Color.White;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
        }
        public static void SetConfigurationPopUp(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.MinimumSize = form.Size;
            form.BackColor = Color.White;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.Paint += FormPaint;
            form.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
        }

        static void FormPaint(object sender, PaintEventArgs e)
        {
            Form frm = (Form)sender;
            Pen p = new Pen(Color.FromArgb(60, 60, 60), 3);
            e.Graphics.DrawRectangle(p, 0, 0, frm.Width - 1, frm.Height - 1);

        }
    }


}

