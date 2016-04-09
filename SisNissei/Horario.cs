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
    public partial class Horario : Form
    {
        public Horario()
        {
            InitializeComponent();
        }

        private void Horario_Load(object sender, EventArgs e)
        {

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
    }
}
