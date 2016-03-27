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
        string respuesta;
        public int Guardar(CursoEntity item)
        {
            CursoRepository repositorio = new CursoRepository();
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<CursoEntity> Detalle()
        {
            return new CursoRepository().Detalle();
        }
    }
}
