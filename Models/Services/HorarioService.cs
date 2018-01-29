using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class HorarioService
    {

        private ResultadoEntity resultado;
        private HorarioRepository repositorio = new HorarioRepository();
        public ResultadoEntity Guardar(HorarioEntity item)
        {
            resultado = new ResultadoEntity();
            resultado = repositorio.Guardar(item);

            return resultado;
        }
        public ResultadoEntity GuardarDetalle(HorarioEntity item)
        {
            resultado = new ResultadoEntity();
            resultado = repositorio.GuardarDetalle(item);

            return resultado;

        }
        public List<HorarioEntity> Detalle(int idPeriodoFiltro)
        {
            return new HorarioRepository().Detalle(idPeriodoFiltro);
        }

        public List<HorarioEntity> DetalleHorario_Detalle(int id)
        {
            return new HorarioRepository().DetalleHorario_Detalle(id);
        } 
        public ResultadoEntity Eliminar(HorarioEntity item)
        {
            resultado = new ResultadoEntity();
            resultado = repositorio.Eliminar(item);
            return resultado;
        }
        public List<HorarioEntity> Listar(int idcurso)
        {
            return new HorarioRepository().Listar(idcurso);
        }
        public ResultadoEntity EliminarDetalle(HorarioEntity item)
        {
            resultado = new ResultadoEntity();
            resultado = repositorio.EliminarDetalle(item);
            return resultado;
        }
    }
}
