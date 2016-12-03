using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class AmbienteDescripcionService
    {
        #region Propiedades
        private string respuesta;
        private AmbienteDescripcionRepository repositorio = new AmbienteDescripcionRepository();
        #endregion
        public int Guardar(AmbienteDescripcionEntity item)
        {
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<AmbienteDescripcionEntity> Detalle()
        {
            return new AmbienteDescripcionRepository().Detalle();
        }
        public int Eliminar(AmbienteDescripcionEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }

        public List<AmbienteDescripcionEntity> Listar()
        {
            return new AmbienteDescripcionRepository().Listar();
        }
    }
}
