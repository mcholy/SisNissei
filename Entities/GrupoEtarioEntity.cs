using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class GrupoEtarioEntity : BaseEntity
    {
        private int regmod;

        public int Regmod
        {
            get { return regmod; }
            set { regmod = value; }
        }

    }
}
