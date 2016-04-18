using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class InscripcionSocioEntity:BaseEntity
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
        private int idconyugue;

        public int Idconyugue
        {
            get { return idconyugue; }
            set { idconyugue = value; }
        }
        private string nombreconyugue;

        public string Nombreconyugue
        {
            get { return nombreconyugue; }
            set { nombreconyugue = value; }
        }
        private int idpatrocinador;

        public int Idpatrocinador
        {
            get { return idpatrocinador; }
            set { idpatrocinador = value; }
        }
        private string nombrepatrocinador;

        public string Nombrepatrocinador
        {
            get { return nombrepatrocinador; }
            set { nombrepatrocinador = value; }
        }
        private string trabajo;

        public string Trabajo
        {
            get { return trabajo; }
            set { trabajo = value; }
        }
        private string cargo;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        private int hijosmayores;

        public int Hijosmayores
        {
            get { return hijosmayores; }
            set { hijosmayores = value; }
        }
        private int hijosmenores;

        public int Hijosmenores
        {
            get { return hijosmenores; }
            set { hijosmenores = value; }
        }
        private int familiarjapon;

        public int Familiarjapon
        {
            get { return familiarjapon; }
            set { familiarjapon = value; }
        }
        private int familiareeuu;

        public int Familiareeuu
        {
            get { return familiareeuu; }
            set { familiareeuu = value; }
        }
        private int familiaritalia;

        public int Familiaritalia
        {
            get { return familiaritalia; }
            set { familiaritalia = value; }
        }
        private int familiarotros;

        public int Familiarotros
        {
            get { return familiarotros; }
            set { familiarotros = value; }
        }
        private int regmod;

        public int Regmod
        {
            get { return regmod; }
            set { regmod = value; }
        }
    }
}
