using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }

        //constructor vacio
        public Direccion()
        {
            Debug.WriteLine("Constructor Direccon sin parámetros");

        }

        //varias formas de crear un objeto
        public Direccion(string calle, string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor direccion DOS parametros");
        }

        public Direccion(string calle,string ciudad, int cp)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor direccion TRES parametros");
        }
    }
}
