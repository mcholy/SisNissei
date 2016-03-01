using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class UsuarioEntity : BaseEntity
    {
        private int idempleado;

        public int Idempleado
        {
            get { return idempleado; }
            set { idempleado = value; }
        }
        private int idrol;

        public int Idrol
        {
            get { return idrol; }
            set { idrol = value; }
        }
        private string contrasenia;

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }
    }
}
