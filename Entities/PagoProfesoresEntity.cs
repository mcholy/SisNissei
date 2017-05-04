using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class PagoProfesoresEntity:BaseEntity
    {
        private string periodo;

        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }
        private string montopagar;

        public string Montopagar
        {
            get { return montopagar; }
            set { montopagar = value; }
        }
        private int idcurso;

        public int Idcurso
        {
            get { return idcurso; }
            set { idcurso = value; }
        }
        private int idperiodo;

        public int Idperiodo
        {
            get { return idperiodo; }
            set { idperiodo = value; }
        }
        private int mespago;

        public int Mespago
        {
            get { return mespago; }
            set { mespago = value; }
        }

    }
}
