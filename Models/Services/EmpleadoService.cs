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
        string respuesta;
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
        
    }
}
