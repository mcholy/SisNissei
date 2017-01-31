using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class ReporteIngresoEntity
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string nombretipocomprobante;

        public string Nombretipocomprobante
        {
            get { return nombretipocomprobante; }
            set { nombretipocomprobante = value; }
        }
        private string nombrecliente;

        public string Nombrecliente
        {
            get { return nombrecliente; }
            set { nombrecliente = value; }
        }
        private string dni;

        public string Dni
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
        private string fechapago;

        public string Fechapago
        {
            get { return fechapago; }
            set { fechapago = value; }
        }
        private string detallepago;

        public string Detallepago
        {
            get { return detallepago; }
            set { detallepago = value; }
        }
        private string detallemonto;

        public string Detallemonto
        {
            get { return detallemonto; }
            set { detallemonto = value; }
        }
        private string montototal;

        public string Montototal
        {
            get { return montototal; }
            set { montototal = value; }
        }
    }
}
