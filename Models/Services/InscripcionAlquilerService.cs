﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;
namespace Models.Services
{
    public class InscripcionAlquilerService
    {
        string respuesta;
        private InscripcionAlquilerRepository repositorio = new InscripcionAlquilerRepository();
        private ReporteAlquilerRepository reporterepositorio = new ReporteAlquilerRepository();
        public int Guardar(InscripcionAlquilerEntity item)
        {
            respuesta = repositorio.Guardar(item);

            return Int32.Parse(respuesta);

        }
        public List<InscripcionAlquilerEntity> Detalle()
        {
            return new InscripcionAlquilerRepository().Detalle();
        }
        public int Eliminar(InscripcionAlquilerEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
        public string Codigo(InscripcionAlquilerEntity item)
        {

            return new InscripcionAlquilerRepository().Codigo(item);
        }
        public DatosAlquiler ReporteAlquiler(ReporteInscripcionAlquilerEntity item2)
        {
            DatosAlquiler dal = reporterepositorio.ReporteAlquiler(item2);
            return dal;
        }
    }
}
