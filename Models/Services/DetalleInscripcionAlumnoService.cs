using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class DetalleInscripcionAlumnoService
    {
        string respuesta;
        private DetalleInscripcionAlumnoRepository repositorio = new DetalleInscripcionAlumnoRepository();
        public int Guardar(DetalleInscripcionAlumnoEntity itemdetalle)
        {
            respuesta = repositorio.Guardar(itemdetalle);

            return Int32.Parse(respuesta);

        }
        public List<DetalleInscripcionAlumnoEntity> Detalle(int idActual)
        {

            return new DetalleInscripcionAlumnoRepository().Detalle(idActual);
        }
        public int Eliminar(DetalleInscripcionAlumnoEntity itemdetalle)
        {
            respuesta = repositorio.Eliminar(itemdetalle);
            return Int32.Parse(respuesta);
        }
    }
}
