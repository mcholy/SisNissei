using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class ReporteAlumnosEntity
    {
        private string nombrecliente;

        public string Nombrecliente
        {
            get { return nombrecliente; }
            set { nombrecliente = value; }
        }
        private string curso;

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        private string grupoetario;

        public string Grupoetario
        {
            get { return grupoetario; }
            set { grupoetario = value; }
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
        private string periodo;

        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }
        private int idperiodo;

        public int Idperiodo
        {
            get { return idperiodo; }
            set { idperiodo = value; }
        }
        private string iniciocurso;

        public string Iniciocurso
        {
            get { return iniciocurso; }
            set { iniciocurso = value; }
        }
        private int pagoporcancelar;

        public int Pagoporcancelar
        {
            get { return pagoporcancelar; }
            set { pagoporcancelar = value; }
        }
        private int pagorealziado;

        public int Pagorealziado
        {
            get { return pagorealziado; }
            set { pagorealziado = value; }
        }
        private int totalpagoshacer;

        public int Totalpagoshacer
        {
            get { return totalpagoshacer; }
            set { totalpagoshacer = value; }
        }
        private string estadopago;

        public string Estadopago
        {
            get { return estadopago; }
            set { estadopago = value; }
        }
        private int mespago;

        public int Mespago
        {
            get { return mespago; }
            set { mespago = value; }
        }
       

    }
}
