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
        public int Guardar(DistritoEntity item)
        {
            DistritoRepository repositorio = new DistritoRepository();
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta); 
        }
        public List<DistritoEntity> Listar() {
            return new DistritoRepository().Listar();
        }
    }
}
