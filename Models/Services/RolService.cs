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
        public int Guardar(RolEntity item)
        {
            RolRepository repositorio = new RolRepository();
            respuesta = repositorio.Guardar(item);

            return Int32.Parse(respuesta); 
            
        }
        public List<RolEntity> Listar()
        {
            return new RolRepository().Listar();
        }
        public List<RolEntity> Detalle()
        {

            return new RolRepository().Detalle();
        }
    }
}
