using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class BaseEntity
    {
        private int id;
        private bool estado;
        private string nombre;
        private DateTime fecharegistro;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public DateTime Fecharegistro
        {
            get { return fecharegistro; }
            set { fecharegistro = value; }
        }


        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
