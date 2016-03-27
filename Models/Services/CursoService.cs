using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class CursoService
    {
        #region Propiedades
        private string respuesta;
        private CursoRepository repositorio = new CursoRepository();
        #endregion

        public int Guardar(CursoEntity item)
        {
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<CursoEntity> Detalle()
        {
            return new CursoRepository().Detalle();
        }

        public int Eliminar(CursoEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
    }
}
