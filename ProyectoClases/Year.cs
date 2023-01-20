using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Year
    {
        public int TempMaximaAnio { get; set; }
        public int TempMinimaAnio { get; set; }
        public int Anyo { get; set; }

        public float TempMediaAnio { get; set; }

        public List<Mes> Meses { get; set; }

        public Year ()
        {
            this.GenerarMeses();

        }
        public Year (int anyo)
        {
            this.Anyo = anyo;
            this.GenerarMeses();
        }
        private void GenerarMeses()
        {
            Meses = new List<Mes>();
            DateTime tiempo = DateTime.Parse("01/01/2023");
            Random random = new Random();
            for (int i = 1; i <= 12; i++)
            {
                string nombreMes = tiempo.ToString("MMMM").ToUpper();
                Mes mes = new Mes();
                mes.NombreMes = nombreMes;
                mes.TempMaxima = random.Next(10, 50);
                mes.TempMinima = random.Next(-19, 9);
                this.Meses.Add(mes);
                tiempo = tiempo.AddMonths(1);

            }
        }

        public int GetMaximaAnual()
        {
            int maxima = 0;
            foreach(Mes mes in this.Meses)
            {
                maxima = Math.Max(maxima, mes.TempMaxima);
            }
            return maxima;
        }

        public int GetMinimaAnual()
        {
            int minima = 0;
            foreach (Mes mes in this.Meses)
            {
                minima = Math.Max(minima, mes.TempMaxima);
            }
            return minima;
        }

        public float GetMediaAnual()
        {
            float suma = 0;
            foreach (Mes mes in this.Meses)
            {
                suma = mes.GetTemperaturaMedia();
            }
            return suma / this.Meses.Count;
        }
    }
}
