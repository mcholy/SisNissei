using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{

    public class EgresoService
    {
        #region Propiedades
        private string respuesta;
        private EgresoRepository repositorio = new EgresoRepository();
        #endregion
        public int Guardar(EgresoEntity item)
        {
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<EgresoEntity> Detalle()
        {
            return new EgresoRepository().Detalle();
        }

        public int Eliminar(EgresoEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }


    }
}
