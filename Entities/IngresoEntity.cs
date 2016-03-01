using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class IngresoEntity : BaseEntity
    {
        private int idusuario;

        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }
        private int idinscripcion;

        public int Idinscripcion
        {
            get { return idinscripcion; }
            set { idinscripcion = value; }
        }
        private int idempresa;

        public int Idempresa
        {
            get { return idempresa; }
            set { idempresa = value; }
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
