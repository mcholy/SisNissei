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
        string respuesta;
        public int Guardar(TipoEmpleadoEntity item)
        {
            TipoEmpleadoRepository repositorio = new TipoEmpleadoRepository();
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<TipoEmpleadoEntity> Listar()
        {
            return new TipoEmpleadoRepository().Listar();
        }
        public List<TipoEmpleadoEntity> Detalle()
        {
            return new TipoEmpleadoRepository().Detalle();
        }
    }
}
