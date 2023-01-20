using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Mes
    {
        public int TempMaxima { get; set; }
        public int TempMinima { get; set; }
        public string NombreMes { get; set; }

        public float GetTemperaturaMedia()
        {
            return (this.TempMaxima + this.TempMinima) / 2;
        }
    }
}
