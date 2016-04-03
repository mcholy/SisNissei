using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Models.Repositories;

namespace Models.Services
{
    public class ClienteService
    {
        #region Propiedades
        private string respuesta;
        private ClienteRepository repositorio = new ClienteRepository();
        #endregion

        public int Guardar(ClienteEntity item)
        {
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<ClienteEntity> Detalle()
        {
            return new ClienteRepository().Detalle();
        }

        public int Eliminar(ClienteEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
    }
}
