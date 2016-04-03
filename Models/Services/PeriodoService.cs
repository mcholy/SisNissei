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
        private PeriodoRepository repositorio = new PeriodoRepository();
        public int Guardar(PeriodoEntity item)
        {
            respuesta = repositorio.Guardar(item);

            return Int32.Parse(respuesta);

        }
        public List<PeriodoEntity> Detalle() {

            return new PeriodoRepository().Detalle();
        }
        public int Eliminar(PeriodoEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
    }
}
