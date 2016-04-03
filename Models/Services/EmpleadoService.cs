using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class EmpleadoService
    {
        private string respuesta;
        private EmpleadoRepository repositorio = new EmpleadoRepository();
        public int Guardar(EmpleadoEntity item)
        {
            EmpleadoRepository repositorio = new EmpleadoRepository();
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }

        public List<EmpleadoEntity> Detalle()
        {
            return new EmpleadoRepository().Detalle();
        }
        public int Eliminar(EmpleadoEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
    }
}
