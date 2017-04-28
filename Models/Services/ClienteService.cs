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
        string direccion;
        string telefono;
        string celular;
        private string respuesta;
        private ClienteRepository repositorio = new ClienteRepository();
        #endregion

        public int Guardar(ClienteEntity item)
        {
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
        public List<ClienteEntity> Detalle(int idtipoingreso)
        {
            return new ClienteRepository().Detalle(idtipoingreso);
        }

        public int Eliminar(ClienteEntity item)
        {
            respuesta = repositorio.Eliminar(item);
            return Int32.Parse(respuesta);
        }
        public string DatosApoDir(ClienteEntity idApoderado)
        {
            direccion = repositorio.DatosApoDir(idApoderado);
            return direccion;
        }
        public string DatosApoTel(ClienteEntity idApoderado)
        {
            telefono = repositorio.DatosApoTel(idApoderado);
            return telefono;
        }
        public string DatosApoCel(ClienteEntity idApoderado)
        {
            celular = repositorio.DatosApoCel(idApoderado);
            return celular;
        }
    }
}
