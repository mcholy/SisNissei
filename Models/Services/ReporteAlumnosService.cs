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
       
        private ReporteAlumnosRepository repositorio = new ReporteAlumnosRepository();
        public List<ReporteAlumnosEntity> Detalle(ReporteAlumnosEntity item)
        {
            return new ReporteAlumnosRepository().Detalle(item);
        }
        public DatosReporteAlumnos Reporte(ReporteAlumnosEntity item)
        {
            DatosReporteAlumnos dra = repositorio.Reporte(item); ;
            return dra;

        }
    }
}
