using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class GrupoEtarioService
    {
        #region Propiedades
        private string respuesta;
        private GrupoEtarioRepository repositorio = new GrupoEtarioRepository();
        #endregion

        public int Guardar(GrupoEtarioEntity item)
        {
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<GrupoEtarioEntity> Detalle()
        {
            return new GrupoEtarioRepository().Detalle();
        }

        public int Eliminar(GrupoEtarioEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
        public List<GrupoEtarioEntity> Listar()
        {
            return new GrupoEtarioRepository().Listar();
        }
        
    }
}
