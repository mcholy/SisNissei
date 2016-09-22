using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;
namespace Models.Services
{
    public class DetalleInscripcionAlquilerService
    {
        string respuesta;
        private DetalleInscripcionAlquilerRepository repositorio = new DetalleInscripcionAlquilerRepository();
        public int Guardar(DetalleInscripcionAlquilerEntity itemdetalle)
        {
            respuesta = repositorio.Guardar(itemdetalle);

            return Int32.Parse(respuesta);

        }
        public List<DetalleInscripcionAlquilerEntity> Detalle(int idActual)
        {

            return new DetalleInscripcionAlquilerRepository().Detalle(idActual);
        }

        public int Eliminar(DetalleInscripcionAlquilerEntity itemdetalle)
        {
            respuesta = repositorio.Eliminar(itemdetalle);
            return Int32.Parse(respuesta);
        }

    }
}
