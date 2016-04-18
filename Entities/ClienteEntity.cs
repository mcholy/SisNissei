using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class ClienteEntity : BaseEntity
    {

        private string paterno;

        public string Paterno
        {
            get { return paterno; }
            set { paterno = value; }
        }

        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private string materno;

        public string Materno
        {
            get { return materno; }
            set { materno = value; }
        }

        private string nombrecliente;

        public string Nombrecliente
        {
            get { return nombrecliente; }
            set { nombrecliente = value; }
        }

        private bool sexo;

        public bool Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string nombreapoderado;

        public string Nombreapoderado
        {
            get { return nombreapoderado; }
            set { nombreapoderado = value; }
        }
        private string nombredistrito;

        public string Nombredistrito
        {
            get { return nombredistrito; }
            set { nombredistrito = value; }
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
        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private int celular;

        public int Celular
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
