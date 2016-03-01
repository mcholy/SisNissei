﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class HorarioEntity : BaseEntity
    {
        private char dia;

        public char Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        private string hora;

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
