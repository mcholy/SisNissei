using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class AmbienteEntity : BaseEntity
    {
        private double costo;

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        private bool tipocliente;

        public bool Tipocliente
        {
            get { return tipocliente; }
            set { tipocliente = value; }
        }
        private string nombretipocliente;

        public string Nombretipocliente
        {
            get { return nombretipocliente; }
            set { nombretipocliente = value; }
        }
    }
}
