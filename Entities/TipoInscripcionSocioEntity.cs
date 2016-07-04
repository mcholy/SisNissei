using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class TipoInscripcionSocioEntity : BaseEntity
    {
        private double costo;

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }
    }
}
