﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class AmbienteService
    {
        #region Propiedades
        private string respuesta;
        private AmbienteRepository repositorio = new AmbienteRepository();
        #endregion

        public int Guardar(AmbienteEntity item)
        {
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<AmbienteEntity> Detalle()
        {
            return new AmbienteRepository().Detalle();
        }

        public int Eliminar(AmbienteEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }

        public List<AmbienteEntity> Listar(int idActual)
        {
            return new AmbienteRepository().Listar(idActual);
        }
        public List<AmbienteEntity> ListarenDetalle()
        {
            return new AmbienteRepository().ListarenDetalle();
        }
    }
}
