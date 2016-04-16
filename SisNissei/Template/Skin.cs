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

        public static void AplicarSkinDGV(DataGridView datagridview)
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();


            datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            //datagridview.ColumnHeadersHeight = 28;
            datagridview.AllowUserToAddRows = false;
            //datagridview.AllowUserToDeleteRows = false;
            datagridview.AllowUserToResizeRows = false;
            datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            //datagridview.AutoGenerateColumns = false;
            datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview.BackgroundColor = System.Drawing.Color.White;
            datagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            datagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            //dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;



            datagridview.EnableHeadersVisualStyles = false;
            //datagridview.Location = new System.Drawing.Point(12, 70);
            datagridview.MultiSelect = false;
            datagridview.ReadOnly = true;
            datagridview.RowHeadersVisible = false;
            datagridview.AllowUserToResizeColumns = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(223, 223, 223);
            //dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            datagridview.RowsDefaultCellStyle = dataGridViewCellStyle2;
            datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            //datagridview.Size = new System.Drawing.Size(100, 100);
        }
    }
}
