using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class PagoProfesoresService
    {
       
        private PagoProfesoresRepository repositorio = new PagoProfesoresRepository();
        public List<PagoProfesoresEntity> Detalle(PagoProfesoresEntity item)
        {
            return new PagoProfesoresRepository().Detalle(item);
        }
       
    }
}
