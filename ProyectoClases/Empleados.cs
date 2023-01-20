using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleados: Persona       
    {
        protected int SalarioMinimo { get; set; }
        public Empleados()
        {
            Debug.WriteLine("Constructor Empleado vacío");
            this.SalarioMinimo = 1500;

        }
        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public Empleados(string nombre, string apellidos)
            :base(nombre,apellidos)
        {
            Debug.WriteLine("Constructor Empleado 2 parametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

      
    }
}
