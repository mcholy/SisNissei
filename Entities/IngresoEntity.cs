using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class IngresoEntity : BaseEntity
    {
        private string nombreusuario;

        public string Nombreusuario
        {
            get { return nombreusuario; }
            set { nombreusuario = value; }
        }
        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private int idcliente;

        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }


        private int idtipoingreso;

        public int Idtipoingreso
        {
            get { return idtipoingreso; }
            set { idtipoingreso = value; }
        }

        private bool tipocomprobante;

        public bool Tipocomprobante
        {
            get { return tipocomprobante; }
            set { tipocomprobante = value; }
        }
        private int numerocomprobante;

        public int Numerocomprobante
        {
            get { return numerocomprobante; }
            set { numerocomprobante = value; }
        }
        private double monto;

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }
    }
}
