using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;
namespace Models.Services
{
    public class InscripcionAlumnoService
    {
        string respuesta;
        private InscripcionAlumnoRepository repositorio = new InscripcionAlumnoRepository();
        private ReporteAlumnoRepository reporterepositorio=new ReporteAlumnoRepository();
        public int Guardar(InscripcionAlumnoEntity item)
        {
            respuesta = repositorio.Guardar(item);

            return Int32.Parse(respuesta);

        }
        public List<InscripcionAlumnoEntity> Detalle()
        {
            return new InscripcionAlumnoRepository().Detalle();
        }
        public int Eliminar(InscripcionAlumnoEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
        public string Codigo(InscripcionAlumnoEntity item)
        {

            return new InscripcionAlumnoRepository().Codigo(item);
        }
        public DatosAlumno ReporteAlumno(ReporteInscripcionAlumnoEntity item2)
        {
            DatosAlumno da = reporterepositorio.ReporteAlumno(item2);
            return da;
        }
    }
}
