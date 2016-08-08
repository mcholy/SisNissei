using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class InscripcionAlumnoEntity : BaseEntity
    {
        private int idcliente;

        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        private string nombrecliente;

        public string Nombrecliente
        {
            get { return nombrecliente; }
            set { nombrecliente = value; }
        }
        private int idapoderado;

        public int Idapoderado
        {
            get { return idapoderado; }
            set { idapoderado = value; }
        }
        private string nombreapoderado;

        public string Nombreapoderado
        {
            get { return nombreapoderado; }
            set { nombreapoderado = value; }
        }
       
        

      
    }
}
