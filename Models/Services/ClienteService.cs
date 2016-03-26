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
        string respuesta;
        public int Guardar(ClienteEntity item)
        {
            ClienteRepository repositorio = new ClienteRepository();
            respuesta = repositorio.Guardar(item);
            return Int32.Parse(respuesta);
        }
    }
}
