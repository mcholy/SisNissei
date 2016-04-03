using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class EmpresaService
    {
        #region Propiedades
        private string respuesta;
        private EmpresaRepository repositorio = new EmpresaRepository();
        #endregion

        public int Guardar(EmpresaEntity item)
        {
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<EmpresaEntity> Detalle()
        {
            return new EmpresaRepository().Detalle();
        }

        public int Eliminar(EmpresaEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
    }
}
