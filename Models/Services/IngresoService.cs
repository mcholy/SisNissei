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
        private ResultadoEntity resultado;
        private IngresoRepository repositorio = new IngresoRepository();
        private ReporteIngresoRepository reporterepositorio = new ReporteIngresoRepository();
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
        public int Eliminar(IngresoEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
        public string Codigo(IngresoEntity item)
        {

            return new IngresoRepository().Codigo(item);
            
        }
        public List<IngresoEntity> PagosPendientes(int idCliente, int idTipoIngreso, int nropago,int idCurso)
        {

            return new IngresoRepository().PagosPendientes(idCliente, idTipoIngreso, nropago,idCurso);
        }
        public ResultadoEntity Guardar(IngresoEntity item)
        {
            resultado = new ResultadoEntity();
            resultado = repositorio.Guardar(item);

            return resultado;
        }

        public ResultadoEntity GuardarDetalle(IngresoEntity item)
        {
            resultado = new ResultadoEntity();
            resultado = repositorio.GuardarDetalle(item);

            return resultado;

        }
        public DatosIngreso ReporteIngreso(ReporteIngresoEntity item2)
        {
            DatosIngreso dai = reporterepositorio.ReporteIngreso(item2);
            return dai;
        }
        public List<IngresoEntity> Detalle()
        {
            return new IngresoRepository().Detalle();
        }
    }
}
