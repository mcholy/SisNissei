using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class TipoEgresoEntity : BaseEntity
    {
        private bool proveedor;

        public bool Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
    }
}
