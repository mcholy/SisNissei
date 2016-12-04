using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
   public class DetalleInscripcionAlquilerEntity:BaseDetalleEntity
    {
        private int idalquiler;

        public int Idalquiler
        {
            get { return idalquiler; }
            set { idalquiler = value; }
        }
       private int idambientes;

       public int Idambientes
       {
           get { return idambientes; }
           set { idambientes = value; }
       }
      
       private string nombreambientes;

       public string Nombreambientes
       {
           get { return nombreambientes; }
           set { nombreambientes = value; }
       }
       private int idambientedescripcion;

       public int Idambientedescripcion
       {
           get { return idambientedescripcion; }
           set { idambientedescripcion = value; }
       }
       private string nombreambientedescripcion;

       public string Nombreambientedescripcion
       {
           get { return nombreambientedescripcion; }
           set { nombreambientedescripcion = value; }
       }
       private double costos;

       public double Costos
       {
           get { return costos; }
           set { costos = value; }
       }

    }
}
