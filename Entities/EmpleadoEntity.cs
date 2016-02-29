using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class EmpleadoEntity : BaseEntity
    {
        private string paterno;
        private string materno;
        private string dni;
        private int idempleado;

        public int Idempleado
        {
            get { return idempleado; }
            set { idempleado = value; }
        }
        private string telefono;
        private string celular;
        private string direccion;
        private double sueldobase;
        
    }
}
