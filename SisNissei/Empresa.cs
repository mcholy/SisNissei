﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SisNissei.Template;

namespace SisNissei
{
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
            Skin.AplicarSkin(this);
        }
    }
}
