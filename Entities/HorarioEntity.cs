using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class HorarioEntity : BaseEntity
    {
        private string dia;

        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        private string hora;

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        private DateTime fechainicio;

        public DateTime Fechainicio
        {
            get { return fechainicio; }
            set { fechainicio = value; }
        }

        private int idgrupoetario;

        public int Idgrupoetario
        {
            get { return idgrupoetario; }
            set { idgrupoetario = value; }
        }

        private int idcurso;

        public int Idcurso
        {
            get { return idcurso; }
            set { idcurso = value; }
        }

        private int idHorario;

        public int IdHorario
        {
            get { return idHorario; }
            set { idHorario = value; }
        }

        private string nombregrupoetario;

        public string Nombregrupoetario
        {
            get { return nombregrupoetario; }
            set { nombregrupoetario = value; }
        }
        private string nombrecurso;

        public string Nombrecurso
        {
            get { return nombrecurso; }
            set { nombrecurso = value; }
        }
        private int duracion;

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
    }
}
