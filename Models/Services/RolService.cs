using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class RolService
    {
        string respuesta;
        private RolRepository repositorio = new RolRepository();
        public int Guardar(RolEntity item)
        {
            respuesta = repositorio.Guardar(item);

            return Int32.Parse(respuesta);

        }
        public List<RolEntity> Detalle()
        {

            return new RolRepository().Detalle();
        }
        public List<RolEntity> Listar()
        {
            return new RolRepository().Listar();
        }
        public int Eliminar(RolEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
    }
}
