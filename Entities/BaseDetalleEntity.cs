using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class BaseDetalleEntity
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private DateTime fecharegistro;

        public DateTime Fecharegistro
        {
            get { return fecharegistro; }
            set { fecharegistro = value; }
        }
        private int regmoddetalle;

        public int Regmoddetalle
        {
            get { return regmoddetalle; }
            set { regmoddetalle = value; }
        }

    }
}
