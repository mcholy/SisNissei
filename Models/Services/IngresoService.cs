using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Repositories;
using Entities;

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
        public List<IngresoEntity> PagosPendientes(int idCliente, int idTipoIngreso, int nropago)
        {

            return new IngresoRepository().PagosPendientes(idCliente, idTipoIngreso, nropago);
        }

    }
}
