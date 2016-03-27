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
        public int Guardar(TipoEgresoEntity item)
        {
            TipoEgresoRepository repositorio = new TipoEgresoRepository();
            respuesta = repositorio.Guardar(item);

            return Int32.Parse(respuesta);

        }
         public List<TipoEgresoEntity> Detalle() {

            return new TipoEgresoRepository().Detalle();
        }
    }
}
