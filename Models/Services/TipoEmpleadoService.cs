using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class TipoEmpleadoService
    {
        #region Propiedades
        private string respuesta;
        private TipoEmpleadoRepository repositorio = new TipoEmpleadoRepository();
        #endregion

        public int Guardar(TipoEmpleadoEntity item)
        {
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<TipoEmpleadoEntity> Detalle()
        {
            return new TipoEmpleadoRepository().Detalle();
        }

        public int Eliminar(TipoEmpleadoEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
        public List<TipoEmpleadoEntity> Listar()
        {
            return new TipoEmpleadoRepository().Listar();
        }
    }
}
