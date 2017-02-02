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

        private int tipocomprobante;

        public int Tipocomprobante
        {
            get { return tipocomprobante; }
            set { tipocomprobante = value; }
        }
        private string nombrerecibo;

        public string Nombrerecibo
        {
            get { return nombrerecibo; }
            set { nombrerecibo = value; }
        }
        private int idfactura;

        public int Idfactura
        {
            get { return idfactura; }
            set { idfactura = value; }
        }
     
        private double monto;

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }
    }
}
