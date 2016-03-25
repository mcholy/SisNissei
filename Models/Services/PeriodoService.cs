using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class PeriodoService
    {
        string respuesta;
        public int Guardar(PeriodoEntity item)
        {
            PeriodoRepository repositorio = new PeriodoRepository();
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
    }
}
