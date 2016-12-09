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
        private int idgarante;

        public int Idgarante
        {
            get { return idgarante; }
            set { idgarante = value; }
        }
        private string nombregarante;

        public string Nombregarante
        {
            get { return nombregarante; }
            set { nombregarante = value; }
        }

        private double acuenta;

        public double Acuenta
        {
            get { return acuenta; }
            set { acuenta = value; }
        }
       
        private DateTime horainicio;

        public DateTime Horainicio
        {
            get { return horainicio; }
            set { horainicio = value; }
        }

        

        private DateTime horafin;

        public DateTime Horafin
        {
            get { return horafin; }
            set { horafin = value; }
        }

        

        private string fechainicioalquiler;

        public string Fechainicioalquiler
        {
            get { return fechainicioalquiler; }
            set { fechainicioalquiler = value; }
        }

        private string fechafinalquiler;

        public string Fechafinalquiler
        {
            get { return fechafinalquiler; }
            set { fechafinalquiler = value; }
        }

        private string tipoevento;

        public string Tipoevento
        {
            get { return tipoevento; }
            set { tipoevento = value; }
        }

    }
}
