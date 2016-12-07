using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class ReporteInscripcionAlumnoEntity
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellidocliente;

        public string Apellidocliente
        {
            get { return apellidocliente; }
            set { apellidocliente = value; }
        }
        private string nombrecliente;

        public string Nombrecliente
        {
            get { return nombrecliente; }
            set { nombrecliente = value; }
        }
        private string fechadenacimiento;

        public string Fechadenacimiento
        {
            get { return fechadenacimiento; }
            set { fechadenacimiento = value; }
        }
        private string Distrito;

        public string Distrito1
        {
            get { return Distrito; }
            set { Distrito = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private string nombreapoderado;

        public string Nombreapoderado
        {
            get { return nombreapoderado; }
            set { nombreapoderado = value; }
        }
        private string curso;

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        private string empresa;

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        private string horario;

        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        private string periodo;

        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }
    }
}
