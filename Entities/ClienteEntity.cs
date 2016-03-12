using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class ClienteEntity : BaseEntity
    {
        
        private string apellidopaterno;

        public string Apellidopaterno
        {
            get { return apellidopaterno; }
            set { apellidopaterno = value; }
        }
        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private string apellidomaterno;

        public string Apellidomaterno
        {
            get { return apellidomaterno; }
            set { apellidomaterno = value; }
        }

        private bool sexo;

        public bool Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        private int idapoderado;

        public int Idapoderado
        {
            get { return idapoderado; }
            set { idapoderado = value; }
        }
        private int iddistrito;

        public int Iddistrito
        {
            get { return iddistrito; }
            set { iddistrito = value; }
        }
        private DateTime fechanacimiento;

        public DateTime Fechanacimiento
        {
            get { return fechanacimiento; }
            set { fechanacimiento = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string celular;

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string alergia;

        public string Alergia
        {
            get { return alergia; }
            set { alergia = value; }
        }
    }
}
