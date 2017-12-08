using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class ResultadoEntity : BaseEntity
    {
        private string respuesta;
        public string Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }
        private int id_res;

        public int Id_res
        {
            get { return id_res; }
            set { id_res = value; }
        }
    }
}
