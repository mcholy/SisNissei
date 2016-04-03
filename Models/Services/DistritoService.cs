using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class DistritoService
    {
        string respuesta;
        private DistritoRepository repositorio = new DistritoRepository();
        public int Guardar(DistritoEntity item)
        {
            respuesta = repositorio.Guardar(item);

            return Int32.Parse(respuesta);

        }
        public List<DistritoEntity> Detalle()
        {

            return new DistritoRepository().Detalle();
        }
        public int Eliminar(DistritoEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
        public List<DistritoEntity> Listar()
        {
            return new DistritoRepository().Listar();
        }
        
    }
}
