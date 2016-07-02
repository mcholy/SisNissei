using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class InscripcionAlumnoEntity : BaseEntity
    {
        private int idcliente;

        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        private string nombrecliente;

        public string Nombrecliente
        {
            get { return nombrecliente; }
            set { nombrecliente = value; }
        }
        private int idapoderado;

        public int Idapoderado
        {
            get { return idapoderado; }
            set { idapoderado = value; }
        }
        private string nombreapoderado;

        public string Nombreapoderado
        {
            get { return nombreapoderado; }
            set { nombreapoderado = value; }
        }
        private string nombrecurso;

        public string Nombrecurso
        {
            get { return nombrecurso; }
            set { nombrecurso = value; }
        }
        private string nombreempresa;

        public string Nombreempresa
        {
            get { return nombreempresa; }
            set { nombreempresa = value; }
        }
        private string nombreperiodo;

        public string Nombreperiodo
        {
            get { return nombreperiodo; }
            set { nombreperiodo = value; }
        }
        private string codigos;

        public string Codigos
        {
            get { return codigos; }
            set { codigos = value; }
        }

      
        private int idcurso;

        public int Idcurso
        {
            get { return idcurso; }
            set { idcurso = value; }
        }
        private int idempresa;

        public int Idempresa
        {
            get { return idempresa; }
            set { idempresa = value; }
        }
        private int idperiodo;

        public int Idperiodo
        {
            get { return idperiodo; }
            set { idperiodo = value; }
        }

        private int idhorario;

        public int Idhorario
        {
            get { return idhorario; }
            set { idhorario = value; }
        }
        private string nombrehorario;

        public string Nombrehorario
        {
            get { return nombrehorario; }
            set { nombrehorario = value; }
        }
    }
}
