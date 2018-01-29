using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class PagoProfesoresEntity:BaseEntity
    {
        private int idempleado;

        public int Idempleado
        {
            get { return idempleado; }
            set { idempleado = value; }
        }

        private string curso;

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        private int idcurso;

        public int Idcurso
        {
            get { return idcurso; }
            set { idcurso = value; }
        }
       
        
        private int idperiodo;

        public int Idperiodo
        {
            get { return idperiodo; }
            set { idperiodo = value; }
        }
        private int mespago;

        public int Mespago
        {
            get { return mespago; }
            set { mespago = value; }
        }

        private string pagarxmatricula;

        public string Pagarxmatricula
        {
            get { return pagarxmatricula; }
            set { pagarxmatricula = value; }
        }
        private string ingresxmatricula;

        public string Ingresxmatricula
        {
            get { return ingresxmatricula; }
            set { ingresxmatricula = value; }
        }
        private string pagarxmensualidad;

        public string Pagarxmensualidad
        {
            get { return pagarxmensualidad; }
            set { pagarxmensualidad = value; }
        }
        private string ingresoxmensualidad;

        public string Ingresoxmensualidad
        {
            get { return ingresoxmensualidad; }
            set { ingresoxmensualidad = value; }
        }
        private string totalingreso;

        public string Totalingreso
        {
            get { return totalingreso; }
            set { totalingreso = value; }
        }

        private string montopagar;

        public string Montopagar
        {
            get { return montopagar; }
            set { montopagar = value; }
        }
    }
}
