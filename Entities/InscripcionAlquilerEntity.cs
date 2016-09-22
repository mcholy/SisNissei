using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class InscripcionAlquilerEntity : BaseEntity
    {
        private int idcliente;

        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        private string nombrecliente;

        public string Nombrecliente
        {
            get { return nombrecliente; }
            set { nombrecliente = value; }
        }

        private int idempresa;

        public int Idempresa
        {
            get { return idempresa; }
            set { idempresa = value; }
        }

        private string nombreempresa;

        public string Nombreempresa
        {
            get { return nombreempresa; }
            set { nombreempresa = value; }
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
