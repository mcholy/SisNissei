using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;
namespace Models.Services
{
    public class IngresoService
    {
        string respuesta;
        string direccion;
        string dni;
        IngresoRepository repositorio = new IngresoRepository();
        public string DatosFacDir(IngresoEntity idcliente)
        {
            direccion = repositorio.DatosFacDir(idcliente);
            return direccion;
        }
        public string DatosFacDni(IngresoEntity idcliente)
        {
            dni = repositorio.DatosFacDni(idcliente);
            return dni;
        }
        public List<IngresoEntity> ListarTipoIngreso()
        {
            return new IngresoRepository().ListarTipoIngreso();
        }
        public string Codigo(IngresoEntity item)
        {

            return new IngresoRepository().Codigo(item);
            
        }
        public List<IngresoEntity> PagosPendientes(int idCliente, int idTipoIngreso, int nropago,int idCurso)
        {

            return new IngresoRepository().PagosPendientes(idCliente, idTipoIngreso, nropago,idCurso);
        }

    }
}
