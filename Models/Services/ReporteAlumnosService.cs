using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class ReporteAlumnosService
    {
        private string respuesta;
        private ReporteAlumnosRepository repositorio = new ReporteAlumnosRepository();
        public List<ReporteAlumnosEntity> Detalle(ReporteAlumnosEntity item)
        {

            return new ReporteAlumnosRepository().Detalle(item);
        }
    }
}
