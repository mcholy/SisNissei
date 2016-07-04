using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class TipoInscripcionSocioService
    {
        #region Propiedades
        private string respuesta;
        private TipoInscripcionSocioRepository repositorio = new TipoInscripcionSocioRepository();
        #endregion
        public int Guardar(TipoInscripcionSocioEntity item)
        {
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<TipoInscripcionSocioEntity> Detalle()
        {
            return new TipoInscripcionSocioRepository().Detalle();
        }

        public int Eliminar(TipoInscripcionSocioEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
        public List<TipoInscripcionSocioEntity> Listar()
        {
            return new TipoInscripcionSocioRepository().Listar();
        }
    }
}
