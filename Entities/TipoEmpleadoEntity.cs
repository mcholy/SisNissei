using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class TipoEmpleadoEntity : BaseEntity
    {
        private double porcentajemensual;

        public double Porcentajemensual
        {
            get { return porcentajemensual; }
            set { porcentajemensual = value; }
        }
        private double porcentajematricula;

        public double Porcentajematricula
        {
            get { return porcentajematricula; }
            set { porcentajematricula = value; }
        }
    }
}
