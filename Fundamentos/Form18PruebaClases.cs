using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form18PruebaClases : Form
    {
        public Form18PruebaClases()
        {
            InitializeComponent();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Domicilio = new Direccion("Calle Pez", "Madrid", 28050);

            this.lstPersonas.Items.Add("Nombre: " + persona.Nombre);
            this.lstPersonas.Items.Add("Direccion " + persona.Domicilio.Calle);
           
            persona.Apellidos = "Net Core";
            persona.Edad = 29;
            persona.Nacionalidad = Paises.Italia;
            persona.Genero = TipoGenero.Femenino;
            //ahora puedo pasarle entre 1 parametro y 2
            persona.MetodoParametrosOpcionales(77);
            persona.MetodoParametrosOpcionales(88, 78);
            //solo quiero enviar el parametro 1 y el 2
            persona.MetodoParametrosOpcionales(1, numero2: 2);
            

            this.lstPersonas.Items.Add(persona.Nombre + " " + persona.Apellidos + " " + persona.Edad + "" + persona.Nacionalidad + " " + persona.Genero);
            this.lstPersonas.Items.Add(persona.GetNombreCompleto());
           

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //Empleados empleado = new Empleados();
            //empleado.Nombre = "Empleado";
            //empleado.Apellidos = " Empleado";
            //this.lstPersonas.Items.Add(empleado.GetNombreCompleto()
            //     + "Salario " + empleado.GetSalarioMinimo());
            //this.lstPersonas.Items.Add(empleado.GetNombreCompleto()
            //    + ", Vacaciones " + empleado.GetDiasVacaciones());



            Director director = new Director();
            director.Nombre = "Dire";
            director.Apellidos = "Dire";
            this.lstPersonas.Items.Add(director.GetNombreCompleto()
                + ", Salario " + director.GetSalarioMinimo());
            this.lstPersonas.Items.Add(director.GetNombreCompleto()
                + ", Vacaciones " + director.GetDiasVacaciones());
            this.lstPersonas.Items.Add(director.ToString());
        }
    }
}
