using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class UsuarioService
    {
        #region Propiedades
        private string respuesta;
        private UsuarioRepository repositorio = new UsuarioRepository();
        #endregion
        
        public int Guardar(UsuarioEntity item)
        {
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<UsuarioEntity> Detalle() {

            return new UsuarioRepository().Detalle();
        }
        public int Eliminar(UsuarioEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
    }
}
