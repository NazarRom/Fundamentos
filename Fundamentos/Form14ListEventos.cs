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
    public partial class Form14ListEventos : Form
    {
        //declaramos la coleccion a nivel de clase
        //para utilizar en otors eventos
        List<Button> botones;
        //vamos a tener una variable contador
        //las variables a nivel de clase
        //mantienen su valor mientras estemos trabajando con 
        //esta clase
        int contador;

        public Form14ListEventos()
        {
            InitializeComponent();
           this.botones = new List<Button>();
            //vamos a rellenar la coleccion con todos los botones
            //del dibujo
            //this.botones.Add(this.button1);
            //this.botones.Add(this.button2);
            //dentro de la clase control (fomr) tenemos
            //una coleccion llamada Controls que contiene todos los controles del form
            //vamos a recorrer todos los contorles y añadimos a 
            //nuestra coleccion de forma dinamica
            //una de las normaas es tener siempre nuestras colecciones
            //no las del programa
            foreach(Control control in this.Controls)
            {
               //debemos preguntar por los controles button
               if(control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }

            //aqui manejamos nuestra coleccion personalizada
            //asociamos cada boton de la coleccion a un metodo evento
            foreach (Button boton in this.botones)
            {
                boton.Click += BotonPulsado;
            }
        }

        private void BotonPulsado(object? sender, EventArgs e)
        {
            this.contador += 1;
            this.txtMensaje.Text = "Contador: " + this.contador;
            //necesito acceder al boton, cuando pulsemos sobre el
            //boton, cambiamos su color...
            Button boton = (Button)sender;
            boton.BackColor = Color.LightBlue;
            boton.Text = this.contador.ToString();
        }
    }
}
