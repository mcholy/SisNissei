using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class AmbienteDetalleEntity : BaseEntity
    {
        private int idAmbiente;

        public int IdAmbiente
        {
            get { return idAmbiente; }
            set { idAmbiente = value; }
        }
        private string nombreambiente;

        public string Nombreambiente
        {
            get { return nombreambiente; }
            set { nombreambiente = value; }
        }
        private bool TipoCliente;

        public bool TipoCliente1
        {
            get { return TipoCliente; }
            set { TipoCliente = value; }
        }

        private string NombreTipoCliente;

        public string NombreTipoCliente1
        {
            get { return NombreTipoCliente; }
            set { NombreTipoCliente = value; }
        }

  
        private int costo;

        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        private int idAmbienteDescripcion;

        public int IdAmbienteDescripcion
        {
            get { return idAmbienteDescripcion; }
            set { idAmbienteDescripcion = value; }
        }

        private string nombreambientedescripcion;

        public string Nombreambientedescripcion
        {
            get { return nombreambientedescripcion; }
            set { nombreambientedescripcion = value; }
        }

    }
}
