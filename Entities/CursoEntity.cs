using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class CursoEntity : BaseEntity
    {
        private int idempleado;

        public int Idempleado
        {
            get { return idempleado; }
            set { idempleado = value; }
        }
        private double inicial;

        public double Inicial
        {
            get { return inicial; }
            set { inicial = value; }
        }
        private double mensualidad;

        public double Mensualidad
        {
            get { return mensualidad; }
            set { mensualidad = value; }
        }
        private string nombreempleado;

        public string Nombreempleado
        {
            get { return nombreempleado; }
            set { nombreempleado = value; }
        }

        private int regmod;

        public int Regmod
        {
            get { return regmod; }
            set { regmod = value; }
        }
    }
}
