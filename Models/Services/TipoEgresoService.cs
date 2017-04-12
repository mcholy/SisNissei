using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Repositories;
using Entities;


namespace Models.Services
{
    public class TipoEgresoService
    {
        string respuesta;
        private TipoEgresoRepository repositorio = new TipoEgresoRepository();
        public int Guardar(TipoEgresoEntity item)
        {
            respuesta = repositorio.Guardar(item);

            return Int32.Parse(respuesta);

        }
         public List<TipoEgresoEntity> Detalle() {

            return new TipoEgresoRepository().Detalle();
        }
         public int Eliminar(TipoEgresoEntity item)
         {
             respuesta = repositorio.Eliminar(item);
             return Int32.Parse(respuesta);
         }
         public List<TipoEgresoEntity> ListarTipoPago()
         {
             return new TipoEgresoRepository().ListarTipoPago();
         }
    }
}
