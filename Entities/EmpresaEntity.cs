using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class EmpresaEntity : BaseEntity
    {
        private double descuento;
        private List<ClienteEntity> clientes;

        public List<ClienteEntity> Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }


        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        private int regmod;

        public int Regmod
        {
            get { return regmod; }
            set { regmod = value; }
        }
    }
}
