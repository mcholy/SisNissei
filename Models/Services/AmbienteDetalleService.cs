using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class AmbienteDetalleService
    {
        #region Propiedades
        private string respuesta;
        private AmbienteDetalleRepository repositorio = new AmbienteDetalleRepository();
        #endregion

        public int Guardar(AmbienteDetalleEntity item)
        {
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<AmbienteDetalleEntity> Detalle()
        {
            return new AmbienteDetalleRepository().Detalle();
        }

        public int Eliminar(AmbienteDetalleEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
        public List<AmbienteDetalleEntity> Listar(int idambiente, int idactual)
        {
            return new AmbienteDetalleRepository().Listar(idambiente, idactual);
        }
    }
}
