using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class EmpleadoEntity : BaseEntity
    {
        private string paterno;

        public string Paterno
        {
            get { return paterno; }
            set { paterno = value; }
        }
        private string materno;

        public string Materno
        {
            get { return materno; }
            set { materno = value; }
        }
        private string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private double sueldobase;

        public double Sueldobase
        {
            get { return sueldobase; }
            set { sueldobase = value; }
        }
        private int idtipoempleado;

        public int Idtipoempleado
        {
            get { return idtipoempleado; }
            set { idtipoempleado = value; }
        }

        private string celular;


        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
       
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string nombreTipoEmpleado;

        public string NombreTipoEmpleado
        {
            get { return nombreTipoEmpleado; }
            set { nombreTipoEmpleado = value; }
        }
        private string nombreempleado;

        public string Nombreempleado
        {
            get { return nombreempleado; }
            set { nombreempleado = value; }
        }
        private int regmod;

        public int Regmod
        {
            get { return regmod; }
            set { regmod = value; }
        }
    }
}
