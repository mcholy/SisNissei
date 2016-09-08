using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    class InscripcionAlquilerEntities
    {
        private int idcliente;

        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        private int idempresa;

        public int Idempresa
        {
            get { return idempresa; }
            set { idempresa = value; }
        }
        private double garantia;

        public double Garantia
        {
            get { return garantia; }
            set { garantia = value; }
        }
        private DateTime fechainicioalquiler;

        public DateTime Fechainicioalquiler
        {
            get { return fechainicioalquiler; }
            set { fechainicioalquiler = value; }
        }
        private DateTime fechafinalquiler;

        public DateTime Fechafinalquiler
        {
            get { return fechafinalquiler; }
            set { fechafinalquiler = value; }
        }



    }
}
