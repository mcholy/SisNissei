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
        string respuesta;
        public int Guardar(EmpresaEntity item)
        {
            EmpresaRepository repositorio = new EmpresaRepository();
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
    }
}
