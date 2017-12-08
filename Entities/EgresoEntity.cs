using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class EgresoEntity : BaseEntity
    {
        private int idempleado;

        public int Idempleado
        {
            get { return idempleado; }
            set { idempleado = value; }
        }
        private string nombreempleado;

        public string Nombreempleado
        {
            get { return nombreempleado; }
            set { nombreempleado = value; }
        }

        private int idusuario;

        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }
        private int idtipoegreso;

        public int Idtipoegreso
        {
            get { return idtipoegreso; }
            set { idtipoegreso = value; }
        }
        private string proveedor;

        public string Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }

        private string tipoegreso;

        public string Tipoegreso
        {
            get { return tipoegreso; }
            set { tipoegreso = value; }
        }

        private decimal monto;

        public decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        
        
       
        private string detalle;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
    }
}
