using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class InscripcionSocioService
    {
        private string respuesta;
        private InscripcionSocioRepository repositorio = new InscripcionSocioRepository();
        private ReporteSocioRepository reporterepositorio = new ReporteSocioRepository();
        public int Guardar(InscripcionSocioEntity item)
        {
            respuesta = repositorio.Guardar(item);

            return Int32.Parse(respuesta);

        }
        public List<InscripcionSocioEntity> Detalle()
        {

            return new InscripcionSocioRepository().Detalle();
        }
        public int Eliminar(InscripcionSocioEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
        public string Codigo(InscripcionSocioEntity item)
        {
            return new InscripcionSocioRepository().Codigo(item);
        }

        public DatosSocio ReporteSocio(ReporteInscripcionSocioEntity item2)
        {

            DatosSocio ds = reporterepositorio.ReporteSocio(item2);

            return ds;
        }
    }
}
