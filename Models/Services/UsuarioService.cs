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
        string respuesta;
        public int Guardar(UsuarioEntity item)
        {
            UsuarioRepository repositorio = new UsuarioRepository();
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<UsuarioEntity> Detalle() {

            return new UsuarioRepository().Detalle();
        }
    }
}
